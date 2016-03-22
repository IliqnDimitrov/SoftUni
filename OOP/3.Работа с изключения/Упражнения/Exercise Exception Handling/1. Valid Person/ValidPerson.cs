using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Valid_Person
{
    class ValidPerson
    {
        static void Main(string[] args)
        {
            //Person pesho = new Person("Pesho", "Pashev", 24);
            //Person noName = new Person(string.Empty, "Goshev", 31);
            //Person negativeAge = new Person("Stoyan", "Kolev", -1);
            //Person tooOld = new Person("Iskren", "Ivanov", 121);
            try
            {
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}",ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
        }
    }
}
