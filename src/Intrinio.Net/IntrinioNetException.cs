using System;
using System.Runtime.Serialization;

namespace Intrinio.Net
{
    [Serializable]
    public class IntrinioNetException : Exception
    {
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

        protected IntrinioNetException(SerializationInfo serializationInfo, StreamingContext streamingContext)
                : base(serializationInfo, streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}