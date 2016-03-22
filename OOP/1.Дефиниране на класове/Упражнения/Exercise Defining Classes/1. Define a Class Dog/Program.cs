using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Define_a_Class_Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
