namespace CodeBlueDev.PluralSightDownloader.Core.Domain.Models
{
    using System;

    public class Clip
    {
        // TODO: Transcripts - []

        public int ClipIndex { get; set; }

        public bool HasBeenViewed { get; set; }

        public TimeSpan Duration { get; set; }

        public string PlayerParameters { get; set; }

        public bool UserMayViewClip { get; set; }

        //public string ClickActionDescription { get; set; }

        // Referenced in a search
        //public bool IsHighlighted { get; set; }

        public string Name { get; set; }

        //public bool IsBookmarked { get; set; }

        //public string HasBeenViewedImageUrl { get; set; }

        //public string HasBeenViewedAltText { get; set; }
    }
}
