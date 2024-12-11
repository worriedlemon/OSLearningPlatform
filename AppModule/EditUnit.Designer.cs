namespace AppModule
{
    partial class EditUnit
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
            tableLayout = new TableLayoutPanel();
            unitNameLabel = new Label();
            label1 = new Label();
            unitNameText = new TextBox();
            unitDescriptionText = new TextBox();
            editButton = new Button();
            closeButton = new Button();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(unitNameLabel, 0, 0);
            tableLayout.Controls.Add(label1, 0, 1);
            tableLayout.Controls.Add(unitNameText, 1, 0);
            tableLayout.Controls.Add(unitDescriptionText, 1, 1);
            tableLayout.Location = new Point(12, 12);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout.Size = new Size(429, 222);
            tableLayout.TabIndex = 0;
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new Point(3, 0);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new Size(83, 20);
            unitNameLabel.TabIndex = 0;
            unitNameLabel.Text = "Unit Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Unit Description:";
            // 
            // unitNameText
            // 
            unitNameText.Dock = DockStyle.Top;
            unitNameText.Location = new Point(128, 3);
            unitNameText.MaxLength = 64;
            unitNameText.Name = "unitNameText";
            unitNameText.PlaceholderText = "Enter unit name";
            unitNameText.Size = new Size(298, 27);
            unitNameText.TabIndex = 1;
            // 
            // unitDescriptionText
            // 
            unitDescriptionText.Dock = DockStyle.Fill;
            unitDescriptionText.Location = new Point(128, 36);
            unitDescriptionText.Multiline = true;
            unitDescriptionText.Name = "unitDescriptionText";
            unitDescriptionText.Size = new Size(298, 183);
            unitDescriptionText.TabIndex = 2;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(266, 240);
            editButton.Name = "editButton";
            editButton.Size = new Size(172, 45);
            editButton.TabIndex = 1;
            editButton.Text = "Edit Unit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Location = new Point(12, 240);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(119, 45);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OnCloseButton;
            // 
            // EditUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 297);
            Controls.Add(closeButton);
            Controls.Add(editButton);
            Controls.Add(tableLayout);
            Name = "EditUnit";
            Text = "Edit Unit";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Label unitNameLabel;
        private Label label1;
        private TextBox unitNameText;
        private TextBox unitDescriptionText;
        private Button editButton;
        private Button closeButton;
    }
}