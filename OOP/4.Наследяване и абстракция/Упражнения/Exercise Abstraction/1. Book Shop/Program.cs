using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Book_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            Console.WriteLine(book);
            Console.WriteLine();
            Console.WriteLine(new string('-',50));
            Console.WriteLine();
            GoldenEditionBook book1 = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);
            Console.WriteLine(book1);
        }
    }
}
