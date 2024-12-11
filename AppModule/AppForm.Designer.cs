namespace AppModule
{
    partial class AppForm
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
            userProfileButton = new Button();
            splitContainer = new SplitContainer();
            newThemeButton = new Button();
            newUnitButton = new Button();
            informationLabel = new Label();
            wikiTreeView = new TreeView();
            userInformation = new Label();
            tabControl = new TabControl();
            contentsPage = new TabPage();
            contentsHeaderPanel = new Panel();
            contentName = new Label();
            editContentsButton = new Button();
            contentsFlowLayout = new FlowLayoutPanel();
            contentDescription = new Label();
            contentInformation = new Label();
            questions = new TabPage();
            questionsList = new ListBox();
            questionHeaderPanel = new Panel();
            questionButton = new Button();
            questionDecsrLabel = new Label();
            questionHeaderLabel = new Label();
            filePage = new TabPage();
            webViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tabControl.SuspendLayout();
            contentsPage.SuspendLayout();
            contentsHeaderPanel.SuspendLayout();
            contentsFlowLayout.SuspendLayout();
            questions.SuspendLayout();
            questionHeaderPanel.SuspendLayout();
            filePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewer).BeginInit();
            SuspendLayout();
            // 
            // userProfileButton
            // 
            userProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userProfileButton.BackgroundImageLayout = ImageLayout.Zoom;
            userProfileButton.FlatStyle = FlatStyle.Flat;
            userProfileButton.Location = new Point(371, 7);
            userProfileButton.Name = "userProfileButton";
            userProfileButton.Size = new Size(132, 35);
            userProfileButton.TabIndex = 0;
            userProfileButton.Text = "Username";
            userProfileButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            userProfileButton.UseVisualStyleBackColor = true;
            userProfileButton.Click += OnUsernameClick;
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(12, 12);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(newThemeButton);
            splitContainer.Panel1.Controls.Add(newUnitButton);
            splitContainer.Panel1.Controls.Add(informationLabel);
            splitContainer.Panel1.Controls.Add(wikiTreeView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(userInformation);
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Panel2.Controls.Add(userProfileButton);
            splitContainer.Size = new Size(750, 420);
            splitContainer.SplitterDistance = 236;
            splitContainer.TabIndex = 1;
            // 
            // newThemeButton
            // 
            newThemeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newThemeButton.Font = new Font("Segoe UI", 8F);
            newThemeButton.Location = new Point(143, 391);
            newThemeButton.Name = "newThemeButton";
            newThemeButton.Size = new Size(90, 26);
            newThemeButton.TabIndex = 2;
            newThemeButton.Text = "New Theme";
            newThemeButton.UseVisualStyleBackColor = true;
            newThemeButton.Click += OnNewThemeClick;
            // 
            // newUnitButton
            // 
            newUnitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newUnitButton.Font = new Font("Segoe UI", 8F);
            newUnitButton.Location = new Point(3, 391);
            newUnitButton.Name = "newUnitButton";
            newUnitButton.Size = new Size(90, 26);
            newUnitButton.TabIndex = 2;
            newUnitButton.Text = "New Unit";
            newUnitButton.UseVisualStyleBackColor = true;
            newUnitButton.Click += OnNewUnitClick;
            // 
            // informationLabel
            // 
            informationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            informationLabel.Location = new Point(3, 7);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(230, 78);
            informationLabel.TabIndex = 1;
            informationLabel.Text = "Info";
            informationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wikiTreeView
            // 
            wikiTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wikiTreeView.Location = new Point(0, 93);
            wikiTreeView.Name = "wikiTreeView";
            wikiTreeView.Size = new Size(233, 292);
            wikiTreeView.TabIndex = 0;
            // 
            // userInformation
            // 
            userInformation.AutoSize = true;
            userInformation.Font = new Font("Segoe UI", 9F);
            userInformation.Location = new Point(13, 14);
            userInformation.Name = "userInformation";
            userInformation.Size = new Size(157, 20);
            userInformation.TabIndex = 0;
            userInformation.Text = "Last online: {hh:mm:ss}";
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(contentsPage);
            tabControl.Controls.Add(questions);
            tabControl.Controls.Add(filePage);
            tabControl.Location = new Point(3, 44);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(504, 373);
            tabControl.TabIndex = 1;
            // 
            // contentsPage
            // 
            contentsPage.AutoScroll = true;
            contentsPage.Controls.Add(contentsHeaderPanel);
            contentsPage.Controls.Add(contentsFlowLayout);
            contentsPage.Location = new Point(4, 4);
            contentsPage.Name = "contentsPage";
            contentsPage.Padding = new Padding(3);
            contentsPage.Size = new Size(496, 340);
            contentsPage.TabIndex = 0;
            contentsPage.Text = "Contents";
            contentsPage.UseVisualStyleBackColor = true;
            // 
            // contentsHeaderPanel
            // 
            contentsHeaderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contentsHeaderPanel.Controls.Add(contentName);
            contentsHeaderPanel.Controls.Add(editContentsButton);
            contentsHeaderPanel.Location = new Point(3, 3);
            contentsHeaderPanel.Margin = new Padding(0);
            contentsHeaderPanel.Name = "contentsHeaderPanel";
            contentsHeaderPanel.Size = new Size(490, 52);
            contentsHeaderPanel.TabIndex = 2;
            // 
            // contentName
            // 
            contentName.AutoSize = true;
            contentName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            contentName.Location = new Point(3, 9);
            contentName.Name = "contentName";
            contentName.Size = new Size(234, 25);
            contentName.TabIndex = 0;
            contentName.Text = "Some theme for example";
            // 
            // editContentsButton
            // 
            editContentsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editContentsButton.Location = new Point(393, 3);
            editContentsButton.Name = "editContentsButton";
            editContentsButton.Size = new Size(94, 42);
            editContentsButton.TabIndex = 1;
            editContentsButton.Text = "Edit";
            editContentsButton.UseVisualStyleBackColor = true;
            editContentsButton.Click += OnEditClick;
            // 
            // contentsFlowLayout
            // 
            contentsFlowLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentsFlowLayout.AutoScroll = true;
            contentsFlowLayout.Controls.Add(contentDescription);
            contentsFlowLayout.Controls.Add(contentInformation);
            contentsFlowLayout.FlowDirection = FlowDirection.TopDown;
            contentsFlowLayout.Location = new Point(3, 57);
            contentsFlowLayout.Margin = new Padding(0);
            contentsFlowLayout.Name = "contentsFlowLayout";
            contentsFlowLayout.Padding = new Padding(5);
            contentsFlowLayout.Size = new Size(490, 280);
            contentsFlowLayout.TabIndex = 1;
            // 
            // contentDescription
            // 
            contentDescription.AutoSize = true;
            contentDescription.Font = new Font("Segoe UI", 9F);
            contentDescription.Location = new Point(8, 5);
            contentDescription.Name = "contentDescription";
            contentDescription.Size = new Size(177, 20);
            contentDescription.TabIndex = 0;
            contentDescription.Text = "Some theme for example";
            // 
            // contentInformation
            // 
            contentInformation.AutoSize = true;
            contentInformation.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            contentInformation.Location = new Point(8, 25);
            contentInformation.Name = "contentInformation";
            contentInformation.Size = new Size(233, 20);
            contentInformation.TabIndex = 0;
            contentInformation.Text = "Recommended duration: {duration}";
            // 
            // questions
            // 
            questions.Controls.Add(questionsList);
            questions.Controls.Add(questionHeaderPanel);
            questions.Location = new Point(4, 4);
            questions.Name = "questions";
            questions.Size = new Size(496, 340);
            questions.TabIndex = 2;
            questions.Text = "Questions";
            questions.UseVisualStyleBackColor = true;
            // 
            // questionsList
            // 
            questionsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            questionsList.Location = new Point(3, 84);
            questionsList.Name = "questionsList";
            questionsList.Size = new Size(487, 244);
            questionsList.TabIndex = 1;
            questionsList.DoubleClick += OnQuestionSelected;
            // 
            // questionHeaderPanel
            // 
            questionHeaderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            questionHeaderPanel.Controls.Add(questionButton);
            questionHeaderPanel.Controls.Add(questionDecsrLabel);
            questionHeaderPanel.Controls.Add(questionHeaderLabel);
            questionHeaderPanel.Location = new Point(3, 3);
            questionHeaderPanel.Name = "questionHeaderPanel";
            questionHeaderPanel.Size = new Size(490, 75);
            questionHeaderPanel.TabIndex = 0;
            // 
            // questionButton
            // 
            questionButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            questionButton.Location = new Point(361, 15);
            questionButton.Name = "questionButton";
            questionButton.Size = new Size(126, 43);
            questionButton.TabIndex = 2;
            questionButton.Text = "Ask a Question";
            questionButton.UseVisualStyleBackColor = true;
            questionButton.Click += OnAskQuestionClick;
            // 
            // questionDecsrLabel
            // 
            questionDecsrLabel.AutoSize = true;
            questionDecsrLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            questionDecsrLabel.Location = new Point(3, 42);
            questionDecsrLabel.Name = "questionDecsrLabel";
            questionDecsrLabel.Size = new Size(85, 25);
            questionDecsrLabel.TabIndex = 1;
            questionDecsrLabel.Text = "{Theme}";
            // 
            // questionHeaderLabel
            // 
            questionHeaderLabel.AutoSize = true;
            questionHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            questionHeaderLabel.Location = new Point(3, 0);
            questionHeaderLabel.Name = "questionHeaderLabel";
            questionHeaderLabel.Size = new Size(135, 25);
            questionHeaderLabel.TabIndex = 0;
            questionHeaderLabel.Text = "Questions List";
            // 
            // filePage
            // 
            filePage.Controls.Add(webViewer);
            filePage.Location = new Point(4, 4);
            filePage.Name = "filePage";
            filePage.Padding = new Padding(3);
            filePage.Size = new Size(496, 340);
            filePage.TabIndex = 1;
            filePage.Text = "File View";
            filePage.UseVisualStyleBackColor = true;
            // 
            // webViewer
            // 
            webViewer.CreationProperties = null;
            webViewer.DefaultBackgroundColor = Color.White;
            webViewer.Dock = DockStyle.Fill;
            webViewer.Location = new Point(3, 3);
            webViewer.Margin = new Padding(0);
            webViewer.Name = "webViewer";
            webViewer.Size = new Size(490, 334);
            webViewer.TabIndex = 0;
            webViewer.ZoomFactor = 1D;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 444);
            Controls.Add(splitContainer);
            Name = "AppForm";
            Text = "AppForm";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            contentsPage.ResumeLayout(false);
            contentsHeaderPanel.ResumeLayout(false);
            contentsHeaderPanel.PerformLayout();
            contentsFlowLayout.ResumeLayout(false);
            contentsFlowLayout.PerformLayout();
            questions.ResumeLayout(false);
            questionHeaderPanel.ResumeLayout(false);
            questionHeaderPanel.PerformLayout();
            filePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button userProfileButton;
        private SplitContainer splitContainer;
        private TreeView wikiTreeView;
        private TabControl tabControl;
        private TabPage contentsPage;
        private TabPage filePage;
        private Label contentName;
        private FlowLayoutPanel contentsFlowLayout;
        private Label contentDescription;
        private Label contentInformation;
        private Button editContentsButton;
        private Panel contentsHeaderPanel;
        private Label informationLabel;
        private Button newThemeButton;
        private Button newUnitButton;
        private Label userInformation;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewer;
        private TabPage questions;
        private Panel questionHeaderPanel;
        private Label questionHeaderLabel;
        private Button questionButton;
        private Label questionDecsrLabel;
        private ListBox questionsList;
    }
}