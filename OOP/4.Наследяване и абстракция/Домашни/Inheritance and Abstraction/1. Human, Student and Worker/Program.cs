using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _1.Human__Student_and_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Pesho = new Student("Pesho", "Mitev", 6111884);
            Student Gosho = new Student("Gosho", "Radoev", 8451235);
            Student Teodora = new Student("Teodora", "Koleva", 4589767);
            Student Valio = new Student("Valio", "Georgiev", 2567892);
            Student Dragomir = new Student("Dragomir", "Dragoev", 6841457);
            Student Mariq = new Student("Mariq", "Koleva", 1479851);
            Student Mihail = new Student("Mihail", "Petrov", 4889978);
            Student Anton = new Student("Anton", "Mihalev", 1235465);
            Student Dimitar = new Student("Dimitar", "Todorov", 1569875);
            Student Dilqna = new Student("Dilqna", "Stefanova", 4818975);

            List<Student> studenti = new List<Student>()
            {
                Pesho,Gosho,Teodora,Valio,Dragomir,Mariq,Mihail,Anton,Dimitar,Dilqna
            };

            Console.WriteLine("Sorted students by faculty number:");
            List<Student> sortStudenti = studenti.OrderBy(s => s.FacultyNumber).ToList();
            foreach (Student item in sortStudenti)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Worker baiIvan = new Worker("Bai", "Ivan", 100, 8);
            Worker Kolio = new Worker("Kolio", "Mamata", 80, 7);
            Worker Lubo = new Worker("Lubo", "Petrov", 120, 6);
            Worker Hari = new Worker("Hary", "Potter", 1000, 3);
            Worker Vesko = new Worker("Vesko", "Marinov", 10000, 2);
            Worker Ronaldo = new Worker("Cristiano", "Ronaldo", 70000, 4);
            Worker Penka = new Worker("Penka", "Demirova", 300, 8);
            Worker Volen = new Worker("Volen", "Siderov", 15000, 4);
            Worker Krasi = new Worker("Shisho", "Bakshiso", 2000, 3);
            Worker John = new Worker("John", "Travolta", 20000, 3);
            List<Worker> rabotnici = new List<Worker>()
            {
                baiIvan,Kolio,Lubo,Hari,Vesko,Ronaldo,Penka,Volen,Krasi,John
            };
            Console.WriteLine("Sorted workers by money per hour:");
            List<Worker> sortWorkers = rabotnici.OrderBy(r => r.MoneyPerHour()).ToList();
            foreach (var items in sortWorkers)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Sorted by First name:");
            List<Human> All = new List<Human>();
            for (int i = 0; i < studenti.Count; i++)
            {
                All.Add(studenti[i]);
            }
            for (int i = 0; i < rabotnici.Count; i++)
            {
                All.Add(rabotnici[i]);
            }
            All = All.OrderBy(f => f.FirstName).ToList();
            foreach (var item in All)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Sorted by Last name:");
            All = All.OrderBy(f => f.LastName).ToList();
            foreach (var item in All)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }
        }
    }
}
