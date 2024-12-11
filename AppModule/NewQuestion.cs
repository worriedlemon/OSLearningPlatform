using DatabaseModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModule
{
    public partial class NewQuestion : Form
    {
        private int themeId;
        private int userId;

        public NewQuestion(int themeId, int userId)
        {
            this.themeId = themeId;
            this.userId = userId;
            InitializeComponent();
        }

        private void OnCloseClick(object sender, EventArgs e) => Close();

        private void OnAskClick(object sender, EventArgs e)
        {
            string txt = questionText.Text.Trim();
            if (txt.Length == 0)
            {
                MessageBox.Show("Your question is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MainForm.DBContext.Questions.Add(new Question()
                {
                    Text = txt,
                    ThemeId = themeId,
                    UserId = userId
                });
                MainForm.DBContext.SaveChanges();
                MessageBox.Show("Your question uploaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Unable to upload new question:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
