namespace AppModule
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formContainerPanel = new Panel();
            SuspendLayout();
            // 
            // formContainerPanel
            // 
            formContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formContainerPanel.Location = new Point(10, 10);
            formContainerPanel.Name = "formContainerPanel";
            formContainerPanel.Size = new Size(1242, 653);
            formContainerPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(formContainerPanel);
            MinimumSize = new Size(360, 240);
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "Learning Platform";
            FormClosing += OnFormClosing;
            SizeChanged += SizeChangedHandler;
            ResumeLayout(false);
        }

        #endregion

        private Panel formContainerPanel;
    }
}
