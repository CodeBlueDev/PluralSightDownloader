namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System.Windows.Forms;

    public abstract partial class HelpFormBase : Form
    {
        private static AssemblyReader _assemblyReader;

        private static string _assemblyTitle;
        private static string _assemblyCopyright;
        private static string _assemblyProduct;
        private static string _assemblyCompany;
        private static string _assemblyVersion;

        private static string[] _referencedAssemblies;

        private readonly HelpFormBase _instance;

        protected HelpFormBase()
        {
            this.InitializeComponent();
            this._instance = this;
        }

        protected static string AssemblyTitle
        {
            get
            {
                if (!string.IsNullOrEmpty(_assemblyTitle))
                {
                    return _assemblyTitle;
                }
                _assemblyTitle = _assemblyReader.GetAssemblyProperty("AssemblyTitleAttribute");
                if (string.IsNullOrEmpty(_assemblyTitle))
                {
                    _assemblyTitle = "Unknown Application";
                }
                return _assemblyTitle;
            }
        }

        protected static string AssemblyCopyright
        {
            get
            {
                if (!string.IsNullOrEmpty(_assemblyCopyright))
                {
                    return _assemblyCopyright;
                }
                _assemblyCopyright = _assemblyReader.GetAssemblyProperty("AssemblyCopyrightAttribute");
                if (string.IsNullOrEmpty(_assemblyCopyright))
                {
                    _assemblyCopyright = "Unknown Copyright";
                }
                return _assemblyCopyright;
            }
        }

        protected static string AssemblyProduct
        {
            get
            {
                if (!string.IsNullOrEmpty(_assemblyProduct))
                {
                    return _assemblyProduct;
                }
                _assemblyProduct = _assemblyReader.GetAssemblyProperty("AssemblyProductAttribute");
                if (string.IsNullOrEmpty(_assemblyProduct))
                {
                    _assemblyProduct = "Unknown Product";
                }
                return _assemblyProduct;
            }
        }

        protected static string AssemblyCompany
        {
            get
            {
                if (!string.IsNullOrEmpty(_assemblyCompany))
                {
                    return _assemblyCompany;
                }
                _assemblyCompany = _assemblyReader.GetAssemblyProperty("AssemblyCompanyAttribute");
                if (string.IsNullOrEmpty(_assemblyCompany))
                {
                    _assemblyCompany = "Unknown Company";
                }
                return _assemblyCompany;
            }
        }

        protected static string AssemblyVersion
        {
            get
            {
                if (!string.IsNullOrEmpty(_assemblyVersion))
                {
                    return _assemblyVersion;
                }
                _assemblyVersion = _assemblyReader.GetAssemblyProperty("AssemblyVersionAttribute");
                if (string.IsNullOrEmpty(_assemblyVersion))
                {
                    _assemblyVersion = "Unknown Version";
                }
                return _assemblyVersion;
            }
        }

        protected static string[] ReferencedAssemblies
        {
            get
            {
                if (_referencedAssemblies == null || _referencedAssemblies.Length == 0)
                {
                    _referencedAssemblies = _assemblyReader.GetReferencedAssemblyNames();
                }
                return _referencedAssemblies;
            }
        }

        private void HelpFormBase_Load(object sender, System.EventArgs e)
        {
            // Set the icon to the owner windows icon.
            if (this.Owner != null)
            {
                this.Icon = this.Owner.Icon;
            }
            
            if (_assemblyReader == null)
            {
                _assemblyReader = this.Owner == null
                ? new AssemblyReader()
                : new AssemblyReader(this.Owner.GetType().Assembly);
            }
            this.ProductTitle.Text = AssemblyProduct;
        }

        private void _closeButton_Click(object sender, System.EventArgs e)
        {
            if (this._instance.Visible)
            {
                this._instance.Hide();
            }
        }
    }
}
