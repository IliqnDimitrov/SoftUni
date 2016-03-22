using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPH = weekSalary / 7;
            moneyPH = moneyPH / workHoursPerDay;       
            return moneyPH;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} earns {2:F2} lv. per hour", this.FirstName, this.LastName, MoneyPerHour());
        }
    }
}
