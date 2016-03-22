using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core;
using Empires.Core.Factories;
using Empires.IO;

namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresData();

            var one = new Engine(buildingFactory,resourceFactory,unitFactory,data,reader,writer);
            one.Run();
        }
    }
}
