using DatabaseModule;
using Microsoft.EntityFrameworkCore;

namespace AppModule
{
    public partial class UserDetails : Form
    {
        private User user;
        private AppForm parent;

        string newEncryptedPassword;

        public UserDetails(in AppForm parent, User user)
        {
            InitializeComponent();
            this.parent = parent;

            loginText.Text = user.Login.Trim();
            nameText.Text = (user.Name ?? "").Trim();
            this.user = user;

            InitModeratorButton();

            newEncryptedPassword = user.EncryptedPassword;
        }

        private void InitModeratorButton()
        {
            if (MainForm.DBContext.IsModerator(user.UserId))
            {
                moderatorButton.Text = "Active";
                moderatorButton.ForeColor = Color.Green;
            }
            else
            {
                moderatorButton.Click += OnModeratorActiveButtonClick;
            }
        }

        private void OnCloseClick(object sender, EventArgs e) => Close();

        private void OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                MainForm.DBContext.Update(user);
                user.Login = loginText.Text;
                user.Name = nameText.Text;

                MainForm.DBContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                string details = "";
                if (ex.InnerException is not null)
                {
                    details += "\n\n" + ex.InnerException.Message;
                }
                MessageBox.Show($"Could not change user information:\n{ex.Message}{details}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnPasswordChangeClick(object sender, EventArgs e)
        {
            new PasswordChangeForm(user).ShowDialog();
        }

        private void OnModeratorActiveButtonClick(object sender, EventArgs e)
        {
            ModeratorForm form = new();
            form.ShowDialog();

            if (!form.Result)
            {
                MessageBox.Show("Unfortunately, you haven't become a moderator", "Bad luck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainForm.DBContext = new("DbModerator", "1qaz2wsx");
            MainForm.DBContext.SetAsModerator(user.UserId);

            moderatorButton.Text = "Active";
            moderatorButton.ForeColor = Color.Green;
            moderatorButton.Click -= OnModeratorActiveButtonClick;

            parent.SetEnabledManagingControls(true);
            MessageBox.Show("You have become a moderator", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            parent.Logout();
            Close();
        }
    }
}
