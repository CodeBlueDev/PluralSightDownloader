namespace CodeBlueDev.PluralSightDownloader.Core.Domain.Models
{
    using System;

    public class Course
    {
        public string Title { get; set; }

        public CourseLevel Level { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Name { get; set; }

        public Author[] Authors { get; set; }

        public bool HasTranscript { get; set; }

        public CourseRating CourseRating { get; set; }

        public bool IsRetired { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        //public bool IsBookmarked { get; set; }

        //public bool UserMaySaveCourse { get; set; }

        public string ReplacementCourseName { get; set; }

        public string RetiredReason { get; set; }

        public string ReplacementCourseTitle { get; set; }

        public bool IsValid { get; set; }

        public bool IsUserAuthorizedForTranscript { get; set; }
    }
}
