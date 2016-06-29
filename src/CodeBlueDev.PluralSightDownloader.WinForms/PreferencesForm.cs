namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System.Windows.Forms;

    using CodeBlueDev.PluralSightDownloader.WinForms.Controls;

    public partial class PreferencesForm : Form
    {
        private FlowLayoutLabel currentSelectedFlowLayoutLabel;

        public PreferencesForm()
        {
            this.InitializeComponent();

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

            if (this.currentSelectedFlowLayoutLabel != null && 
                this.currentSelectedFlowLayoutLabel.IsSelected)
            {
                this.currentSelectedFlowLayoutLabel.Deselect();
            }

            this.currentSelectedFlowLayoutLabel = clickedFlowLayoutLabel;
            this.currentSelectedFlowLayoutLabel.Select();
            // TODO: SHOW THE PROPER PANEL.
        }

        private void NavigationLabelsOnBeforeMouseClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
