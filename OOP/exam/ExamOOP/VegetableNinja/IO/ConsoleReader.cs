using System;
using VegetableNinja.Interfaces;

namespace VegetableNinja.IO
{
    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}