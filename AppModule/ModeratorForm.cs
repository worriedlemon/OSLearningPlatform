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
    public partial class ModeratorForm : Form
    {
        public bool Result = false;

        public ModeratorForm()
        {
            InitializeComponent();
            becomeModButton.DialogResult = DialogResult.OK;
        }

        private void OnBecomeModButton(object sender, EventArgs e)
        {
            Result = secretTextBox.Text.ToLower() == "a secret code phrase";
            Close();
        }
    }
}
