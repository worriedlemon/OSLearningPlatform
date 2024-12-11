namespace AppModule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Runtime exception: {ex}.\n\nApplication will be stopped.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}