using DatabaseModule;
using Microsoft.EntityFrameworkCore;

namespace AppModule
{
    public partial class EditUnit : Form
    {
        private AppForm parent;
        private int id;
        private Unit? editable;

        public bool AddRecord { get { return id == -1; } }

        public EditUnit(in AppForm parent, int id = -1)
        {
            InitializeComponent();

            this.id = id;
            this.parent = parent;

            if (AddRecord)
            {
                Name = "Add New Unit";
                editButton.Text = "Add New Unit";
                editButton.Click += OnAddButtonClick;
            }
            else
            {
                editButton.Click += OnEditButtonClick;
                editable = MainForm.DBContext.Units.Where(u => u.UnitId == id).First();
                unitNameText.Text = editable.Name.TrimEnd();
                unitDescriptionText.Text = (editable.Description ?? "").TrimEnd();

                MainForm.DBContext.Units.Update(editable);
            }
        }

        private void OnCloseButton(object sender, EventArgs e) => Close();

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (editable is null) return;

            try
            {
                MainForm.DBContext.Units.Update(editable!);
                editable.Name = unitNameText.Text;
                editable.Description = unitDescriptionText.Text.Trim() != "" ? unitDescriptionText.Text : null;
                MainForm.DBContext.SaveChanges();
                MessageBox.Show("Unit edited successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (DbUpdateException ex)
            {
                string details = "";
                if (ex.InnerException is not null)
                {
                    details += "\n\n" + ex.InnerException.Message;
                }
                MessageBox.Show($"Could not edit unit:\n{ex.Message}{details}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            try
            {
                MainForm.DBContext.Units.Add(new Unit()
                {
                    Name = unitNameText.Text,
                    Description = unitDescriptionText.Text.Trim() != "" ? unitDescriptionText.Text : null,
                });
                MainForm.DBContext.SaveChanges();
                MessageBox.Show("New unit added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                parent.ReloadWikiTree();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Could not add new unit:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
