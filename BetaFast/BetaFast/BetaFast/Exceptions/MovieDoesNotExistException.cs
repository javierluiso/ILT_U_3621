using System;

namespace ILTU3621.Exceptions
{
    [Serializable]
    public class MovieDoesNotExistException : Exception
    {
        public MovieDoesNotExistException()
        {
        }

        public MovieDoesNotExistException(string message)
            : base(message)
        {
        }

        public MovieDoesNotExistException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
