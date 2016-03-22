namespace ACTester.UI
{
    using System;
    using Interfaces;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();

            return line;
        }
    }
}