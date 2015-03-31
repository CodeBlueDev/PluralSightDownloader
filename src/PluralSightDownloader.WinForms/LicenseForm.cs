using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class LicenseForm : Form
    {
        private static LicenseForm _instance;

        private LicenseForm()
        {
            InitializeComponent();
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
