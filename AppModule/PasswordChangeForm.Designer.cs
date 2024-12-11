namespace AppModule
{
    partial class PasswordChangeForm
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
            repeatPasswordText = new TextBox();
            newPasswordText = new TextBox();
            oladPasswordLabel = new Label();
            newPasswordLabel = new Label();
            repeatPasswordLabel = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            oldPasswordText = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(repeatPasswordText, 1, 2);
            tableLayoutPanel1.Controls.Add(newPasswordText, 1, 1);
            tableLayoutPanel1.Controls.Add(oladPasswordLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(newPasswordLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(repeatPasswordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(cancelButton, 0, 3);
            tableLayoutPanel1.Controls.Add(saveButton, 1, 3);
            tableLayoutPanel1.Controls.Add(oldPasswordText, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(248, 209);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // repeatPasswordText
            // 
            repeatPasswordText.Dock = DockStyle.Top;
            repeatPasswordText.Location = new Point(127, 115);
            repeatPasswordText.Name = "repeatPasswordText";
            repeatPasswordText.Size = new Size(118, 27);
            repeatPasswordText.TabIndex = 5;
            // 
            // newPasswordText
            // 
            newPasswordText.Dock = DockStyle.Top;
            newPasswordText.Location = new Point(127, 59);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.Size = new Size(118, 27);
            newPasswordText.TabIndex = 4;
            // 
            // oladPasswordLabel
            // 
            oladPasswordLabel.AutoSize = true;
            oladPasswordLabel.Location = new Point(3, 0);
            oladPasswordLabel.Name = "oladPasswordLabel";
            oladPasswordLabel.Size = new Size(101, 20);
            oladPasswordLabel.TabIndex = 0;
            oladPasswordLabel.Text = "Old Password:";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(3, 56);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(107, 20);
            newPasswordLabel.TabIndex = 0;
            newPasswordLabel.Text = "New Password:";
            // 
            // repeatPasswordLabel
            // 
            repeatPasswordLabel.AutoSize = true;
            repeatPasswordLabel.Location = new Point(3, 112);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(94, 40);
            repeatPasswordLabel.TabIndex = 0;
            repeatPasswordLabel.Text = "Repeat New Password:";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(10, 171);
            cancelButton.Margin = new Padding(10, 3, 10, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(104, 35);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += OnCancelButton;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(134, 171);
            saveButton.Margin = new Padding(10, 3, 10, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(104, 35);
            saveButton.TabIndex = 2;
            saveButton.Text = "Change";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += OnSaveButtonClick;
            // 
            // oldPasswordText
            // 
            oldPasswordText.Dock = DockStyle.Top;
            oldPasswordText.Location = new Point(127, 3);
            oldPasswordText.Name = "oldPasswordText";
            oldPasswordText.Size = new Size(118, 27);
            oldPasswordText.TabIndex = 3;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 233);
            Controls.Add(tableLayoutPanel1);
            Name = "PasswordChangeForm";
            Text = "Change Password";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label newPasswordLabel;
        private Label repeatPasswordLabel;
        private Button cancelButton;
        private TextBox repeatPasswordText;
        private TextBox newPasswordText;
        private Label oladPasswordLabel;
        private Button saveButton;
        private TextBox oldPasswordText;
    }
}