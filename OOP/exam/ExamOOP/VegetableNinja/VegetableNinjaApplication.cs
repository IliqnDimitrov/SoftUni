using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableNinja.Core;
using VegetableNinja.IO;
using VegetableNinja.Models.Vegetables;

namespace VegetableNinja
{
    class VegetableNinjaApplication
    {
        static void Main(string[] args)
        {
            var ninjaFactory = new NinjaFactory();
            var data = new Data();
            var fieldFactory = new FieldFactory();
            var inputReader = new ConsoleReader();
            var inputWriter = new ConsoleWriter();
            Engine start = new Engine(ninjaFactory, data, fieldFactory, inputReader, inputWriter);
            start.Run();
        }
    }
}
