using DatabaseModule;
using Microsoft.EntityFrameworkCore;

namespace AppModule
{
    public partial class PasswordChangeForm : Form
    {
        User user;

        public PasswordChangeForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (user.EncryptedPassword.Trim() != AESOperation.Encrypt(oldPasswordText.Text))
            {
                MessageBox.Show("Wrong old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (oldPasswordText.Text == newPasswordText.Text)
            {
                MessageBox.Show("Passwords are equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPasswordText.Text != repeatPasswordText.Text)
            {
                MessageBox.Show("Wrong old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MainForm.DBContext.Update(user);
                user.EncryptedPassword = AESOperation.Encrypt(newPasswordText.Text);
                MainForm.DBContext.SaveChanges();
                MessageBox.Show("Password changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Could not change password:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCancelButton(object sender, EventArgs e) => Close();
    }
}
