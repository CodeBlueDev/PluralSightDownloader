using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class AboutForm : Form
    {
        private static AboutForm _instance;

        //private Assembly _assembly;

        //private AssemblyName _assemblyName;

        private AboutForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.Black), 0, Height - 70, Width, Height - 70);
        }

        private void AboutForm_Load(object sender, System.EventArgs e)
        {
            // Set the icon to the owner's icon.
            if (Owner != null)
            {
                Icon = Owner.Icon;
            }

            // TODO: Graphic or something loaded on the form.

            // TODO: Refactor to separate methods and make the assemblies fields.
            // Get the assembly information.
            //_assembly = Owner == null ? Assembly.GetEntryAssembly() : Owner.GetType().Assembly;
            //_assemblyName = _assembly.GetName();

            Assembly assembly = Owner == null ? Assembly.GetEntryAssembly() : Owner.GetType().Assembly;
            AssemblyName assemblyName = assembly.GetName();

            // Iterate over the AssemblyInfo.
            string applicationTitle = "Unknown Application";
            string copyrightInfo = "Unknown Copyright";
            string companyInfo = string.Empty;
            foreach (var customAttribute in assembly.GetCustomAttributes(false))
            {
                AssemblyTitleAttribute titleAttribute = customAttribute as AssemblyTitleAttribute;
                if (titleAttribute != null)
                {
                    applicationTitle = titleAttribute.Title;
                }

                AssemblyCopyrightAttribute copyrightAttribute = customAttribute as AssemblyCopyrightAttribute;
                if (copyrightAttribute != null)
                {
                    copyrightInfo = copyrightAttribute.Copyright;
                }

                AssemblyProductAttribute productAttribute = customAttribute as AssemblyProductAttribute;
                if (productAttribute != null)
                {
                    _projectLabel.Text = productAttribute.Product;
                }

                AssemblyCompanyAttribute companyAttribute = customAttribute as AssemblyCompanyAttribute;
                if (companyAttribute != null)
                {
                    companyInfo = companyAttribute.Company;
                }
            }

            // If name was an empty string, call it the assembly.
            if (string.IsNullOrEmpty(applicationTitle))
            {
                applicationTitle = assemblyName.Name;
            }

            if (string.IsNullOrEmpty(_projectLabel.Text))
            {
                _projectLabel.Text = string.IsNullOrEmpty(applicationTitle) ? "Unknown Project" : applicationTitle;
            }

            Text = string.Format("About {0}", _projectLabel.Text);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(applicationTitle);
            stringBuilder.AppendFormat("Version {0}", assemblyName.Version);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("{0} {1}", copyrightInfo, companyInfo);

            _assemblyInfoLabel.Text = stringBuilder.ToString();

            stringBuilder.Clear();
            stringBuilder.AppendLine("References: ");
            foreach (AssemblyName referencedAssembly in assembly.GetReferencedAssemblies())
            {
                stringBuilder.AppendFormat("\t{0}{1}", referencedAssembly.FullName, System.Environment.NewLine);
            }
            _referencedAssembliesTextBox.Text = stringBuilder.ToString();
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
