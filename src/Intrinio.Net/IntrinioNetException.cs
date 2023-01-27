using System;
using System.Net;
using System.Runtime.Serialization;

namespace Intrinio.Net
{
    [Serializable]
    public class IntrinioNetException : Exception
    {
        public HttpStatusCode StatusCode { get; protected set; }

        public IntrinioNetException()
        {
        }

        public IntrinioNetException(string message)
            : base(message)
        {
        }

        public IntrinioNetException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public IntrinioNetException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            StatusCode= statusCode;
        }

        protected IntrinioNetException(SerializationInfo serializationInfo, StreamingContext streamingContext)
                : base(serializationInfo, streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
