namespace BigMani.IO
{
    using System;
    using BigMani.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}