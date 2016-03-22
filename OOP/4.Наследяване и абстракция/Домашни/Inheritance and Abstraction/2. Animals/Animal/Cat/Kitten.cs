using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals;

namespace _2.Animals.Animal.Cat
{
    public class Kitten : Cat
    {
        private static readonly string gender = "Female";

        public Kitten(string name, int age)
            :base(name,age,gender)
        {
        }

       
    }
}
