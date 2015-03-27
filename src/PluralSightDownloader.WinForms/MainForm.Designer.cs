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
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutPluralSightDownloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._preferencesToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutPluralSightDownloaderToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._helpToolStripMenuItem.Text = "&Help";
            // 
            // _aboutPluralSightDownloaderToolStripMenuItem
            // 
            this._aboutPluralSightDownloaderToolStripMenuItem.Name = "_aboutPluralSightDownloaderToolStripMenuItem";
            this._aboutPluralSightDownloaderToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this._aboutPluralSightDownloaderToolStripMenuItem.Text = "About PluralSight Downloader";
            this._aboutPluralSightDownloaderToolStripMenuItem.Click += new System.EventHandler(this._aboutPluralSightDownloaderToolStripMenuItem_Click);
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 240);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this._mainStatusStrip.TabIndex = 1;
            this._mainStatusStrip.Text = "statusStrip1";
            // 
            // _preferencesToolStripMenuItem
            // 
            this._preferencesToolStripMenuItem.Name = "_preferencesToolStripMenuItem";
            this._preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._preferencesToolStripMenuItem.Text = "Prefere&nces";
            this._preferencesToolStripMenuItem.Click += new System.EventHandler(this._preferencesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._mainStatusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "PluralSight Downloader";
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutPluralSightDownloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _preferencesToolStripMenuItem;
    }
}

