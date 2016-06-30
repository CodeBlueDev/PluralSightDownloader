namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System.ComponentModel;
    using System.Windows.Forms;

    using CodeBlueDev.PluralSightDownloader.WinForms.Controls;
    using CodeBlueDev.PluralSightDownloader.WinForms.Panels;

    public sealed partial class PreferencesForm : Form
    {
        private FlowLayoutLabel currentSelectedFlowLayoutLabel;

        private PreferencesPanelBase currentSelectedPanel;

        public PreferencesForm()
        {
            this.InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Initialize();
        }

        private void Initialize()
        {
            this._loginPreferencesPanel = new LoginPreferencesPanel();
            this._loginOptionsLabel.Tag = this._loginPreferencesPanel;

            this._downloadPreferencesPanel = new DownloadPreferencesPanel();
            this._downloadOptionsLabel.Tag = this._downloadPreferencesPanel;

            this._contentPanel.Controls.Clear();
            this._contentPanel.Controls.AddRange(new Control[]
            {
                this._loginPreferencesPanel,
                this._downloadPreferencesPanel
            });

            this.NavigationLabelsOnClick(this._loginOptionsLabel, new System.EventArgs());
        }

        private void NavigationLabelsOnClick(object sender, System.EventArgs e)
        {
            FlowLayoutLabel clickedFlowLayoutLabel = sender as FlowLayoutLabel;
            if (clickedFlowLayoutLabel == null)
            {
                return;
            }

            if (clickedFlowLayoutLabel == this.currentSelectedFlowLayoutLabel)
            {
                return;
            }

            if(!this.ShowPanel(clickedFlowLayoutLabel.Tag as PreferencesPanelBase))
            {
                return;
            }

            if (this.currentSelectedFlowLayoutLabel != null && 
                this.currentSelectedFlowLayoutLabel.IsSelected)
            {
                this.currentSelectedFlowLayoutLabel.Deselect();
            }

            this.currentSelectedFlowLayoutLabel = clickedFlowLayoutLabel;
            this.currentSelectedFlowLayoutLabel.Select();
        }

        private bool ShowPanel(PreferencesPanelBase preferencesPanel)
        {
            if (preferencesPanel == null)
            {
                return false;
            }

            if (this.currentSelectedPanel == preferencesPanel)
            {
                return false;
            }

            preferencesPanel.Visible = true;
            preferencesPanel.Invalidate();
            preferencesPanel.BringToFront();

            if (this.currentSelectedPanel != null)
            {
                this.currentSelectedPanel.Visible = false;
            }

            this.currentSelectedPanel = preferencesPanel;

            return true;
        }

        private void NavigationLabelsOnBeforeMouseClick(object sender, CancelEventArgs e)
        {
            
        }
    }
}
