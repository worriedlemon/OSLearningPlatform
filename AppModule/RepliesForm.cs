using DatabaseModule;
using Microsoft.EntityFrameworkCore;
namespace AppModule
{
    public partial class RepliesForm : Form
    {
        Question question;
        User user;

        public RepliesForm(int questionId, User user)
        {
            this.user = user;
            question = MainForm.DBContext.Questions.Where(q => q.QuestionId == questionId).First();
            InitializeComponent();

            userLabel.Text = "@" + MainForm.DBContext.Users.Where(u => u.UserId == question.UserId).First().Login.TrimEnd();
            questionLabel.Text = question.Text.TrimEnd();

            ShowReplies();
        }

        private void ShowReplies()
        {
            repliesList.Items.Clear();
            var replies = MainForm.DBContext.Replies.Where(r => r.QuestionId == question.QuestionId)
                .Join(MainForm.DBContext.Users, r => r.UserId, u => u.UserId, (r, u) => new
                {
                    UserName = u.Login,
                    ReplyText = r.Text
                });

            foreach (var item in replies)
            {
                repliesList.Items.Add($"@{item.UserName.TrimEnd()}: {item.ReplyText.TrimEnd()}");
            }
        }

        private void OnReplyClick(object sender, EventArgs e)
        {
            string txt = replyText.Text.Trim();
            if (txt.Length == 0)
            {
                MessageBox.Show("Your reply is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Reply r = new()
                {
                    QuestionId = question.QuestionId,
                    Text = txt,
                    UserId = user.UserId
                };
                MainForm.DBContext.Add(r);
                MainForm.DBContext.SaveChanges();
                replyText.Text = "";
                repliesList.Items.Add($"@{user.Login.TrimEnd()}: {txt}");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Unable to reply: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
