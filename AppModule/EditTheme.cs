using DatabaseModule;
using Microsoft.EntityFrameworkCore;

namespace AppModule
{
    public partial class EditTheme : Form
    {
        private AppForm parent;
        private int id;
        private Theme? editable;

        public bool AddRecord { get { return id == -1; } }

        public EditTheme(in AppForm parent, int id = -1)
        {
            InitializeComponent();

            unitCombo.Items.AddRange(MainForm.DBContext.Units.ToArray());
            unitCombo.SelectedIndex = 0;

            typeCombo.Items.AddRange(MainForm.DBContext.ThemeTypes.Keys.ToArray());
            typeCombo.SelectedIndex = 0;
            this.parent = parent;
            this.id = id;

            if (AddRecord)
            {
                Text = "Add New Theme";
                editButton.Text = "Add New Theme";
                editButton.Click += OnAddButtonClick;
                deleteButton.Visible = false;
            }
            else
            {
                editButton.Click += OnEditButtonClick;
                editable = MainForm.DBContext.Themes.Where(t => t.ThemeId == id).First();

                unitCombo.Text = editable.Unit.Name.TrimEnd();
                themeText.Text = editable.Name.TrimEnd();
                typeCombo.Text = MainForm.DBContext.ThemeTypes.First(u => u.Value == editable.Type.TrimEnd()).Key;
                durationNumeric.Value = editable.RecommendedDuration;
                descriptionText.Text = (editable.Description ?? "").TrimEnd();
                fileUrlText.Text = (editable.ThemeFileUrl ?? "").TrimEnd();

                MainForm.DBContext.Themes.Update(editable);
            }
        }

        private void OnCloseButton(object sender, EventArgs e) => Close();

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string themeType = MainForm.DBContext.ThemeTypes[typeCombo.Text];

            try
            {
                editable!.UnitId = ((Unit)unitCombo.SelectedItem!).UnitId;
                editable.Name = themeText.Text;
                editable.Description = descriptionText.Text.Trim() != "" ? descriptionText.Text : null;
                editable.RecommendedDuration = Convert.ToInt32(durationNumeric.Value);
                editable.Type = themeType;
                editable.ThemeFileUrl = fileUrlText.Text.Trim() != "" ? fileUrlText.Text : null;

                MainForm.DBContext.SaveChanges();
                MessageBox.Show("Theme edited successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                parent.ReloadWikiTree();
            }
            catch (DbUpdateException ex)
            {
                string details = "";
                if (ex.InnerException is not null)
                {
                    details += "\n\n" + ex.InnerException.Message;
                }
                MessageBox.Show($"Error occurred:\n{ex.Message}{details}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string themeType = MainForm.DBContext.ThemeTypes[typeCombo.Text];

            try
            {
                MainForm.DBContext.Themes.Add(new()
                {
                    UnitId = ((Unit)unitCombo.SelectedItem!).UnitId,
                    Name = themeText.Text,
                    Description = descriptionText.Text.Trim() != "" ? descriptionText.Text : null,
                    RecommendedDuration = Convert.ToInt32(durationNumeric.Value),
                    Type = themeType,
                    ThemeFileUrl = fileUrlText.Text.Trim() != "" ? fileUrlText.Text : null
                });
                MainForm.DBContext.SaveChanges();
                MessageBox.Show("New theme added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                parent.ReloadWikiTree();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnChoosePath(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileUrlText.Text = "file:///" + openFileDialog.FileName;
            }
        }

        private bool ValidateFields()
        {
            if (unitCombo.SelectedItem is null)
            {
                MessageBox.Show("Unknown unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (typeCombo.SelectedItem is null)
            {
                MessageBox.Show("Unknown type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (themeText.Text.Trim() == "")
            {
                MessageBox.Show("Theme name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this theme?", "Action required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (editable is not null)
            {
                MainForm.DBContext.Remove(editable);
                MainForm.DBContext.SaveChanges();
            }
            Close();
            parent.ReloadWikiTree();
        }
    }
}
