namespace AppModule
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            repeatLine = new TextBox();
            passwordLine = new TextBox();
            nameLine = new TextBox();
            loginLabel = new Label();
            nameLabel = new Label();
            passwordLabel = new Label();
            repeatLabel = new Label();
            registerButton = new Button();
            loginLine = new TextBox();
            backButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2210789F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.77892F));
            tableLayoutPanel1.Controls.Add(repeatLine, 1, 3);
            tableLayoutPanel1.Controls.Add(passwordLine, 1, 2);
            tableLayoutPanel1.Controls.Add(nameLine, 1, 1);
            tableLayoutPanel1.Controls.Add(loginLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(repeatLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(registerButton, 1, 4);
            tableLayoutPanel1.Controls.Add(loginLine, 1, 0);
            tableLayoutPanel1.Controls.Add(backButton, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(337, 257);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // repeatLine
            // 
            repeatLine.Dock = DockStyle.Fill;
            repeatLine.Location = new Point(91, 156);
            repeatLine.MaxLength = 32;
            repeatLine.Name = "repeatLine";
            repeatLine.Size = new Size(243, 27);
            repeatLine.TabIndex = 5;
            repeatLine.UseSystemPasswordChar = true;
            // 
            // passwordLine
            // 
            passwordLine.Dock = DockStyle.Fill;
            passwordLine.Location = new Point(91, 105);
            passwordLine.MaxLength = 32;
            passwordLine.Name = "passwordLine";
            passwordLine.Size = new Size(243, 27);
            passwordLine.TabIndex = 4;
            passwordLine.UseSystemPasswordChar = true;
            // 
            // nameLine
            // 
            nameLine.Dock = DockStyle.Fill;
            nameLine.Location = new Point(91, 54);
            nameLine.MaxLength = 128;
            nameLine.Name = "nameLine";
            nameLine.Size = new Size(243, 27);
            nameLine.TabIndex = 3;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(3, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(49, 20);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 102);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password:";
            // 
            // repeatLabel
            // 
            repeatLabel.AutoSize = true;
            repeatLabel.Location = new Point(3, 153);
            repeatLabel.Name = "repeatLabel";
            repeatLabel.Size = new Size(75, 40);
            repeatLabel.TabIndex = 0;
            repeatLabel.Text = "Repeat password:";
            // 
            // registerButton
            // 
            registerButton.Dock = DockStyle.Fill;
            registerButton.Location = new Point(93, 209);
            registerButton.Margin = new Padding(5);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(239, 43);
            registerButton.TabIndex = 1;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += OnRegisterClick;
            // 
            // loginLine
            // 
            loginLine.Dock = DockStyle.Fill;
            loginLine.Location = new Point(91, 3);
            loginLine.MaxLength = 32;
            loginLine.Name = "loginLine";
            loginLine.Size = new Size(243, 27);
            loginLine.TabIndex = 2;
            // 
            // backButton
            // 
            backButton.Dock = DockStyle.Fill;
            backButton.Location = new Point(5, 214);
            backButton.Margin = new Padding(5, 10, 5, 10);
            backButton.Name = "backButton";
            backButton.Size = new Size(78, 33);
            backButton.TabIndex = 6;
            backButton.Text = "<- Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += OnBackButton;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 278);
            Controls.Add(tableLayoutPanel1);
            Name = "RegisterForm";
            Text = "Register";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label loginLabel;
        private Label nameLabel;
        private Label passwordLabel;
        private Label repeatLabel;
        private Button registerButton;
        private TextBox repeatLine;
        private TextBox passwordLine;
        private TextBox nameLine;
        private TextBox loginLine;
        private Button backButton;
    }
}