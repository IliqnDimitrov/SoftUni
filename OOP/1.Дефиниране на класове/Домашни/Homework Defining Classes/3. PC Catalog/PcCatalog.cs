using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class PcCatalog
    {
        static void Main(string[] args)
        {
            Component dyno = new Component("Motherboard", 56m,"Asus");
            Component hdd = new Component("SSD Seagate", 130m,"128gb");
            Component hdd2 = new Component("SSD Seagate", 280m, "256gb");
            Component hdd3 = new Component("HDD Hitachi", 120m, "1TB");
            Component procesor = new Component("processor", 320m, "intel i5-4460");
            Component procesor2 = new Component("processor", 216m, "intel i3-4170");
            Component procesor3 = new Component("processor", 869m, "intel i7-4790K");
            Component videoCard = new Component("Graphic card", 66m, "Ati Radeon 5490");
            Component videoCard2 = new Component("Graphic card", 199m, "Ati R7 250");
            Component videoCard3 = new Component("Graphic card", 144m, "Nvidia GT 730");
            List<Component> components1 = new List<Component>()
            {
                dyno, hdd, procesor, videoCard
            };
            List<Component> components2 = new List<Component>()
            {
                dyno, hdd2, procesor2, videoCard2
            };
            List<Component> components3 = new List<Component>()
            {
                dyno, hdd3, procesor3, videoCard3
            };

            Computer PC = new Computer("Asus",components1);
            Computer PC2 = new Computer("HP", components2);
            Computer PC3 = new Computer("Samsung", components3);

            List<Computer> PCs = new List<Computer>()
            {
                PC,PC2,PC3
            };

            List<Computer> sortPC = PCs.OrderBy(Computer => Computer.Price).ToList();
            foreach (Computer sortedPC in sortPC)
            {
                sortedPC.PrintPC();
                Console.WriteLine();
            }
        }
    }
}
