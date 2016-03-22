using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals.Animal.Cat;
using _2.Animals.Animal;


namespace _2.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitten Lora = new Kitten("Lora", 5);
            Cat pishtova = new Cat("Pishtova",8,"male");
            Tomcat Max = new Tomcat("Max", 8);
            Kitten hana = new Kitten("Hana", 4);
            List<Cat> sortCats = new List<Cat>()
            {
                Lora,pishtova,Max,hana
            };
            double avarageCat = sortCats.Average(c => c.Age);
            Frog djaro = new Frog("Djaro", 5, "male");
            Frog misho = new Frog("Misho", 2, "male");
            Frog shano = new Frog("Shano", 3, "male");
            Frog penka = new Frog("Penka", 9, "female");
            List<Frog> sortFrog = new List<Frog>()
            {
                djaro,misho,shano,penka
            };
            double avarageFrog = sortFrog.Average(f => f.Age);
            Dog Rex = new Dog("Rex", 9, "male");
            Dog Roni = new Dog("Roni", 1, "male");
            Dog Sara = new Dog("Sara", 5, "female");
            Dog hera = new Dog("Hera", 3, "female");
            List<Dog> sortDogs = new List<Dog>()
            {
                Rex,Roni,Sara,hera
            };
            double avarageDog = sortDogs.Average(d => d.Age);
            Console.WriteLine("Cats avarage age: {0}",avarageCat);
            Console.WriteLine("Frogs avarage age: {0}",avarageFrog);
            Console.WriteLine("Dogs avarage age: {0}",avarageDog);
            Console.WriteLine(new string('-',50));
            djaro.ProduceSound();
            Rex.ProduceSound();
            Max.ProduceSound();

        }
    }
}
