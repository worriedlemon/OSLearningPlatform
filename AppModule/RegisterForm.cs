using System.Text.RegularExpressions;
using DatabaseModule;

namespace AppModule
{
    public partial class RegisterForm : Form
    {
        private MainForm parent;

        enum ValidationError
        {
            NO_ERROR = 0,
            LENGTH_INCORRECT,
            WRONG_CHARACTER,
            PASSWORD_NOT_MATCH
        }

        private ValidationError ValidateUsername()
        {
            if (loginLine.Text.Length < 4 || loginLine.Text.Length > loginLine.MaxLength)
            {
                return ValidationError.LENGTH_INCORRECT;
            }

            if (!Regex.IsMatch(loginLine.Text, @"[_\-0-9a-zA-Z]+"))
            {
                return ValidationError.WRONG_CHARACTER;
            }

            return ValidationError.NO_ERROR;
        }

        private ValidationError ValidatePassword()
        {
            if (passwordLine.Text.Length < 6 || passwordLine.Text.Length > 20)
            {
                return ValidationError.LENGTH_INCORRECT;
            }

            if (!Regex.IsMatch(passwordLine.Text, @"[_\-0-9a-zA-Z]+"))
            {
                return ValidationError.WRONG_CHARACTER;
            }

            if (passwordLine.Text != repeatLine.Text)
            {
                return ValidationError.PASSWORD_NOT_MATCH;
            }

            return ValidationError.NO_ERROR;
        }

        private string? ValidationErrorToString(ValidationError error)
        {
            switch (error)
            {
                case ValidationError.LENGTH_INCORRECT:
                    return "Incorrect Length";
                case ValidationError.WRONG_CHARACTER:
                    return "Field must consist only of digits, letters and underscores";
                case ValidationError.PASSWORD_NOT_MATCH:
                    return "Passwords are different";
                default:
                    return null;
            }
        }

        public RegisterForm(in MainForm parent)
        {
            InitializeComponent();

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;

            this.parent = parent;
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            string? err = ValidationErrorToString(ValidateUsername());

            if (err != null)
            {
                MessageBox.Show($"Username error: {err!}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            err = ValidationErrorToString(ValidatePassword());
            if (err != null)
            {
                MessageBox.Show($"Password error: {err!}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MainForm.DBContext.RegisterUser(loginLine.Text.Trim(), AESOperation.Encrypt(passwordLine.Text.Trim()), nameLine.Text.Trim());
                MainForm.DBContext.SaveChanges();

                MessageBox.Show($"New user '{loginLine.Text}' was successfully registered!", "Registration complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.SetCurrentForm("loginForm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error {nameof(ex)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnBackButton(object sender, EventArgs e)
        {
            loginLine.Text = "";
            nameLine.Text = "";
            passwordLine.Text = "";
            repeatLine.Text = "";

            parent.SetCurrentForm("loginForm");
        }
    }
}
