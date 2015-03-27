using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class MainForm : Form
    {
        private readonly PreferencesForm _preferencesForm;

        private readonly AboutForm _aboutForm;

        public MainForm()
        {
            // TODO: Make the constructor take the configuration file?
            _preferencesForm = new PreferencesForm();
            _aboutForm = new AboutForm();

            InitializePreferencesFormEvents();

            InitializeComponent();
            InitializeToolStripRenderers();
        }

        private void InitializeToolStripRenderers()
        {
            // TODO: Play with these by making my own.
            _mainMenuStrip.Renderer = new ToolStripProfessionalRenderer();
            _mainToolStrip.Renderer = new ToolStripProfessionalRenderer();
            _mainStatusStrip.Renderer = new ToolStripSystemRenderer();
        }

        private void InitializePreferencesFormEvents()
        {
            // TODO: Tie up the events to save the configuration from here.
            _preferencesForm.Closing += PreferencesFormOnClosing;
        }

        private void PreferencesFormOnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            // TODO: Check and validate configuration changes.
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            // TODO: Check if the user has something active.
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _preferencesForm.ShowDialog(this);
        }

        private void _aboutPluralSightDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutForm.ShowDialog(this);
        }
    }
}
