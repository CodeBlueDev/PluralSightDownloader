namespace CodeBlueDev.PluralSightDownloader.Core
{
    public interface IPluralSightProvider
    {
        bool Login(string username, string password);

        bool Login(string psmCookieValue);

        Domain.Models.CourseContent GetCourseContent(string courseUrl);

        Domain.Models.CourseContent GetCourseContent(System.Uri courseUrl);

        Domain.Models.CourseContent GetCourseContentFromName(string courseName);

        bool DownloadClip(string clipFileName, Domain.Models.Clip clip);
    }
}