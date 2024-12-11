namespace AppModule
{
    partial class EditTheme
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
            unitLabel = new Label();
            themeLabel = new Label();
            durationLabel = new Label();
            typeLabel = new Label();
            themeText = new TextBox();
            unitCombo = new ComboBox();
            typeCombo = new ComboBox();
            durationNumeric = new NumericUpDown();
            descriptionLabel = new Label();
            descriptionText = new TextBox();
            fileUrlLabel = new Label();
            panel1 = new Panel();
            fileUrlText = new TextBox();
            chooseFileButton = new Button();
            closeButton = new Button();
            editButton = new Button();
            openFileDialog = new OpenFileDialog();
            deleteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(unitLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(themeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(durationLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(typeLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(themeText, 1, 1);
            tableLayoutPanel1.Controls.Add(unitCombo, 1, 0);
            tableLayoutPanel1.Controls.Add(typeCombo, 1, 2);
            tableLayoutPanel1.Controls.Add(durationNumeric, 1, 3);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(descriptionText, 1, 4);
            tableLayoutPanel1.Controls.Add(fileUrlLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(panel1, 1, 5);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(454, 314);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new Point(3, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(39, 20);
            unitLabel.TabIndex = 0;
            unitLabel.Text = "Unit:";
            // 
            // themeLabel
            // 
            themeLabel.AutoSize = true;
            themeLabel.Location = new Point(3, 34);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new Size(101, 20);
            themeLabel.TabIndex = 0;
            themeLabel.Text = "Theme Name:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(3, 101);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(110, 40);
            durationLabel.TabIndex = 0;
            durationLabel.Text = "Recommended\r\nDuration:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(3, 67);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(92, 20);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Theme Type:";
            // 
            // themeText
            // 
            themeText.Dock = DockStyle.Top;
            themeText.Location = new Point(119, 37);
            themeText.Name = "themeText";
            themeText.PlaceholderText = "Enter theme name";
            themeText.Size = new Size(332, 27);
            themeText.TabIndex = 1;
            // 
            // unitCombo
            // 
            unitCombo.Dock = DockStyle.Top;
            unitCombo.FormattingEnabled = true;
            unitCombo.Location = new Point(119, 3);
            unitCombo.Name = "unitCombo";
            unitCombo.Size = new Size(332, 28);
            unitCombo.TabIndex = 2;
            // 
            // typeCombo
            // 
            typeCombo.Dock = DockStyle.Top;
            typeCombo.FormattingEnabled = true;
            typeCombo.Location = new Point(119, 70);
            typeCombo.Name = "typeCombo";
            typeCombo.Size = new Size(332, 28);
            typeCombo.TabIndex = 3;
            // 
            // durationNumeric
            // 
            durationNumeric.Dock = DockStyle.Top;
            durationNumeric.Location = new Point(119, 104);
            durationNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            durationNumeric.Name = "durationNumeric";
            durationNumeric.Size = new Size(332, 27);
            durationNumeric.TabIndex = 4;
            durationNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(3, 141);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionText
            // 
            descriptionText.Dock = DockStyle.Fill;
            descriptionText.Location = new Point(119, 144);
            descriptionText.MaxLength = 1024;
            descriptionText.Multiline = true;
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(332, 132);
            descriptionText.TabIndex = 5;
            // 
            // fileUrlLabel
            // 
            fileUrlLabel.AutoSize = true;
            fileUrlLabel.Location = new Point(3, 279);
            fileUrlLabel.Name = "fileUrlLabel";
            fileUrlLabel.Size = new Size(65, 20);
            fileUrlLabel.TabIndex = 6;
            fileUrlLabel.Text = "File URL:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(fileUrlText);
            panel1.Controls.Add(chooseFileButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(116, 279);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 35);
            panel1.TabIndex = 7;
            // 
            // fileUrlText
            // 
            fileUrlText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileUrlText.Location = new Point(3, 5);
            fileUrlText.Name = "fileUrlText";
            fileUrlText.Size = new Size(289, 27);
            fileUrlText.TabIndex = 1;
            // 
            // chooseFileButton
            // 
            chooseFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseFileButton.Location = new Point(298, 3);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(37, 29);
            chooseFileButton.TabIndex = 0;
            chooseFileButton.Text = "...";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += OnChoosePath;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Location = new Point(15, 332);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(110, 38);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OnCloseButton;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(286, 332);
            editButton.Name = "editButton";
            editButton.Size = new Size(177, 38);
            editButton.TabIndex = 1;
            editButton.Text = "Edit Theme";
            editButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "HTML|*.html|PDF|*.pdf";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(131, 332);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(149, 38);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Theme";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += OnDeleteClick;
            // 
            // EditTheme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 382);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(closeButton);
            Controls.Add(tableLayoutPanel1);
            Name = "EditTheme";
            Text = "Edit Theme";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label unitLabel;
        private Label themeLabel;
        private Label durationLabel;
        private Label typeLabel;
        private TextBox themeText;
        private ComboBox unitCombo;
        private ComboBox typeCombo;
        private NumericUpDown durationNumeric;
        private Label descriptionLabel;
        private TextBox descriptionText;
        private Button closeButton;
        private Button editButton;
        private Label fileUrlLabel;
        private Panel panel1;
        private Button chooseFileButton;
        private OpenFileDialog openFileDialog;
        private TextBox fileUrlText;
        private Button deleteButton;
    }
}