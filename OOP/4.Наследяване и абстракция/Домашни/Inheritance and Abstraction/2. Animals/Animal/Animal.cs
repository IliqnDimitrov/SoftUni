using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals.Interface;

namespace _2.Animals.Animal
{
    abstract public class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gender cannot be empty");
                }
                this.gender = value;
            }
        }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Name, this.Age, this.Gender);
        }
        public abstract void ProduceSound();
    }
}
