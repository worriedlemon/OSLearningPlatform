namespace AppModule
{
    partial class NewQuestion
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
            questionLabel = new Label();
            questionText = new TextBox();
            closeButton = new Button();
            askButton = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(12, 9);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(110, 20);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Ask a Question:";
            // 
            // questionText
            // 
            questionText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            questionText.Location = new Point(12, 44);
            questionText.MaxLength = 1024;
            questionText.Multiline = true;
            questionText.Name = "questionText";
            questionText.PlaceholderText = "Enter your question";
            questionText.Size = new Size(381, 157);
            questionText.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Location = new Point(12, 207);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(110, 43);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OnCloseClick;
            // 
            // askButton
            // 
            askButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            askButton.Location = new Point(223, 207);
            askButton.Name = "askButton";
            askButton.Size = new Size(170, 43);
            askButton.TabIndex = 3;
            askButton.Text = "Ask";
            askButton.UseVisualStyleBackColor = true;
            askButton.Click += OnAskClick;
            // 
            // NewQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 262);
            Controls.Add(askButton);
            Controls.Add(closeButton);
            Controls.Add(questionText);
            Controls.Add(questionLabel);
            Name = "NewQuestion";
            Text = "New Question";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private TextBox questionText;
        private Button closeButton;
        private Button askButton;
    }
}