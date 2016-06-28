using System.Text;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class AboutForm : HelpFormBase
    {
        private static AboutForm _instance;

        private AboutForm()
        {
            this.InitializeComponent();
        }

        private void AboutForm_Load(object sender, System.EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            this.Text = string.Format("About {0}", AssemblyProduct);

            stringBuilder.AppendLine(AssemblyTitle);
            stringBuilder.AppendFormat("Version {0}", AssemblyVersion);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("{0} {1}. All Rights Reserved.", AssemblyCopyright, AssemblyCompany);

            this.ContentInfoLabel.Text = stringBuilder.ToString();

            stringBuilder.Clear();
            stringBuilder.AppendFormat("{0} uses the following libraries:{1}{1}", this.ProductTitle.Text,
                System.Environment.NewLine);
            foreach (string referencedAssembly in ReferencedAssemblies)
            {
                stringBuilder.AppendFormat("\t{0}{1}", referencedAssembly, System.Environment.NewLine);
                // TODO: Should this recurse a layer down for more referencedAssemblies?
            }
            this.ContentInfoTextBox.Text = stringBuilder.ToString();
        }

        private void _licenseButton_Click(object sender, System.EventArgs e)
        {
            LicenseForm.ShowLicenseFormDialog(this);
        }

        public static DialogResult ShowAboutFormDialog(IWin32Window owner)
        {
            if (_instance == null)
            {
                _instance = new AboutForm();
            }
            return _instance.ShowDialog(owner);
        }
    }
}
