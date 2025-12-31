using System;

namespace ConsoleApp1.Exceptions
{
    public class InvalidStudentException : Exception
    {
        public InvalidStudentException(string message) : base(message) { }
    }
}
