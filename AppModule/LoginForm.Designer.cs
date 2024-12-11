namespace AppModule
{
    partial class LoginForm
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
            layoutPanel = new TableLayoutPanel();
            passwordText = new TextBox();
            passwordLabel = new Label();
            userLoginLabel = new Label();
            userLoginText = new TextBox();
            loginButton = new Button();
            registerButton = new Button();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            layoutPanel.ColumnCount = 2;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.6F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.4F));
            layoutPanel.Controls.Add(passwordText, 1, 1);
            layoutPanel.Controls.Add(passwordLabel, 0, 1);
            layoutPanel.Controls.Add(userLoginLabel, 0, 0);
            layoutPanel.Controls.Add(userLoginText, 1, 0);
            layoutPanel.Controls.Add(loginButton, 1, 2);
            layoutPanel.Location = new Point(12, 12);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 3;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            layoutPanel.Size = new Size(250, 125);
            layoutPanel.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Dock = DockStyle.Fill;
            passwordText.Location = new Point(87, 40);
            passwordText.MaxLength = 16;
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.PlaceholderText = "********";
            passwordText.Size = new Size(160, 27);
            passwordText.TabIndex = 2;
            passwordText.TextAlign = HorizontalAlignment.Center;
            passwordText.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 37);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password:";
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Location = new Point(3, 0);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new Size(49, 20);
            userLoginLabel.TabIndex = 0;
            userLoginLabel.Text = "Login:";
            // 
            // userLoginText
            // 
            userLoginText.Dock = DockStyle.Fill;
            userLoginText.Location = new Point(87, 3);
            userLoginText.MaxLength = 32;
            userLoginText.Name = "userLoginText";
            userLoginText.PlaceholderText = "example";
            userLoginText.Size = new Size(160, 27);
            userLoginText.TabIndex = 1;
            userLoginText.TextAlign = HorizontalAlignment.Center;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Fill;
            loginButton.Location = new Point(94, 84);
            loginButton.Margin = new Padding(10);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(146, 31);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += OnLoginButtonClick;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            registerButton.Location = new Point(77, 147);
            registerButton.Margin = new Padding(10);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(111, 34);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += OnRegisterClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 195);
            Controls.Add(registerButton);
            Controls.Add(layoutPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutPanel;
        private Label userLoginLabel;
        private Label passwordLabel;
        private TextBox userLoginText;
        private TextBox passwordText;
        private Button loginButton;
        private Button registerButton;
    }
}