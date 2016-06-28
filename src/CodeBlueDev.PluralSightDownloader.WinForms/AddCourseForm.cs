namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System.Linq;
    using System.Windows.Forms;

    using Core.Domain.Models;

    public partial class AddCourseForm : Form
    {
        private readonly CourseContent courseContent;

        public AddCourseForm(CourseContent courseContent)
        {
            this.courseContent = courseContent;

            this.InitializeComponent();
        }

        private void AddCourseFormOnLoad(object sender, System.EventArgs e)
        {
            this._courseTitleLabel.Text = this.courseContent.Course.Title;

            Author author = this.courseContent.Course.Authors.FirstOrDefault();
            if (author == null)
            {
                this._primaryAuthorLabel.Visible = false;
            }
            else
            {
                this._primaryAuthorLabel.Visible = true;
                this._primaryAuthorLabel.Text = $"by {author.FirstName} {author.LastName}";
            }

            this._shortDescriptionLabel.Text = this.courseContent.Course.ShortDescription;
        }
    }
}
