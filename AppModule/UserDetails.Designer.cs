namespace AppModule
{
    partial class UserDetails
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
            userLogin = new Label();
            userName = new Label();
            userPassword = new Label();
            loginText = new TextBox();
            nameText = new TextBox();
            changePasswordButton = new Button();
            moderatorLabel = new Label();
            moderatorButton = new Button();
            saveButton = new Button();
            closeButton = new Button();
            logoutButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(userLogin, 0, 0);
            tableLayoutPanel1.Controls.Add(userName, 0, 1);
            tableLayoutPanel1.Controls.Add(userPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(loginText, 1, 0);
            tableLayoutPanel1.Controls.Add(nameText, 1, 1);
            tableLayoutPanel1.Controls.Add(changePasswordButton, 1, 2);
            tableLayoutPanel1.Controls.Add(moderatorLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(moderatorButton, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(298, 192);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // userLogin
            // 
            userLogin.AutoSize = true;
            userLogin.Location = new Point(3, 0);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(49, 20);
            userLogin.TabIndex = 0;
            userLogin.Text = "Login:";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(3, 48);
            userName.Name = "userName";
            userName.Size = new Size(52, 20);
            userName.TabIndex = 0;
            userName.Text = "Name:";
            // 
            // userPassword
            // 
            userPassword.AutoSize = true;
            userPassword.Location = new Point(3, 96);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(73, 20);
            userPassword.TabIndex = 0;
            userPassword.Text = "Password:";
            // 
            // loginText
            // 
            loginText.Dock = DockStyle.Fill;
            loginText.Location = new Point(152, 3);
            loginText.Name = "loginText";
            loginText.Size = new Size(143, 27);
            loginText.TabIndex = 1;
            loginText.TextAlign = HorizontalAlignment.Center;
            // 
            // nameText
            // 
            nameText.Dock = DockStyle.Fill;
            nameText.Location = new Point(152, 51);
            nameText.Name = "nameText";
            nameText.PlaceholderText = "Enter your name...";
            nameText.Size = new Size(143, 27);
            nameText.TabIndex = 2;
            nameText.TextAlign = HorizontalAlignment.Center;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Dock = DockStyle.Top;
            changePasswordButton.Location = new Point(152, 99);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(143, 33);
            changePasswordButton.TabIndex = 3;
            changePasswordButton.Text = "Change";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += OnPasswordChangeClick;
            // 
            // moderatorLabel
            // 
            moderatorLabel.AutoSize = true;
            moderatorLabel.Location = new Point(3, 144);
            moderatorLabel.Name = "moderatorLabel";
            moderatorLabel.Size = new Size(83, 20);
            moderatorLabel.TabIndex = 0;
            moderatorLabel.Text = "Moderator:";
            // 
            // moderatorButton
            // 
            moderatorButton.Dock = DockStyle.Top;
            moderatorButton.FlatAppearance.BorderSize = 0;
            moderatorButton.FlatStyle = FlatStyle.Flat;
            moderatorButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            moderatorButton.ForeColor = SystemColors.ControlDark;
            moderatorButton.Location = new Point(152, 147);
            moderatorButton.Name = "moderatorButton";
            moderatorButton.Size = new Size(143, 29);
            moderatorButton.TabIndex = 6;
            moderatorButton.Text = "Inactive";
            moderatorButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(174, 252);
            saveButton.Margin = new Padding(10, 3, 10, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 35);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += OnSaveClick;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Location = new Point(19, 252);
            closeButton.Margin = new Padding(10, 3, 10, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(129, 35);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OnCloseClick;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logoutButton.Location = new Point(19, 211);
            logoutButton.Margin = new Padding(10, 3, 10, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(284, 35);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += OnLogoutClick;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 299);
            Controls.Add(closeButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(logoutButton);
            Controls.Add(saveButton);
            Name = "UserDetails";
            Text = "User details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label userLogin;
        private Label userName;
        private Label userPassword;
        private TextBox loginText;
        private TextBox nameText;
        private Button changePasswordButton;
        private Button saveButton;
        private Label moderatorLabel;
        private Button moderatorButton;
        private Button closeButton;
        private Button logoutButton;
    }
}