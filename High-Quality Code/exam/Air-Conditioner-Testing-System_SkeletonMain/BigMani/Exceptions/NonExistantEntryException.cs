namespace ACTester.Exceptions
{
    using System;

    public class NonExistantEntryException : NullReferenceException
    {
        public NonExistantEntryException(string message) 
            : base(message)
        {
        }
    }
}
