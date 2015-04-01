using System;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class LicenseForm : HelpFormBase
    {
        private static LicenseForm _instance;

        private LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, System.EventArgs e)
        {
            string licenseDisplay = string.Format("{0} License Information", AssemblyProduct);
            Text = licenseDisplay;
            ContentInfoLabel.Text = licenseDisplay;
            // TODO: Read and display the license.
        }

        public static DialogResult ShowLicenseFormDialog(IWin32Window owner)
        {
            if (_instance == null)
            {
                _instance = new LicenseForm();
            }
            return _instance.ShowDialog(owner);
        }
    }
}
