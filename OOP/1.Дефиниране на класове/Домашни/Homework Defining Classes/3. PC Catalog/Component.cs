using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Details cannot be empty");
                }
                this.details = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be negative");
                }
                this.price= value;
            }
        }


        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name, decimal price, string details)
            :this(name,price)
        {
            this.Details = details;
        }

        public override string ToString()
        {
            string component = string.Format("{0}",this.name);
            if (!String.IsNullOrWhiteSpace(this.details))
            {
                component += string.Format(" ({0})",this.details);
            }
            component += string.Format(" {0} lv.", this.price);
            return component;
        }

    }
}
