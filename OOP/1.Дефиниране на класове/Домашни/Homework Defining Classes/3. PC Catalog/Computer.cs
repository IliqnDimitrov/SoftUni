using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
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
        public Component Components { get; set; }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be negative");
                }
                this.price = value;
            }
        }


        public Computer(string name, List<Component>components)
        {
            this.Name = name;
            this.components = components;
            this.Price = Calculate(this.components);
        }

        private decimal Calculate(List<Component> comps)
        {
            decimal totalPrice = 0m;
            foreach (Component comp in comps)
            {
                totalPrice += comp.Price;
            }
            return totalPrice;
        }

        public void PrintPC()
        {
            string PC = string.Format("PC name: {0} \n",this.name);
            foreach (Component component in this.components)
            {
                PC += string.Format(component + "\n");
            }
            PC += string.Format("Total price: {0} lv.", this.price);
            Console.WriteLine(PC);
        }
    }
}
