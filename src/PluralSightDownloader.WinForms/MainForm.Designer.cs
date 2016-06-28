namespace PluralSightDownloader.WinForms
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolsMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._preferencesMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutPluralSightDownloaderMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._licenseInformationMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._addPluralSightCourseMainToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._pluralSightDownloaderTabControl = new System.Windows.Forms.TabControl();
            this._downloadTabPage = new System.Windows.Forms.TabPage();
            this._downloadToolStrip = new System.Windows.Forms.ToolStrip();
            this._downloadSearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._addPluralSightCourseDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._removePluralSightCourseDownloadToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this._editPluralSightCourseDownloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._downloadDataGridView = new System.Windows.Forms.DataGridView();
            this._libraryTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._libraryToolStrip = new System.Windows.Forms.ToolStrip();
            this._librarySearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._libraryFilterLlistBox = new System.Windows.Forms.ListBox();
            this._mainMenuStrip.SuspendLayout();
            this._mainStatusStrip.SuspendLayout();
            this._mainToolStrip.SuspendLayout();
            this._pluralSightDownloaderTabControl.SuspendLayout();
            this._downloadTabPage.SuspendLayout();
            this._downloadToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._downloadDataGridView)).BeginInit();
            this._libraryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this._libraryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMainToolStripMenuItem,
            this._toolsMainToolStripMenuItem,
            this._helpMainToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(529, 24);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _fileMainToolStripMenuItem
            // 
            this._fileMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitMainToolStripMenuItem});
            this._fileMainToolStripMenuItem.Name = "_fileMainToolStripMenuItem";
            this._fileMainToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileMainToolStripMenuItem.Text = "&File";
            // 
            // _exitMainToolStripMenuItem
            // 
            this._exitMainToolStripMenuItem.Name = "_exitMainToolStripMenuItem";
            this._exitMainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._exitMainToolStripMenuItem.Text = "E&xit";
            this._exitMainToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemOnClick);
            // 
            // _toolsMainToolStripMenuItem
            // 
            this._toolsMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._preferencesMainToolStripMenuItem});
            this._toolsMainToolStripMenuItem.Name = "_toolsMainToolStripMenuItem";
            this._toolsMainToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this._toolsMainToolStripMenuItem.Text = "&Tools";
            // 
            // _preferencesMainToolStripMenuItem
            // 
            this._preferencesMainToolStripMenuItem.Name = "_preferencesMainToolStripMenuItem";
            this._preferencesMainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._preferencesMainToolStripMenuItem.Text = "Prefere&nces";
            this._preferencesMainToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItemOnClick);
            // 
            // _helpMainToolStripMenuItem
            // 
            this._helpMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutPluralSightDownloaderMainToolStripMenuItem,
            this._licenseInformationMainToolStripMenuItem});
            this._helpMainToolStripMenuItem.Name = "_helpMainToolStripMenuItem";
            this._helpMainToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._helpMainToolStripMenuItem.Text = "&Help";
            // 
            // _aboutPluralSightDownloaderMainToolStripMenuItem
            // 
            this._aboutPluralSightDownloaderMainToolStripMenuItem.Name = "_aboutPluralSightDownloaderMainToolStripMenuItem";
            this._aboutPluralSightDownloaderMainToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this._aboutPluralSightDownloaderMainToolStripMenuItem.Text = "About PluralSight Downloader";
            this._aboutPluralSightDownloaderMainToolStripMenuItem.Click += new System.EventHandler(this.AboutPluralSightDownloaderToolStripMenuItemOnClick);
            // 
            // _licenseInformationMainToolStripMenuItem
            // 
            this._licenseInformationMainToolStripMenuItem.Name = "_licenseInformationMainToolStripMenuItem";
            this._licenseInformationMainToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this._licenseInformationMainToolStripMenuItem.Text = "&License Information...";
            this._licenseInformationMainToolStripMenuItem.Click += new System.EventHandler(this.LicenseInformationToolStripMenuItemOnClick);
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusToolStripStatusLabel});
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 416);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._mainStatusStrip.Size = new System.Drawing.Size(529, 22);
            this._mainStatusStrip.TabIndex = 1;
            this._mainStatusStrip.Text = "statusStrip1";
            // 
            // _statusToolStripStatusLabel
            // 
            this._statusToolStripStatusLabel.Name = "_statusToolStripStatusLabel";
            this._statusToolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this._statusToolStripStatusLabel.Text = ":Status:";
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addPluralSightCourseMainToolStripButton});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(529, 25);
            this._mainToolStrip.TabIndex = 2;
            this._mainToolStrip.Text = "toolStrip1";
            // 
            // _addPluralSightCourseMainToolStripButton
            // 
            this._addPluralSightCourseMainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPluralSightCourseMainToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseMainToolStripButton.Image")));
            this._addPluralSightCourseMainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPluralSightCourseMainToolStripButton.Name = "_addPluralSightCourseMainToolStripButton";
            this._addPluralSightCourseMainToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._addPluralSightCourseMainToolStripButton.Text = "Add PluralSight Course";
            // 
            // _pluralSightDownloaderTabControl
            // 
            this._pluralSightDownloaderTabControl.Controls.Add(this._downloadTabPage);
            this._pluralSightDownloaderTabControl.Controls.Add(this._libraryTabPage);
            this._pluralSightDownloaderTabControl.Location = new System.Drawing.Point(12, 52);
            this._pluralSightDownloaderTabControl.Name = "_pluralSightDownloaderTabControl";
            this._pluralSightDownloaderTabControl.SelectedIndex = 0;
            this._pluralSightDownloaderTabControl.Size = new System.Drawing.Size(505, 361);
            this._pluralSightDownloaderTabControl.TabIndex = 3;
            // 
            // _downloadTabPage
            // 
            this._downloadTabPage.Controls.Add(this._downloadToolStrip);
            this._downloadTabPage.Controls.Add(this._downloadDataGridView);
            this._downloadTabPage.Location = new System.Drawing.Point(4, 22);
            this._downloadTabPage.Name = "_downloadTabPage";
            this._downloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._downloadTabPage.Size = new System.Drawing.Size(497, 335);
            this._downloadTabPage.TabIndex = 0;
            this._downloadTabPage.Text = "Download(s)";
            this._downloadTabPage.UseVisualStyleBackColor = true;
            // 
            // _downloadToolStrip
            // 
            this._downloadToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._downloadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._downloadSearchToolStripTextBox,
            this._addPluralSightCourseDownloadToolStripButton,
            this._removePluralSightCourseDownloadToolStripButton1,
            this._editPluralSightCourseDownloadToolStripButton});
            this._downloadToolStrip.Location = new System.Drawing.Point(3, 3);
            this._downloadToolStrip.Name = "_downloadToolStrip";
            this._downloadToolStrip.Size = new System.Drawing.Size(491, 25);
            this._downloadToolStrip.TabIndex = 1;
            this._downloadToolStrip.Text = "toolStrip1";
            // 
            // _downloadSearchToolStripTextBox
            // 
            this._downloadSearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._downloadSearchToolStripTextBox.Name = "_downloadSearchToolStripTextBox";
            this._downloadSearchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _addPluralSightCourseDownloadToolStripButton
            // 
            this._addPluralSightCourseDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPluralSightCourseDownloadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addPluralSightCourseDownloadToolStripButton.Image")));
            this._addPluralSightCourseDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPluralSightCourseDownloadToolStripButton.Name = "_addPluralSightCourseDownloadToolStripButton";
            this._addPluralSightCourseDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._addPluralSightCourseDownloadToolStripButton.Text = "Add PluralSight Course";
            // 
            // _removePluralSightCourseDownloadToolStripButton1
            // 
            this._removePluralSightCourseDownloadToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._removePluralSightCourseDownloadToolStripButton1.Enabled = false;
            this._removePluralSightCourseDownloadToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("_removePluralSightCourseDownloadToolStripButton1.Image")));
            this._removePluralSightCourseDownloadToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._removePluralSightCourseDownloadToolStripButton1.Name = "_removePluralSightCourseDownloadToolStripButton1";
            this._removePluralSightCourseDownloadToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this._removePluralSightCourseDownloadToolStripButton1.Text = "Remove PluralSight Course";
            // 
            // _editPluralSightCourseDownloadToolStripButton
            // 
            this._editPluralSightCourseDownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._editPluralSightCourseDownloadToolStripButton.Enabled = false;
            this._editPluralSightCourseDownloadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_editPluralSightCourseDownloadToolStripButton.Image")));
            this._editPluralSightCourseDownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editPluralSightCourseDownloadToolStripButton.Name = "_editPluralSightCourseDownloadToolStripButton";
            this._editPluralSightCourseDownloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._editPluralSightCourseDownloadToolStripButton.Text = "Edit PluralSight Course Download";
            // 
            // _downloadDataGridView
            // 
            this._downloadDataGridView.AllowUserToAddRows = false;
            this._downloadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._downloadDataGridView.Location = new System.Drawing.Point(6, 32);
            this._downloadDataGridView.MultiSelect = false;
            this._downloadDataGridView.Name = "_downloadDataGridView";
            this._downloadDataGridView.ReadOnly = true;
            this._downloadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._downloadDataGridView.Size = new System.Drawing.Size(485, 297);
            this._downloadDataGridView.TabIndex = 0;
            // 
            // _libraryTabPage
            // 
            this._libraryTabPage.Controls.Add(this.dataGridView1);
            this._libraryTabPage.Controls.Add(this._libraryToolStrip);
            this._libraryTabPage.Controls.Add(this._libraryFilterLlistBox);
            this._libraryTabPage.Location = new System.Drawing.Point(4, 22);
            this._libraryTabPage.Name = "_libraryTabPage";
            this._libraryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._libraryTabPage.Size = new System.Drawing.Size(497, 335);
            this._libraryTabPage.TabIndex = 1;
            this._libraryTabPage.Text = "Library";
            this._libraryTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // _libraryToolStrip
            // 
            this._libraryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._librarySearchToolStripTextBox});
            this._libraryToolStrip.Location = new System.Drawing.Point(3, 3);
            this._libraryToolStrip.Name = "_libraryToolStrip";
            this._libraryToolStrip.Size = new System.Drawing.Size(491, 25);
            this._libraryToolStrip.TabIndex = 1;
            this._libraryToolStrip.Text = "toolStrip1";
            // 
            // _librarySearchToolStripTextBox
            // 
            this._librarySearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._librarySearchToolStripTextBox.Name = "_librarySearchToolStripTextBox";
            this._librarySearchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // _libraryFilterLlistBox
            // 
            this._libraryFilterLlistBox.FormattingEnabled = true;
            this._libraryFilterLlistBox.Location = new System.Drawing.Point(6, 31);
            this._libraryFilterLlistBox.Name = "_libraryFilterLlistBox";
            this._libraryFilterLlistBox.Size = new System.Drawing.Size(120, 251);
            this._libraryFilterLlistBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 438);
            this.Controls.Add(this._pluralSightDownloaderTabControl);
            this.Controls.Add(this._mainToolStrip);
            this.Controls.Add(this._mainStatusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "PluralSight Downloader";
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._mainStatusStrip.ResumeLayout(false);
            this._mainStatusStrip.PerformLayout();
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            this._pluralSightDownloaderTabControl.ResumeLayout(false);
            this._downloadTabPage.ResumeLayout(false);
            this._downloadTabPage.PerformLayout();
            this._downloadToolStrip.ResumeLayout(false);
            this._downloadToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._downloadDataGridView)).EndInit();
            this._libraryTabPage.ResumeLayout(false);
            this._libraryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this._libraryToolStrip.ResumeLayout(false);
            this._libraryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutPluralSightDownloaderMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _preferencesMainToolStripMenuItem;
        private System.Windows.Forms.ToolStrip _mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _licenseInformationMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel _statusToolStripStatusLabel;
        private System.Windows.Forms.TabControl _pluralSightDownloaderTabControl;
        private System.Windows.Forms.TabPage _downloadTabPage;
        private System.Windows.Forms.DataGridView _downloadDataGridView;
        private System.Windows.Forms.TabPage _libraryTabPage;
        private System.Windows.Forms.ToolStrip _downloadToolStrip;
        private System.Windows.Forms.ToolStripTextBox _downloadSearchToolStripTextBox;
        private System.Windows.Forms.ToolStrip _libraryToolStrip;
        private System.Windows.Forms.ToolStripTextBox _librarySearchToolStripTextBox;
        private System.Windows.Forms.ListBox _libraryFilterLlistBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton _addPluralSightCourseMainToolStripButton;
        private System.Windows.Forms.ToolStripButton _addPluralSightCourseDownloadToolStripButton;
        private System.Windows.Forms.ToolStripButton _removePluralSightCourseDownloadToolStripButton1;
        private System.Windows.Forms.ToolStripButton _editPluralSightCourseDownloadToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem _toolsMainToolStripMenuItem;
    }
}

