namespace AppModule
{
    partial class RepliesForm
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
            userLabel = new Label();
            questionLabel = new Label();
            replyText = new TextBox();
            replyButton = new Button();
            repliesList = new ListBox();
            repliesLabel = new Label();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(12, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 20);
            userLabel.TabIndex = 0;
            userLabel.Text = "@{user}";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionLabel.Location = new Point(12, 40);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(103, 25);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "{Question}";
            // 
            // replyText
            // 
            replyText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            replyText.Location = new Point(12, 367);
            replyText.Multiline = true;
            replyText.Name = "replyText";
            replyText.PlaceholderText = "Your reply...";
            replyText.Size = new Size(322, 71);
            replyText.TabIndex = 2;
            // 
            // replyButton
            // 
            replyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            replyButton.Location = new Point(340, 376);
            replyButton.Name = "replyButton";
            replyButton.Size = new Size(104, 53);
            replyButton.TabIndex = 3;
            replyButton.Text = "Reply";
            replyButton.UseVisualStyleBackColor = true;
            replyButton.Click += OnReplyClick;
            // 
            // repliesList
            // 
            repliesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            repliesList.FormattingEnabled = true;
            repliesList.HorizontalScrollbar = true;
            repliesList.Location = new Point(12, 97);
            repliesList.Name = "repliesList";
            repliesList.SelectionMode = SelectionMode.None;
            repliesList.Size = new Size(432, 264);
            repliesList.TabIndex = 4;
            // 
            // repliesLabel
            // 
            repliesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            repliesLabel.AutoSize = true;
            repliesLabel.Location = new Point(384, 74);
            repliesLabel.Name = "repliesLabel";
            repliesLabel.Size = new Size(60, 20);
            repliesLabel.TabIndex = 5;
            repliesLabel.Text = "Replies:";
            // 
            // RepliesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(repliesLabel);
            Controls.Add(repliesList);
            Controls.Add(replyButton);
            Controls.Add(replyText);
            Controls.Add(questionLabel);
            Controls.Add(userLabel);
            Name = "RepliesForm";
            Text = "Replies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private Label questionLabel;
        private TextBox replyText;
        private Button replyButton;
        private ListBox repliesList;
        private Label repliesLabel;
    }
}