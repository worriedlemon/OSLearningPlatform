using DatabaseModule;

namespace AppModule
{
    public partial class LoginForm : Form
    {
        MainForm parent;

        public LoginForm(in MainForm parent)
        {
            InitializeComponent();

            this.parent = parent;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            loginButton.NotifyDefault(true);
        }

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            bool filter(User a)
            {
                bool loginCorrect = a.Login.Trim() == userLoginText.Text;
                bool passwordCorrect = AESOperation.Decrypt(a.EncryptedPassword.Trim()) == passwordText.Text;
                return loginCorrect && passwordCorrect;
            }

            List<User> user = MainForm.DBContext.Users.Where(filter).ToList();

            if (user.Count != 0)
            {
                userLoginText.Text = "";
                passwordText.Text = "";
                parent.AuthenticateAs(user[0]);
            }
            else
            {
                MessageBox.Show("Unknown login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            parent.SetCurrentForm("registerForm");
        }
    }
}
