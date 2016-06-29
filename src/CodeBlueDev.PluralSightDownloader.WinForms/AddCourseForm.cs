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
            base.Text = this.courseContent.Course.Title;

            this._courseLevelValueLabel.Text = this.courseContent.Course.Level.ToString();
            this._courseRatingValueLabel.Text =
                $"{this.courseContent.Course.CourseRating.AverageRating}/5.0 ({this.courseContent.Course.CourseRating.NumberOfRaters})";
            this._courseDurationValueLabel.Text = 
                $"{this.courseContent.Course.Duration.Hours}h {this.courseContent.Course.Duration.Minutes}m";
            this._courseReleaseDateValueLabel.Text = this.courseContent.Course.ReleaseDate.ToString("dd MMM yyyy");

            this._authorDescriptionLabel.Text = this.courseContent.Course.Authors.Length > 1 
                ? "Authors:" 
                : "Author:";
            foreach (Author author in this.courseContent.Course.Authors)
            {
                this._authorsListBox.Items.Add($"{author.LastName}, {author.FirstName}");
            }

            this._shortDescriptionTextBox.Text = this.courseContent.Course.ShortDescription;
            this._courseDescriptionTextBox.Text = this.courseContent.Course.Description;
        }
    }
}
