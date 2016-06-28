namespace CodeBlueDev.PluralSightDownloader.Core.Domain
{
    using System;
    using System.Runtime.Serialization;

    public class InvalidCourseUrlException : SystemException
    {
        private const string DefaultInvalidCourseUrlException = "Invalid Course Url";

        public InvalidCourseUrlException() : this(DefaultInvalidCourseUrlException)
        { }

        public InvalidCourseUrlException(string message) : base(message)
        { }

        public InvalidCourseUrlException(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected InvalidCourseUrlException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { }
    }
}
