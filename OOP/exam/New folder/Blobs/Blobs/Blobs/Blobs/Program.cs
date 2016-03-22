using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core;
using Blobs.IO;

namespace Blobs
{
    class Program
    {
        static void Main(string[] args)
        {
            var blobFactory = new Factory();
            var data = new Data();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
           Engine xaxa = new Engine(blobFactory,data,reader,writer);
            xaxa.Run();
        }
    }
}
