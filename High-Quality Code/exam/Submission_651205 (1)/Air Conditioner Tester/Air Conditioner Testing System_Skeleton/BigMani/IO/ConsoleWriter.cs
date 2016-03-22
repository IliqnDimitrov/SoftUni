namespace BigMani.IO
{
    using System;
    using BigMani.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}