namespace AppModule
{
    partial class ModeratorForm
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
            passLabel = new Label();
            secretTextBox = new TextBox();
            becomeModButton = new Button();
            SuspendLayout();
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(12, 9);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(186, 20);
            passLabel.TabIndex = 3;
            passLabel.Text = "Enter a secret code phrase:";
            passLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secretTextBox
            // 
            secretTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            secretTextBox.Location = new Point(12, 32);
            secretTextBox.Multiline = true;
            secretTextBox.Name = "secretTextBox";
            secretTextBox.PlaceholderText = "Enter something";
            secretTextBox.Size = new Size(208, 60);
            secretTextBox.TabIndex = 4;
            // 
            // becomeModButton
            // 
            becomeModButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            becomeModButton.Location = new Point(12, 111);
            becomeModButton.Name = "becomeModButton";
            becomeModButton.Size = new Size(208, 30);
            becomeModButton.TabIndex = 5;
            becomeModButton.Text = "Become a moderator";
            becomeModButton.UseVisualStyleBackColor = true;
            becomeModButton.Click += OnBecomeModButton;
            // 
            // ModeratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 153);
            Controls.Add(passLabel);
            Controls.Add(secretTextBox);
            Controls.Add(becomeModButton);
            MaximumSize = new Size(250, 200);
            MinimumSize = new Size(250, 200);
            Name = "ModeratorForm";
            Text = "Moderator Privileges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passLabel;
        private TextBox secretTextBox;
        private Button becomeModButton;
    }
}