using System;

namespace Rovers
{
    public enum Direction
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }

    public class IllegalArgumentException : Exception
    {
        public IllegalArgumentException() : base()
        {

        }

        public IllegalArgumentException(string message) : base(message)
        {

        }

        public IllegalArgumentException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}