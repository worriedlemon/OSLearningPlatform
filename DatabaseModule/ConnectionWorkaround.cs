namespace DatabaseModule;

public partial class OslearningPlatformContext
{
    private string user = "";
    private string password = "";

    private bool integratedSecurity = true;

    public OslearningPlatformContext(string user, string password)
    {
        this.user = user;
        this.password = password;
        integratedSecurity = false;
    }
}
