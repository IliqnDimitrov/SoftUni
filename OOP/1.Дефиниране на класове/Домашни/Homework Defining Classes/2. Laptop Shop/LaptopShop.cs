using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop two = new Laptop("HP proBook", 799m);
            Console.WriteLine(two);
            Console.WriteLine();
            Console.WriteLine(new string('-',70));
            Console.WriteLine();
            Laptop one = new Laptop("Lenovo Yoga 2 Pro", 2259.00m, "Lenovo", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Console.WriteLine(one);
        }
    }
}

