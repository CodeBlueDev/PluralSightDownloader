namespace CodeBlueDev.PluralSightDownloader.Core.Domain.Models
{
    using System;

    public class CourseRating
    {
        //public int CurrentUsersRating { get; set; }

        public decimal AverageRating { get; set; }

        public decimal Rating { get; set; }

        //public bool CanRateThisCourse { get; set; }

        //public string CourseName { get; set; }

        public int NumberOfRaters { get; set; }

        //public bool HasUserRatedCourse { get; set; }
    }
}
