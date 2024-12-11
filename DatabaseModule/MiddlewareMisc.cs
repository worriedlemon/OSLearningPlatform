using Microsoft.EntityFrameworkCore;
using static DatabaseModule.OslearningPlatformContext;

namespace DatabaseModule
{
    partial class OslearningPlatformContext
    {
        public Dictionary<string, string> ThemeTypes = new()
        {
            { "Lection", "LECTION" },
            { "Practice", "PRACTICE" },
            { "Laboratory work" , "LAB_WORK" },
            { "Study guide/Manual" , "MANUAL" }
        };

        /// <summary>
        /// Выполняет <i>процедуру</i> RegisterUser
        /// </summary>
        /// <param name="login"></param>
        /// <param name="encrPassword"></param>
        /// <param name="name"></param>
        public void RegisterUser(string login, string encrPassword, string name)
        {
            FormattableString str;
            if (name.Length != 0)
                str = $"EXEC [Service].RegisterUser @login={login}, @password={encrPassword}, @name={name}";
            else
                str = $"EXEC [Service].RegisterUser @login={login}, @password={encrPassword}";

            Database.ExecuteSql(str);
        }

        /// <summary>
        /// Выполняет <i>процедуру</i> UpdatePerformance
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="datetime"></param>
        /// <param name="lastTheme"></param>
        public void UpdateAttendanceAndPerformance(int userId, int? lastTheme)
        {
            FormattableString str;
            if (lastTheme is null)
                str = $"EXEC [Service].UpdatePerformance @id={userId}";
            else
                str = $"EXEC [Service].UpdatePerformance @id={userId}, @lastTheme={lastTheme!}";
            
            Database.ExecuteSql(str);
        }

        /// <summary>
        /// Выполняет <i>процедуру</i> SetAsModerator
        /// </summary>
        /// <param name="userId"></param>
        public void SetAsModerator(int userId)
        {
            Database.ExecuteSql($"EXEC [Service].SetAsModerator @id={userId}");
        }

        /// <summary>
        /// Выполняет <i>функцию</i> IsModerator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsModerator(int id)
        {
            var sqlResult = Database.SqlQuery<bool>($"SELECT [Service].IsModerator({id}) AS Value");
            return sqlResult.First();
        }

        public class MostRepliedQuestion
        {
            public int QuestionId { get; set; }

            public int ThemeId { get; set; }

            public int UserId { get; set; }

            public int RepliesCount { get; set; }

            public string QuestionText { get; set; } = null!;

            public override string ToString()
            {
                return $"{RepliesCount} replies: {QuestionText}";
            }
        }

        public IQueryable<MostRepliedQuestion> MostRepliedQuestions(int top = 5)
        {
            return Database.SqlQuery<MostRepliedQuestion>($"SELECT * FROM [Wiki].MostRepliedQuestions({top})");
        }

        public class UserQuestion
        {
            public int QuestionId { get; set; }

            public int ThemeId { get; set; }

            public string Text { get; set; } = null!;
        }

        public IQueryable<UserQuestion> UserQuestions(int userId)
        {
            return Database.SqlQuery<UserQuestion>($"SELECT * FROM [Wiki].UserQuestions({userId})");
        }
    }
}
