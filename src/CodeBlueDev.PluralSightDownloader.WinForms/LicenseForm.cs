namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System;
    using System.Windows.Forms;

    public partial class LicenseForm : HelpFormBase
    {
        private static LicenseForm _instance;

        private LicenseForm()
        {
            this.InitializeComponent();
        }

        private void LicenseFormOnLoad(object sender, EventArgs e)
        {
            string licenseDisplay = $"{AssemblyProduct} License Information";
            this.Text = licenseDisplay;
            this.ContentInfoLabel.Text = licenseDisplay;
            // TODO: Read and display the license.
        }

        public static DialogResult ShowLicenseFormDialog(IWin32Window owner)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new LicenseForm();
            }
            return _instance.ShowDialog(owner);
        }
    }
}
