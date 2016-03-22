using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Working_with_Abstraction.Characters;
using _2.Working_with_Abstraction;
using _2.Working_with_Abstraction.Interfaces;

namespace _2.Working_with_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior petyr = new Warrior();
            Mage goshu = new Mage();
            Priest dancho = new Priest();
            Console.WriteLine(goshu.Health);
            petyr.Attack(goshu);
            Console.WriteLine(goshu.Health);
            dancho.Heal(goshu);
            Console.WriteLine(goshu.Health);
            petyr.Attack(goshu);
            Console.WriteLine(goshu.Health);
            petyr.Attack(goshu);
            Console.WriteLine(goshu.Health);
        }
    }
}
