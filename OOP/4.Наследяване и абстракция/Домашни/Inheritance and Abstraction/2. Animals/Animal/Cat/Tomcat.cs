using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Animal.Cat
{
    public class Tomcat : Cat
    {
        private static readonly string gender = "Male";

        public Tomcat(string name, int age)
            :base(name,age,gender)
        {

        }

        
    }
}
