using DatabaseModule;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace AppModule
{
    using MRQ = OslearningPlatformContext.MostRepliedQuestion;

    public partial class AppForm : Form
    {
        private User? authenticatedUser;

        private MainForm parent;

        private const int nTopQuestions = 5;

        public bool Authenticated { get { return authenticatedUser is not null; } }

        public void AfterAuthentication(User user)
        {
            userProfileButton.Tag = authenticatedUser = user;
            userProfileButton.Text = user.Name ?? user.Login;
            if (MainForm.DBContext.IsModerator(user.UserId))
            {
                MainForm.DBContext = new("DbModerator", "1qaz2wsx");
            }
            else
            {
                SetEnabledManagingControls(false);
                MainForm.DBContext = new("DbUser", "qwerty");
            }
            LoadUserInfo();
        }

        public void Logout()
        {
            SaveAttendanceAndPerformance();
            authenticatedUser = null;
            MainForm.DBContext = new();
            parent.SetCurrentForm("loginForm");
        }

        public AppForm(in MainForm parent)
        {
            InitializeComponent();

            this.parent = parent;

            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;

            authenticatedUser = null;

            ReloadWikiTree();
            wikiTreeView.AfterSelect += OnTreeNodeSelected;
            ShowMain();
        }

        private void LoadCourseInfo()
        {
            CourseProgram overall = MainForm.DBContext.CoursePrograms.First();
            informationLabel.Text = $"INFO\nThemes: {overall.ThemesCount ?? 0}\nTotal: {overall.OverallDuration ?? 0}h";
        }

        private void LoadUserInfo()
        {
            DateTime? lastOnline;
            try
            {
                AttendanceAndPerformance userPerformance = MainForm.DBContext.AttendanceAndPerformances.Where(u => u.UserId == authenticatedUser.UserId).First();
                lastOnline = userPerformance.LastOnline;
            }
            catch
            {
                lastOnline = null;
            }
            userInformation.Text = $"Last online: {(lastOnline is null ? "Never" : lastOnline.ToString())}";
        }

        public void SetEnabledManagingControls(bool state)
        {
            editContentsButton.Enabled = state;
            newUnitButton.Enabled = state;
            newThemeButton.Enabled = state;
        }

        public void ReloadWikiTree()
        {
            wikiTreeView.Nodes.Clear();

            TreeNode main = wikiTreeView.Nodes.Add("main", "Main");
            main.Tag = -1;
            wikiTreeView.SelectedNode = main;

            foreach (Unit unit in MainForm.DBContext.Units)
            {
                wikiTreeView.Nodes.Add(unit.UnitId.ToString(), unit.Name.TrimEnd()).Tag = unit.UnitId;
            }

            var units = MainForm.DBContext.Units.Join(MainForm.DBContext.Themes,
                u => u.UnitId, t => t.UnitId, (u, t) => new
                {
                    UnitId = u.UnitId,
                    UnitName = u.Name,
                    ThemeId = t.ThemeId,
                    ThemeName = t.Name
                });

            foreach (var value in units)
            {
                int unitId = value.UnitId;
                string unitName = value.UnitName.TrimEnd();
                wikiTreeView.Nodes[unitId.ToString()]!.Nodes.Add(value.ThemeId.ToString(), value.ThemeName.TrimEnd()).Tag = value.ThemeId;
            }

            LoadCourseInfo();
        }

        private void HtmlViewerSetVisible(bool state)
        {
            Action<Control?> handler = state ? tabControl.Controls.Add : tabControl.Controls.Remove;
            if (state != tabControl.Controls.Contains(filePage))
            {
                handler(filePage);
            }
        }

        private void ShowMain()
        {
            contentName.Text = "Welcome to OS Learning Platform!";
            contentDescription.Text = "Select a theme in the right panel.";
            contentInformation.Text = "";
            questionDecsrLabel.Text = $"Top {nTopQuestions} questions";

            questionsList.Tag = -1;
            questionsList.Items.Clear();
            foreach (MRQ u in MainForm.DBContext.MostRepliedQuestions(nTopQuestions))
            {
                questionsList.Items.Add(u);
            }
            HtmlViewerSetVisible(false);
        }

        private void ShowUnitInformation(int unitId)
        {
            Unit unit = MainForm.DBContext.Units.Where(unit => unit.UnitId == unitId).First();

            questionDecsrLabel.Text = contentName.Text = unit.Name.TrimEnd();
            contentDescription.Text = (unit.Description ?? "No description").TrimEnd();

            int themesCount = MainForm.DBContext.CoursePrograms.Where(u => u.UnitId == unitId).First().ThemesCount ?? 0;
            contentInformation.Text = $"Themes count: {themesCount}";
            questionsList.Tag = 0;

            HtmlViewerSetVisible(false);
        }

        private void ShowThemeInformation(int themeId)
        {
            List<Theme> list = MainForm.DBContext.Themes.Where(theme => theme.ThemeId == themeId).ToList();

            if (list.Count == 0) return;

            Theme theme = list[0];

            questionDecsrLabel.Text = contentName.Text = theme.Name.TrimEnd();
            contentDescription.Text = (theme.Description ?? "No description").TrimEnd();
            contentInformation.Text = $"Recommended duration: {theme.RecommendedDuration}\nType: {MainForm.DBContext.ThemeTypes.First(x => x.Value == theme.Type.TrimEnd()).Key}";

            questionsList.Tag = 1;
            questionsList.Items.Clear();
            var result = MainForm.DBContext.Questions.Where(q => q.ThemeId == theme.ThemeId);
            foreach (Question q in result)
            {
                questionsList.Items.Add(q);
            }

            if (theme.ThemeFileUrl is null)
            {
                HtmlViewerSetVisible(false);
            }
            else
            {
                webViewer.Source = new(theme.ThemeFileUrl.Trim());
                HtmlViewerSetVisible(true);
            }
        }

        private void OnTreeNodeSelected(object? sender, TreeViewEventArgs e)
        {
            if (e.Node is null) return;

            switch (e.Node.Level)
            {
                case 0:
                    questionButton.Visible = false;
                    if ((int)e.Node.Tag == -1) ShowMain();
                    else ShowUnitInformation((int)e.Node.Tag);
                    break;
                case 1:
                    questionButton.Visible = true;
                    ShowThemeInformation((int)e.Node.Tag);
                    break;
                default:
                    MessageBox.Show("Not existing node selected", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    break;
            }
        }

        private void OnUsernameClick(object sender, EventArgs e)
        {
            if (authenticatedUser is null)
            {
                MessageBox.Show("No user", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new UserDetails(this, authenticatedUser).ShowDialog();
        }

        private void OnNewUnitClick(object sender, EventArgs e) => new EditUnit(this).ShowDialog();

        private void OnNewThemeClick(object sender, EventArgs e) => new EditTheme(this).ShowDialog();

        private void OnEditClick(object sender, EventArgs e)
        {
            if ((int)wikiTreeView.SelectedNode.Tag == -1)
            {
                return;
            }

            switch (wikiTreeView.SelectedNode.Level)
            {
                case 0:
                    new EditUnit(this, (int)wikiTreeView.SelectedNode.Tag).ShowDialog();
                    break;
                case 1:
                    new EditTheme(this, (int)wikiTreeView.SelectedNode.Tag).ShowDialog();
                    break;
                default:
                    return;
            }
        }

        public void SaveAttendanceAndPerformance()
        {
            int? themeId = null;

            if (wikiTreeView.SelectedNode is not null && wikiTreeView.SelectedNode.Level == 1)
                themeId = (int)wikiTreeView.SelectedNode.Tag;

            MainForm.DBContext.UpdateAttendanceAndPerformance(authenticatedUser!.UserId, themeId);
            MainForm.DBContext.SaveChanges();
        }

        private void OnQuestionSelected(object sender, EventArgs e)
        {
            if (questionsList.SelectedItem is null || authenticatedUser is null) return;

            int tag = (int)questionsList.Tag!;

            if (tag == -1)
            {
                MRQ s = (questionsList.SelectedItem as MRQ)!;
                new RepliesForm(s.QuestionId, authenticatedUser).Show();
            }
            else
            {
                Question s = (questionsList.SelectedItem as Question)!;
                new RepliesForm(s.QuestionId, authenticatedUser).Show();
            }
        }

        private void OnAskQuestionClick(object sender, EventArgs e)
        {
            if (authenticatedUser is null) return;

            new NewQuestion((int)wikiTreeView.SelectedNode.Tag, authenticatedUser.UserId).Show();
        }
    }
}
