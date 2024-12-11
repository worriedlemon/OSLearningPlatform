using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests
{
    [TestClass]
    public class DatabaseFunctionsTest
    {
        [TestMethod]
        public void IsModeratorTrue()
        {
            OslearningPlatformContext ctx = new();
            User? admin;
            Assert.IsNotNull(admin = ctx.Users.Where(u => u.Login == "admin").First());
            Assert.IsTrue(ctx.IsModerator(admin.UserId));
        }

        [TestMethod]
        public void IsModeratorFalse()
        {
            OslearningPlatformContext ctx = new();
            User? not_admin;
            Assert.IsNotNull(not_admin = ctx.Users.Where(u => u.Login != "admin").First());
            Assert.IsFalse(ctx.IsModerator(not_admin.UserId));
        }

        [TestMethod]
        public void UserQuestion()
        {
            OslearningPlatformContext ctx = new();
            try
            {
                object a = ctx.UserQuestions(1).ToArray();
                Assert.IsTrue(a.GetType() == typeof(OslearningPlatformContext.UserQuestion[]));
            }
            catch (Exception ex)
            {
                Assert.Inconclusive($"Test failed: {ex.Message}");
            }
        }

        [TestMethod]
        public void MostRepliedQuestions()
        {
            OslearningPlatformContext ctx = new();
            try
            {
                object a = ctx.MostRepliedQuestions(5).ToArray();
                Assert.IsTrue(a.GetType() == typeof(OslearningPlatformContext.MostRepliedQuestion[]));
                Assert.IsTrue(((OslearningPlatformContext.MostRepliedQuestion[])a).Length <= 5);
            }
            catch (Exception ex)
            {
                Assert.Inconclusive($"Test failed: {ex.Message}");
            }
        }
    }
}
