using DatabaseModule;
using Microsoft.Data.SqlClient;

namespace AppTests
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void WindowsConnection()
        {
            OslearningPlatformContext dbContext = new();

            var theme = dbContext.Themes.Where(t => t.ThemeId == 1).First();
            Assert.AreEqual(theme.ThemeId, 1);
        }

        [TestMethod]
        public void SqlConnectionUser()
        {
            OslearningPlatformContext dbContext = new("DbUser", "qwerty");

            var theme = dbContext.Themes.Where(t => t.ThemeId == 1).First();
            Assert.AreEqual(theme.ThemeId, 1);
        }

        [TestMethod]
        public void SqlConnectionModerator()
        {
            OslearningPlatformContext dbContext = new("DbModerator", "1qaz2wsx");

            var theme = dbContext.Themes.Where(t => t.ThemeId == 1).First();
            Assert.AreEqual(theme.ThemeId, 1);
        }

        [TestMethod]
        public void SqlConnectionFail()
        {
            OslearningPlatformContext dbContext = new("DbUser", "wrongpass");

            SqlException exc = Assert.ThrowsException<SqlException>(() =>
            {
                var theme = dbContext.Themes.Where(t => t.ThemeId == 1).First();
            });

            Assert.AreEqual(exc.Message, "При входе в систему пользователя \"DbUser\" произошла ошибка.");
        }
    }
}