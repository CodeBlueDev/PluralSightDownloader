using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class MainForm : Form
    {
        private readonly PreferencesForm preferencesForm;

        public MainForm()
        {
            // TODO: Make the constructor take the configuration file?
            this.preferencesForm = new PreferencesForm();

            this.InitializePreferencesFormEvents();

            this.InitializeComponent();
            this.InitializeToolStripRenderers();
        }

        private void InitializePreferencesFormEvents()
        {
            // TODO: Tie up the events to save the configuration from here.
            this.preferencesForm.Closing += this.PreferencesFormOnClosing;
        }

        private void InitializeToolStripRenderers()
        {
            // TODO: Play with these by making my own.
            this._mainMenuStrip.Renderer = new ToolStripProfessionalRenderer();
            this._mainToolStrip.Renderer = new ToolStripProfessionalRenderer();
            this._mainStatusStrip.Renderer = new ToolStripSystemRenderer();
        }

        #region Preferences Form Events

        private void PreferencesFormOnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            // TODO: Check and validate configuration changes.
        }

        #endregion Preferences Form Events

        #region Main Form Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // TODO: Check if the user has something active.
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void ExitToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreferencesToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            this.preferencesForm.ShowDialog(this);
        }

        private void AboutPluralSightDownloaderToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            AboutForm.ShowAboutFormDialog(this);
        }

        private void LicenseInformationToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            LicenseForm.ShowLicenseFormDialog(this);
        }

        #endregion Main Form Events
    }
}
