namespace CodeBlueDev.PluralSightDownloader.Infrastructure.WebSite
{
    using System;
    using System.IO;
    using System.Net;

    using Core;
    using Core.Domain;
    using Core.Domain.Models;

    using Newtonsoft.Json;

    public class PluralSightProvider : IPluralSightProvider
    {
        private const string LoginUrlBase = @"http://app.pluralsight.com/id?";

        private const string FindCoursesUrlBase = @"http://app.pluralsight.com/library/search?q=";

        private const string CourseDataUrlBase = 
            @"http://app.pluralsight.com/data/Course/";

        private const string CourseContentDataUrlBase = 
            @"http://app.pluralsight.com/data/Course/Content/";

        public PluralSightProvider()
        {
            
        }

        public bool Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public bool Login(string psmCookieValue)
        {
            throw new System.NotImplementedException();
        }

        public CourseContent GetCourseContent(string courseUrl)
        {
            try
            {
                return this.GetCourseContent(new Uri(courseUrl));
            }
            catch (UriFormatException)
            {
                throw new InvalidCourseUrlException("The format of the URL could not be determined.");
            }
        }

        public CourseContent GetCourseContent(Uri courseUrl)
        {
            string[] urlLocalPath = courseUrl.LocalPath.Split(
                new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (urlLocalPath.Length >= 2
                && urlLocalPath[0].Equals("courses", 
                    StringComparison.InvariantCultureIgnoreCase))
            {
                return this.GetCourseContentFromName(urlLocalPath[1]);
            }

            if (urlLocalPath.Length >= 3
                && urlLocalPath[0].Equals("library", 
                    StringComparison.InvariantCultureIgnoreCase)
                && urlLocalPath[1].Equals("courses", 
                    StringComparison.InvariantCultureIgnoreCase))
            {
                return this.GetCourseContentFromName(urlLocalPath[2]);
            }

            return null;
        }

        public CourseContent GetCourseContentFromName(string courseName)
        {
            // TODO: Try/Catch this?
            return new CourseContent()
            {
                Course = GetCourseData(courseName),
                Modules = this.GetCourseContentData(courseName),
            };
        }

        private static Course GetCourseData(string courseName)
        {
            try
            {
                WebRequest courseDataUrlWebRequest = 
                    WebRequest.Create($"{CourseDataUrlBase}{courseName}");

                using (WebResponse courseDataUrlWebResponse = 
                    courseDataUrlWebRequest.GetResponse())
                using (Stream courseDataUrlResponseStream = 
                    courseDataUrlWebResponse.GetResponseStream())
                using (StreamReader courseDataUrlResponseStreamReader = 
                    new StreamReader(courseDataUrlResponseStream))
                {
                    return JsonConvert.DeserializeObject<Course>(
                        courseDataUrlResponseStreamReader.ReadToEnd());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Module[] GetCourseContentData(string courseName)
        {
            try
            {
                WebRequest courseContentDataUrlWebRequest =
                    WebRequest.Create($"{CourseContentDataUrlBase}{courseName}");

                using (WebResponse courseContentDataUrlWebResponse =
                    courseContentDataUrlWebRequest.GetResponse())
                using (Stream courseContentDataUrlResponseStream =
                    courseContentDataUrlWebResponse.GetResponseStream())
                using (StreamReader courseContentDataUrlResponseStreamReader =
                    new StreamReader(courseContentDataUrlResponseStream))
                {
                    return JsonConvert.DeserializeObject<Module[]>(
                        courseContentDataUrlResponseStreamReader.ReadToEnd());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DownloadCourse(CourseContent courseContent)
        {
            throw new System.NotImplementedException();
        }

        public bool DownloadClip(string clipFileName, Clip clip)
        {
            throw new System.NotImplementedException();
        }
    }
}
