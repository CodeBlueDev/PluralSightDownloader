namespace CodeBlueDev.PluralSightDownloader.Core.Domain.Models
{
    using System;

    public class Module
    {
        public bool UserMayViewFirstClip { get; set; }

        public string ModuleRef { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public TimeSpan Duration { get; set; }

        //public bool HasBeenViewed { get; set; }

        //public bool IsHighlighted { get; set; }

        public string FragementIdentifier { get; set; }

        public string FirstClipLaunchClickHandler { get; set; }

        //public bool UserMayBookmark { get; set; }

        //public bool IsBookmarked { get; set; }

        public Clip[] Clips { get; set; }

        //public string HasBeenViewedImageUrl { get; set; }

        //public string HasBeenViewedAltText { get; set; }
    }
}
