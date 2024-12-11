using DatabaseModule;

namespace AppModule
{
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly AppForm appForm;
        private readonly RegisterForm registerForm;

        public static OslearningPlatformContext DBContext = new();

        private Form? currentForm = null;

        private void CenterControls(in Form? form)
        {
            if (form is null) return;
            if (form.Dock == DockStyle.Fill) return;

            form.Left = (formContainerPanel.Size.Width - form.Size.Width) / 2;
            form.Top = (formContainerPanel.Size.Height - form.Size.Height) / 2;
        }

        public void SetCurrentForm(string name)
        {
            formContainerPanel.Controls.Remove(currentForm);
            currentForm = name switch
            {
                "loginForm" => loginForm,
                "registerForm" => registerForm,
                "appForm" => appForm,
                _ => throw new InvalidOperationException("No such form")
            };
            formContainerPanel.Controls.Add(currentForm);
            CenterControls(currentForm);
            currentForm.Show();
        }

        public void AuthenticateAs(User user)
        {
            SetCurrentForm("appForm");
            appForm.AfterAuthentication(user);
        }

        public MainForm()
        {
            InitializeComponent();

            DBContext = new();

            loginForm = new LoginForm(this);
            appForm = new AppForm(this);
            registerForm = new RegisterForm(this);

            SetCurrentForm("loginForm");
        }

        private void SizeChangedHandler(object sender, EventArgs e) => CenterControls(currentForm);

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (appForm.Authenticated)
            {
                appForm.SaveAttendanceAndPerformance();
            };
        }
    }
}
