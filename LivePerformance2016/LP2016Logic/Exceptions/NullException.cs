using System;

namespace LP2016Logic.Exceptions
{
    /// <summary>
    /// Exception for objects that are null or empty.
    /// </summary>
    public class NullException : Exception
    {
        public NullException(string message) : base(message)
        {
            
        }
    }
}
