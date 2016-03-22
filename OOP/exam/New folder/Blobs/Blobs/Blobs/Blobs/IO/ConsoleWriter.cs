using System;
using Blobs.Interfaces;

namespace Blobs.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}