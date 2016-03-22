using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals.Animal;

namespace _2.Animals.Animal
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            :base(name,age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0}(dog): Bark Barkkkk",this.Name);
        }
    }
}
