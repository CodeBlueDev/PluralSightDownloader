namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddCourseByUrlForm : Form
    {

        public AddCourseByUrlForm()
        {
            this.InitializeComponent();
        }

        public string[] CourseUrls => this._coursesToAddTextBox.Text.Split(
            new[] { Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries)
            .Distinct().ToArray();
    }
}
