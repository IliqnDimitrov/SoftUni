using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;

namespace _3.Company_Hierarchy
{
    class Project : IProject
    {
        private const string DefaultProjectState = "open";
        private string name;
        private DateTime startDate;
        private string details;

        public Project(string name, DateTime startDate, string details)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = DefaultProjectState;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty.");
                }
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Product name shoud be in range [2 ... 20].");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if (value.Year < 0)
                {
                    throw new ArgumentException("Year cannot be negative.");
                }

                this.startDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty.");
                }
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Product name shoud be in range [2 ... 50].");
                }

                this.details = value;
            }
        }

        public string State { get; private set; }

        public void CloseProject()
        {
            this.State = "closed";
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("- Project: {0} \n\r  Start Date: {1} \n\r  State: {2} \n\r  Details: {3}", this.Name, this.StartDate.Date, this.State, this.Details);
            return print.ToString();
        }
    }
}
