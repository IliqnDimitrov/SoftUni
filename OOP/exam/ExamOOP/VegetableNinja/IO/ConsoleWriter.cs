using System;
using VegetableNinja.Interfaces;

namespace VegetableNinja.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}