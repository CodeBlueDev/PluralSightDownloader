namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System.Windows.Forms;

    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._addPluralSightCourseByUrlMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._findPluralSightCourseMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMainMenuToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._exitMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolsMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._preferencesMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutPluralSightDownloaderMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._licenseInformationMainMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._addPluralSightCourseByUrlMainToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._findPluralSightCourseMainToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._pluralSightDownloaderTabControl = new System.Windows.Forms.TabControl();
            this._downloadTabPage = new System.Windows.Forms.TabPage();
            this._downloadToolStrip = new System.Windows.Forms.ToolStrip();
            this._addPluralSightCourseByUrlDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._findPluralSightCourseDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._removePluralSightCourseDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._editPluralSightCourseDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._coursePriorityDownloadToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._maximumPriorityDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._increasePriorityDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._decreasePriorityDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._minimumPriorityDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._addedCoursesDownloadDataGridView = new System.Windows.Forms.DataGridView();
            this._addedCoursesDownloadDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._coursePriorityDownloadDataGridViewContextMenuStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._libraryTabPage = new System.Windows.Forms.TabPage();
            this._libraryToolStrip = new System.Windows.Forms.ToolStrip();
            this._libraryFilterListBox = new System.Windows.Forms.ListBox();
            this._libraryDataGridView = new System.Windows.Forms.DataGridView();
            this._downloadSearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._librarySearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._pluralSightDownloaderErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._mainMenuStrip.SuspendLayout();
            this._mainToolStrip.SuspendLayout();
            this._pluralSightDownloaderTabControl.SuspendLayout();
            this._downloadTabPage.SuspendLayout();
            this._downloadToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._addedCoursesDownloadDataGridView)).BeginInit();
            this._addedCoursesDownloadDataGridViewContextMenuStrip.SuspendLayout();
            this._libraryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._libraryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pluralSightDownloaderErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMainMenuStripMenuItem,
            this._toolsMainMenuStripMenuItem,
            this._helpMainMenuStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(584, 24);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "Main MenuStrip";
            // 
            // _fileMainMenuStripMenuItem
            // 
            this._fileMainMenuStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addPluralSightCourseByUrlMainMenuStripMenuItem,
            this._findPluralSightCourseMainMenuStripMenuItem,
            this._exitMainMenuToolStripSeparator,
            this._exitMainMenuStripMenuItem});
            this._fileMainMenuStripMenuItem.Name = "_fileMainMenuStripMenuItem";
            this._fileMainMenuStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileMainMenuStripMenuItem.Text = "&File";
            // 
            // _addPluralSightCourseByUrlMainMenuStripMenuItem
            // 
            this._addPluralSightCourseByUrlMainMenuStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseByUrlMainMenuStripMenuItem.Image")));
            this._addPluralSightCourseByUrlMainMenuStripMenuItem.Name = "_addPluralSightCourseByUrlMainMenuStripMenuItem";
            this._addPluralSightCourseByUrlMainMenuStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this._addPluralSightCourseByUrlMainMenuStripMenuItem.Text = "&Add PluralSight Course by Url";
            this._addPluralSightCourseByUrlMainMenuStripMenuItem.Click += new System.EventHandler(this.AddPluralSightCourseByUrlOnClick);
            // 
            // _findPluralSightCourseMainMenuStripMenuItem
            // 
            this._findPluralSightCourseMainMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_find;
            this._findPluralSightCourseMainMenuStripMenuItem.Name = "_findPluralSightCourseMainMenuStripMenuItem";
            this._findPluralSightCourseMainMenuStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this._findPluralSightCourseMainMenuStripMenuItem.Text = "&Find PluralSight Course(s)";
            // 
            // _exitMainMenuToolStripSeparator
            // 
            this._exitMainMenuToolStripSeparator.Name = "_exitMainMenuToolStripSeparator";
            this._exitMainMenuToolStripSeparator.Size = new System.Drawing.Size(227, 6);
            // 
            // _exitMainMenuStripMenuItem
            // 
            this._exitMainMenuStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_exitMainMenuStripMenuItem.Image")));
            this._exitMainMenuStripMenuItem.Name = "_exitMainMenuStripMenuItem";
            this._exitMainMenuStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this._exitMainMenuStripMenuItem.Text = "E&xit";
            this._exitMainMenuStripMenuItem.Click += new System.EventHandler(this.ExitOnClick);
            // 
            // _toolsMainMenuStripMenuItem
            // 
            this._toolsMainMenuStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._preferencesMainMenuStripMenuItem});
            this._toolsMainMenuStripMenuItem.Name = "_toolsMainMenuStripMenuItem";
            this._toolsMainMenuStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this._toolsMainMenuStripMenuItem.Text = "&Tools";
            // 
            // _preferencesMainMenuStripMenuItem
            // 
            this._preferencesMainMenuStripMenuItem.Name = "_preferencesMainMenuStripMenuItem";
            this._preferencesMainMenuStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this._preferencesMainMenuStripMenuItem.Text = "Prefere&nces";
            this._preferencesMainMenuStripMenuItem.Click += new System.EventHandler(this.ShowPreferencesDialogOnClick);
            // 
            // _helpMainMenuStripMenuItem
            // 
            this._helpMainMenuStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutPluralSightDownloaderMainMenuStripMenuItem,
            this._licenseInformationMainMenuStripMenuItem});
            this._helpMainMenuStripMenuItem.Name = "_helpMainMenuStripMenuItem";
            this._helpMainMenuStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._helpMainMenuStripMenuItem.Text = "&Help";
            // 
            // _aboutPluralSightDownloaderMainMenuStripMenuItem
            // 
            this._aboutPluralSightDownloaderMainMenuStripMenuItem.Name = "_aboutPluralSightDownloaderMainMenuStripMenuItem";
            this._aboutPluralSightDownloaderMainMenuStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this._aboutPluralSightDownloaderMainMenuStripMenuItem.Text = "&About PluralSight Downloader";
            this._aboutPluralSightDownloaderMainMenuStripMenuItem.Click += new System.EventHandler(this.ShowAboutFormDialogOnClick);
            // 
            // _licenseInformationMainMenuStripMenuItem
            // 
            this._licenseInformationMainMenuStripMenuItem.Name = "_licenseInformationMainMenuStripMenuItem";
            this._licenseInformationMainMenuStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this._licenseInformationMainMenuStripMenuItem.Text = "&License Information...";
            this._licenseInformationMainMenuStripMenuItem.Click += new System.EventHandler(this.ShowLicenseFormDialogOnClick);
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addPluralSightCourseByUrlMainToolStripButton,
            this._findPluralSightCourseMainToolStripButton});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(584, 25);
            this._mainToolStrip.TabIndex = 2;
            this._mainToolStrip.Text = "Main ToolStrip";
            // 
            // _addPluralSightCourseByUrlMainToolStripButton
            // 
            this._addPluralSightCourseByUrlMainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPluralSightCourseByUrlMainToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseByUrlMainToolStripButton.Image")));
            this._addPluralSightCourseByUrlMainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPluralSightCourseByUrlMainToolStripButton.Name = "_addPluralSightCourseByUrlMainToolStripButton";
            this._addPluralSightCourseByUrlMainToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._addPluralSightCourseByUrlMainToolStripButton.Text = "Add PluralSight Course(s) by Url";
            this._addPluralSightCourseByUrlMainToolStripButton.Click += new System.EventHandler(this.AddPluralSightCourseByUrlOnClick);
            // 
            // _findPluralSightCourseMainToolStripButton
            // 
            this._findPluralSightCourseMainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._findPluralSightCourseMainToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_find;
            this._findPluralSightCourseMainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._findPluralSightCourseMainToolStripButton.Name = "_findPluralSightCourseMainToolStripButton";
            this._findPluralSightCourseMainToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._findPluralSightCourseMainToolStripButton.Text = "Find PluralSight Course(s)";
            this._findPluralSightCourseMainToolStripButton.Click += new System.EventHandler(this.FindPluralSightCourseOnClick);
            // 
            // _pluralSightDownloaderTabControl
            // 
            this._pluralSightDownloaderTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pluralSightDownloaderTabControl.Controls.Add(this._downloadTabPage);
            this._pluralSightDownloaderTabControl.Controls.Add(this._libraryTabPage);
            this._pluralSightDownloaderTabControl.Location = new System.Drawing.Point(12, 52);
            this._pluralSightDownloaderTabControl.Name = "_pluralSightDownloaderTabControl";
            this._pluralSightDownloaderTabControl.SelectedIndex = 0;
            this._pluralSightDownloaderTabControl.Size = new System.Drawing.Size(560, 385);
            this._pluralSightDownloaderTabControl.TabIndex = 3;
            // 
            // _downloadTabPage
            // 
            this._downloadTabPage.Controls.Add(this._downloadToolStrip);
            this._downloadTabPage.Controls.Add(this._addedCoursesDownloadDataGridView);
            this._downloadTabPage.Location = new System.Drawing.Point(4, 22);
            this._downloadTabPage.Name = "_downloadTabPage";
            this._downloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._downloadTabPage.Size = new System.Drawing.Size(552, 359);
            this._downloadTabPage.TabIndex = 0;
            this._downloadTabPage.Text = "Download(s)";
            this._downloadTabPage.UseVisualStyleBackColor = true;
            // 
            // _downloadToolStrip
            // 
            this._downloadToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._downloadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addPluralSightCourseByUrlDownloadToolStripButton,
            this._findPluralSightCourseDownloadToolStripButton,
            this._removePluralSightCourseDownloadToolStripButton,
            this._editPluralSightCourseDownloadToolStripButton,
            this._coursePriorityDownloadToolStripSeparator,
            this._maximumPriorityDownloadToolStripButton,
            this._increasePriorityDownloadToolStripButton,
            this._decreasePriorityDownloadToolStripButton,
            this._minimumPriorityDownloadToolStripButton});
            this._downloadToolStrip.Location = new System.Drawing.Point(3, 3);
            this._downloadToolStrip.Name = "_downloadToolStrip";
            this._downloadToolStrip.Size = new System.Drawing.Size(546, 25);
            this._downloadToolStrip.TabIndex = 1;
            this._downloadToolStrip.Text = "Download ToolStrip";
            // 
            // _addPluralSightCourseByUrlDownloadToolStripButton
            // 
            this._addPluralSightCourseByUrlDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPluralSightCourseByUrlDownloadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseByUrlDownloadToolStripButton.Image")));
            this._addPluralSightCourseByUrlDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPluralSightCourseByUrlDownloadToolStripButton.Name = "_addPluralSightCourseByUrlDownloadToolStripButton";
            this._addPluralSightCourseByUrlDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._addPluralSightCourseByUrlDownloadToolStripButton.Text = "Add PluralSight Course(s) by Url";
            this._addPluralSightCourseByUrlDownloadToolStripButton.Click += new System.EventHandler(this.AddPluralSightCourseByUrlOnClick);
            // 
            // _findPluralSightCourseDownloadToolStripButton
            // 
            this._findPluralSightCourseDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._findPluralSightCourseDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_find;
            this._findPluralSightCourseDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._findPluralSightCourseDownloadToolStripButton.Name = "_findPluralSightCourseDownloadToolStripButton";
            this._findPluralSightCourseDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._findPluralSightCourseDownloadToolStripButton.Text = "Find PluralSight Course(s)";
            this._findPluralSightCourseDownloadToolStripButton.Click += new System.EventHandler(this.FindPluralSightCourseOnClick);
            // 
            // _removePluralSightCourseDownloadToolStripButton
            // 
            this._removePluralSightCourseDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._removePluralSightCourseDownloadToolStripButton.Enabled = false;
            this._removePluralSightCourseDownloadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_removePluralSightCourseDownloadToolStripButton.Image")));
            this._removePluralSightCourseDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._removePluralSightCourseDownloadToolStripButton.Name = "_removePluralSightCourseDownloadToolStripButton";
            this._removePluralSightCourseDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._removePluralSightCourseDownloadToolStripButton.Text = "Remove Selected PluralSight Course";
            // 
            // _editPluralSightCourseDownloadToolStripButton
            // 
            this._editPluralSightCourseDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._editPluralSightCourseDownloadToolStripButton.Enabled = false;
            this._editPluralSightCourseDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_view;
            this._editPluralSightCourseDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editPluralSightCourseDownloadToolStripButton.Name = "_editPluralSightCourseDownloadToolStripButton";
            this._editPluralSightCourseDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._editPluralSightCourseDownloadToolStripButton.Text = "View Selected PluralSight Course Download Settings";
            // 
            // _coursePriorityDownloadToolStripSeparator
            // 
            this._coursePriorityDownloadToolStripSeparator.Name = "_coursePriorityDownloadToolStripSeparator";
            this._coursePriorityDownloadToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // _maximumPriorityDownloadToolStripButton
            // 
            this._maximumPriorityDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._maximumPriorityDownloadToolStripButton.Enabled = false;
            this._maximumPriorityDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_maximum_priority;
            this._maximumPriorityDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._maximumPriorityDownloadToolStripButton.Name = "_maximumPriorityDownloadToolStripButton";
            this._maximumPriorityDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._maximumPriorityDownloadToolStripButton.Text = "Maximum Priority";
            this._maximumPriorityDownloadToolStripButton.ToolTipText = "Move Selected PluralSight Course to Maximum Priority";
            // 
            // _increasePriorityDownloadToolStripButton
            // 
            this._increasePriorityDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._increasePriorityDownloadToolStripButton.Enabled = false;
            this._increasePriorityDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_increase_priority;
            this._increasePriorityDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._increasePriorityDownloadToolStripButton.Name = "_increasePriorityDownloadToolStripButton";
            this._increasePriorityDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._increasePriorityDownloadToolStripButton.Text = "Increase Priority";
            this._increasePriorityDownloadToolStripButton.ToolTipText = "Increase Selected PluralSight Course Priority";
            // 
            // _decreasePriorityDownloadToolStripButton
            // 
            this._decreasePriorityDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._decreasePriorityDownloadToolStripButton.Enabled = false;
            this._decreasePriorityDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_decrease_priority;
            this._decreasePriorityDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._decreasePriorityDownloadToolStripButton.Name = "_decreasePriorityDownloadToolStripButton";
            this._decreasePriorityDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._decreasePriorityDownloadToolStripButton.Text = "Decrease Priority";
            this._decreasePriorityDownloadToolStripButton.ToolTipText = "Decrease Selected PluralSight Course Priority";
            // 
            // _minimumPriorityDownloadToolStripButton
            // 
            this._minimumPriorityDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._minimumPriorityDownloadToolStripButton.Enabled = false;
            this._minimumPriorityDownloadToolStripButton.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_minimum_priority;
            this._minimumPriorityDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._minimumPriorityDownloadToolStripButton.Name = "_minimumPriorityDownloadToolStripButton";
            this._minimumPriorityDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._minimumPriorityDownloadToolStripButton.Text = "Minimum Priority";
            this._minimumPriorityDownloadToolStripButton.ToolTipText = "Move Selected PluralSight Course to Minimum Priority";
            // 
            // _addedCoursesDownloadDataGridView
            // 
            this._addedCoursesDownloadDataGridView.AllowUserToAddRows = false;
            this._addedCoursesDownloadDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._addedCoursesDownloadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._addedCoursesDownloadDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._addedCoursesDownloadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._addedCoursesDownloadDataGridView.ContextMenuStrip = this._addedCoursesDownloadDataGridViewContextMenuStrip;
            this._addedCoursesDownloadDataGridView.Location = new System.Drawing.Point(7, 31);
            this._addedCoursesDownloadDataGridView.MultiSelect = false;
            this._addedCoursesDownloadDataGridView.Name = "_addedCoursesDownloadDataGridView";
            this._addedCoursesDownloadDataGridView.ReadOnly = true;
            this._addedCoursesDownloadDataGridView.RowHeadersVisible = false;
            this._addedCoursesDownloadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._addedCoursesDownloadDataGridView.Size = new System.Drawing.Size(540, 290);
            this._addedCoursesDownloadDataGridView.TabIndex = 0;
            // 
            // _addedCoursesDownloadDataGridViewContextMenuStrip
            // 
            this._addedCoursesDownloadDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem,
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem,
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem,
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem,
            this._coursePriorityDownloadDataGridViewContextMenuStripSeparator,
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem,
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem,
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem,
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem});
            this._addedCoursesDownloadDataGridViewContextMenuStrip.Name = "_addedCoursesDownloadDataGridViewContextMenuStrip";
            this._addedCoursesDownloadDataGridViewContextMenuStrip.Size = new System.Drawing.Size(245, 186);
            this._addedCoursesDownloadDataGridViewContextMenuStrip.Text = "AddedCoursesDownloadDataGridViewContextMenuStrip";
            // 
            // _addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Image")));
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Name = "_addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem";
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Text = "&Add PluralSight Course by Url";
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Add PluralSight Course(s) by Url";
            this._addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem.Click += new System.EventHandler(this.AddPluralSightCourseByUrlOnClick);
            // 
            // _findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_find;
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Name = "_findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem";
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Text = "&Find PluralSight Course(s)";
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Find PluralSight Course(s)";
            this._findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Click += new System.EventHandler(this.FindPluralSightCourseOnClick);
            // 
            // _removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Image")));
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Name = "_removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem";
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Text = "&Remove PluralSight Course";
            this._removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Remove Selected PluralSight Course";
            // 
            // _editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_view;
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Name = "_editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem";
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.Text = "&View PluralSight Course Settings";
            this._editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "View Selected PluralSight Course Download Settings";
            // 
            // _coursePriorityDownloadDataGridViewContextMenuStripSeparator
            // 
            this._coursePriorityDownloadDataGridViewContextMenuStripSeparator.Name = "_coursePriorityDownloadDataGridViewContextMenuStripSeparator";
            this._coursePriorityDownloadDataGridViewContextMenuStripSeparator.Size = new System.Drawing.Size(241, 6);
            // 
            // _maximumPriorityDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_maximum_priority;
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.Name = "_maximumPriorityDownloadDataGridViewContextMenuStripMenuItem";
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.Text = "&Maximum Priority";
            this._maximumPriorityDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Move Selected PluralSight Course to Maximum Priority";
            // 
            // _increasePriorityDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_increase_priority;
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.Name = "_increasePriorityDownloadDataGridViewContextMenuStripMenuItem";
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.Text = "&Increase Priority";
            this._increasePriorityDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Increase Selected PluralSight Course Priority";
            // 
            // _decreasePriorityDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_decrease_priority;
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.Name = "_decreasePriorityDownloadDataGridViewContextMenuStripMenuItem";
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.Text = "&Decrease Priority";
            this._decreasePriorityDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Decrease Selected PluralSight Course Priority";
            // 
            // _minimumPriorityDownloadDataGridViewContextMenuStripMenuItem
            // 
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.Enabled = false;
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.course_minimum_priority;
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.Name = "_minimumPriorityDownloadDataGridViewContextMenuStripMenuItem";
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.Text = "Mi&nimum Priority";
            this._minimumPriorityDownloadDataGridViewContextMenuStripMenuItem.ToolTipText = "Move Selected PluralSight Course to Minimum Priority";
            // 
            // _libraryTabPage
            // 
            this._libraryTabPage.Controls.Add(this._libraryToolStrip);
            this._libraryTabPage.Controls.Add(this._libraryFilterListBox);
            this._libraryTabPage.Controls.Add(this._libraryDataGridView);
            this._libraryTabPage.Location = new System.Drawing.Point(4, 22);
            this._libraryTabPage.Name = "_libraryTabPage";
            this._libraryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._libraryTabPage.Size = new System.Drawing.Size(552, 359);
            this._libraryTabPage.TabIndex = 1;
            this._libraryTabPage.Text = "Library";
            this._libraryTabPage.UseVisualStyleBackColor = true;
            // 
            // _libraryToolStrip
            // 
            this._libraryToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._libraryToolStrip.Location = new System.Drawing.Point(3, 3);
            this._libraryToolStrip.Name = "_libraryToolStrip";
            this._libraryToolStrip.Size = new System.Drawing.Size(546, 25);
            this._libraryToolStrip.TabIndex = 1;
            this._libraryToolStrip.Text = "Library ToolStrip";
            // 
            // _libraryFilterListBox
            // 
            this._libraryFilterListBox.FormattingEnabled = true;
            this._libraryFilterListBox.Location = new System.Drawing.Point(6, 31);
            this._libraryFilterListBox.Name = "_libraryFilterListBox";
            this._libraryFilterListBox.Size = new System.Drawing.Size(120, 251);
            this._libraryFilterListBox.TabIndex = 0;
            // 
            // _libraryDataGridView
            // 
            this._libraryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._libraryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._libraryDataGridView.Location = new System.Drawing.Point(132, 31);
            this._libraryDataGridView.Name = "_libraryDataGridView";
            this._libraryDataGridView.Size = new System.Drawing.Size(414, 322);
            this._libraryDataGridView.TabIndex = 2;
            // 
            // _downloadSearchToolStripTextBox
            // 
            this._downloadSearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._downloadSearchToolStripTextBox.Name = "_downloadSearchToolStripTextBox";
            this._downloadSearchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _librarySearchToolStripTextBox
            // 
            this._librarySearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._librarySearchToolStripTextBox.Name = "_librarySearchToolStripTextBox";
            this._librarySearchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 440);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._mainStatusStrip.Size = new System.Drawing.Size(584, 22);
            this._mainStatusStrip.TabIndex = 1;
            this._mainStatusStrip.Text = "statusStrip1";
            // 
            // _statusToolStripStatusLabel
            // 
            this._statusToolStripStatusLabel.Name = "_statusToolStripStatusLabel";
            this._statusToolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this._statusToolStripStatusLabel.Text = ":Status:";
            // 
            // _pluralSightDownloaderErrorProvider
            // 
            this._pluralSightDownloaderErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this._pluralSightDownloaderTabControl);
            this.Controls.Add(this._mainToolStrip);
            this.Controls.Add(this._mainStatusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "PluralSight Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormOnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormOnFormClosed);
            this.Load += new System.EventHandler(this.MainFormOnLoad);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            this._pluralSightDownloaderTabControl.ResumeLayout(false);
            this._downloadTabPage.ResumeLayout(false);
            this._downloadTabPage.PerformLayout();
            this._downloadToolStrip.ResumeLayout(false);
            this._downloadToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._addedCoursesDownloadDataGridView)).EndInit();
            this._addedCoursesDownloadDataGridViewContextMenuStrip.ResumeLayout(false);
            this._libraryTabPage.ResumeLayout(false);
            this._libraryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._libraryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pluralSightDownloaderErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutPluralSightDownloaderMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _preferencesMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStrip _mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _licenseInformationMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel _statusToolStripStatusLabel;
        private System.Windows.Forms.TabControl _pluralSightDownloaderTabControl;
        private System.Windows.Forms.TabPage _downloadTabPage;
        private System.Windows.Forms.DataGridView _addedCoursesDownloadDataGridView;
        private System.Windows.Forms.TabPage _libraryTabPage;
        private System.Windows.Forms.ToolStrip _downloadToolStrip;
        private System.Windows.Forms.ToolStripTextBox _downloadSearchToolStripTextBox;
        private System.Windows.Forms.ToolStrip _libraryToolStrip;
        private System.Windows.Forms.ToolStripTextBox _librarySearchToolStripTextBox;
        private System.Windows.Forms.ListBox _libraryFilterListBox;
        private System.Windows.Forms.DataGridView _libraryDataGridView;
        private System.Windows.Forms.ToolStripButton _removePluralSightCourseDownloadToolStripButton;
        private System.Windows.Forms.ToolStripButton _editPluralSightCourseDownloadToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem _toolsMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _findPluralSightCourseMainMenuStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator _coursePriorityDownloadToolStripSeparator;
        private System.Windows.Forms.ToolStripButton _maximumPriorityDownloadToolStripButton;
        private System.Windows.Forms.ToolStripButton _increasePriorityDownloadToolStripButton;
        private System.Windows.Forms.ToolStripButton _decreasePriorityDownloadToolStripButton;
        private System.Windows.Forms.ToolStripButton _minimumPriorityDownloadToolStripButton;
        private System.Windows.Forms.ContextMenuStrip _addedCoursesDownloadDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _removePluralSightCourseDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _editPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator _coursePriorityDownloadDataGridViewContextMenuStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem _maximumPriorityDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _increasePriorityDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _decreasePriorityDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _minimumPriorityDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripButton _findPluralSightCourseDownloadToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem _findPluralSightCourseDownloadDataGridViewContextMenuStripMenuItem;
        private System.Windows.Forms.ToolStripButton _findPluralSightCourseMainToolStripButton;
        private System.Windows.Forms.ErrorProvider _pluralSightDownloaderErrorProvider;
        private ToolStripMenuItem _addPluralSightCourseByUrlMainMenuStripMenuItem;
        private ToolStripButton _addPluralSightCourseByUrlMainToolStripButton;
        private ToolStripButton _addPluralSightCourseByUrlDownloadToolStripButton;
        private ToolStripMenuItem _addPluralSightCourseByUrlDownloadDataGridViewContextMenuStripMenuItem;
        private ToolStripSeparator _exitMainMenuToolStripSeparator;
    }
}

