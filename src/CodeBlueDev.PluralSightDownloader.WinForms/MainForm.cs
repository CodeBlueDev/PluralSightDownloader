namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    using CodeBlueDev.PluralSightDownloader.Core.Domain;

    using Core;
    using Core.Domain.Models;
    using Infrastructure.WebSite;

    using ViewModels;

    public partial class MainForm : Form
    {
        private readonly BindingList<DownloadDataGridViewCourseViewModel> addedCourses;
        private readonly IPluralSightProvider pluralSightProvider;
        private readonly PreferencesForm preferencesForm;

        // TODO: Make these localizable string resources
        private const string DefaultEmptyAddPluralSightCourseByUrlErrorMessage = "PluralSight Course Url Must Be Provided...";
        private const string DefaultInvalidAddPluralSightCourseByUrlErrorMessage = "Invalid PluralSight Course Url";

        public MainForm()
        {
            // TODO: Make the constructor take the configuration file?
            this.pluralSightProvider = new PluralSightProvider();
            this.preferencesForm = new PreferencesForm();
            this.InitializePreferencesFormEvents();

            this.InitializeComponent();

            // TODO: Remove this when ready.
            this._pluralSightDownloaderTabControl.TabPages.Remove(
                this._libraryTabPage);

            this.InitializeToolStripRenderers();

            this.addedCourses = 
                new BindingList<DownloadDataGridViewCourseViewModel>();
            this._addedCoursesDownloadDataGridView.DataSource = 
                this.addedCourses;

            this._statusToolStripStatusLabel.Text = string.Empty;
        }

        private void InitializePreferencesFormEvents()
        {
            // TODO: Tie up the events to save the configuration from here.
            this.preferencesForm.Closing += 
                this.PreferencesFormOnClosing;
        }

        private void InitializeToolStripRenderers()
        {
            // TODO: Play with these by making my own.
            this._mainMenuStrip.Renderer = 
                new ToolStripProfessionalRenderer();
            this._mainToolStrip.Renderer = 
                new ToolStripProfessionalRenderer();
            this._mainStatusStrip.Renderer = 
                new ToolStripSystemRenderer();
        }

        #region Preferences Form Events

        private void PreferencesFormOnClosing(
            object sender, CancelEventArgs cancelEventArgs)
        {
            // TODO: Check and validate configuration changes.
        }

        #endregion Preferences Form Events

        #region Main Form Events

        private void MainFormOnLoad(object sender, EventArgs e)
        {
            // TODO: Read the configuration/added courses.
        }

        private void MainFormOnFormClosing(
            object sender, FormClosingEventArgs e)
        {
            // TODO: Check if the user has something active, save stuff, close everything down.
        }

        private void MainFormOnFormClosed(
            object sender, FormClosedEventArgs e)
        {

        }

        private void AddPluralSightCourseByUrlOnClick(
            object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(
            //    this._addPluralSightCourseByUrlTextBox.Text))
            //{
            //    this._pluralSightDownloaderErrorProvider.SetError(
            //        this._addPluralSightCourseByUrlTextBox,
            //        DefaultEmptyAddPluralSightCourseByUrlErrorMessage);
            //    return;
            //}

            //CourseContent courseContent = null;
            //string errorMessage = string.Empty;

            //try
            //{
            //    courseContent =
            //        this.pluralSightProvider.GetCourseContent(
            //            this._addPluralSightCourseByUrlTextBox.Text);
            //}
            //catch (InvalidCourseUrlException invalidCourseUrlException)
            //{
            //    if (!string.IsNullOrEmpty(invalidCourseUrlException.Message))
            //    {
            //        errorMessage = invalidCourseUrlException.Message;
            //    }
            //}
            
            //if (courseContent?.Course == null || 
            //    !courseContent.Course.IsValid ||
            //    courseContent.Modules == null)
            //{
            //    this._pluralSightDownloaderErrorProvider.SetError(
            //        this._addPluralSightCourseByUrlTextBox,
            //        $"{DefaultInvalidAddPluralSightCourseByUrlErrorMessage}{(!string.IsNullOrEmpty(errorMessage) ? $": {errorMessage}" : "...")}");
            //    return;
            //}

            //this._pluralSightDownloaderErrorProvider.SetError(
            //    this._addPluralSightCourseByUrlTextBox,
            //    string.Empty);

            //this.AddPluralSightCourse(courseContent);
            //this._addPluralSightCourseByUrlTextBox.Text = string.Empty;
        }

        private void FindPluralSightCourseOnClick(
            object sender, EventArgs e)
        {
            MessageBox.Show("Still in development...");
        }

        private void AddPluralSightCourse(CourseContent courseContent)
        {
            AddCourseForm addCourseForm = new AddCourseForm(courseContent);
            if (addCourseForm.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            this.addedCourses.Add(new DownloadDataGridViewCourseViewModel()
            {
                Title = $"{this.addedCourses.Count + 1} Course"
            });
        }

        private void ExitOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPreferencesDialogOnClick(
            object sender, EventArgs e)
        {
            // TODO: Alter this to have the preferences object.
            this.preferencesForm.ShowDialog(this);
        }

        private void ShowAboutFormDialogOnClick(
            object sender, EventArgs e)
        {
            AboutForm.ShowAboutFormDialog(this);
        }

        private void ShowLicenseFormDialogOnClick(
            object sender, EventArgs e)
        {
            LicenseForm.ShowLicenseFormDialog(this);
        }

        #endregion Main Form Events
    }
}
