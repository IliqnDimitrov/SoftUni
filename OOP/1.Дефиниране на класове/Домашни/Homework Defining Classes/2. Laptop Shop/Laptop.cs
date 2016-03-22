using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery batteryLatop;
        private decimal price;


        public string Model 
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model cannot be empty");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be empty");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Processor cannot be empty");
                }
                this.processor = value;
            }
        }
        public int Ram 
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ram cannot be negative");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Graphics Card cannot be empty");
                }
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("HDD cannot be empty");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Screen cannot be empty");
                }
                this.screen = value;
            }
        }
        public Battery BatteryLaptop { get; set; }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            } 
        }


        public Laptop(string model, decimal price)
        {
            this.Model= model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer, Battery batteryLatop)
            :this(model,price)
        {
            this.Manufacturer = manufacturer;
            this.BatteryLaptop = batteryLatop;
        }
        public Laptop(string model, decimal price, string manufacturer, Battery batteryLatop, 
            string processor, int ram, string graphicsCard, string hdd, string screen) 
            :this(model,price,manufacturer,batteryLatop)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }



        public override string ToString()
        {
            string description = string.Format("Model: {0} \n",this.model);           
            if (!String.IsNullOrWhiteSpace(this.manufacturer))
            {
                description += string.Format("Manufacturer: {0} \n",this.manufacturer);
            }
            if (!String.IsNullOrWhiteSpace(this.processor))
            {
                description += string.Format("Processor: {0} \n", this.processor);
            }
            if (this.ram != 0)
            {
                description += string.Format("RAM: {0} Gb \n",this.ram);
            }
            if (!String.IsNullOrWhiteSpace(this.graphicsCard))
            {
                description += string.Format("Graphic card: {0} \n", this.graphicsCard);
            }
            if (!String.IsNullOrWhiteSpace(this.hdd))
            {
                description += string.Format("HDD: {0} \n",this.hdd);
            }
            if (!String.IsNullOrWhiteSpace(this.screen))
            {
                description += string.Format("Screen: {0} \n",this.screen);
            }
            if (this.BatteryLaptop != null)
            {
                description += string.Format("Battery: {0} \n",BatteryLaptop.BatteryDescription);
                description += string.Format("Battery: {0} hours \n", BatteryLaptop.BatteryLife);
            }
            description += string.Format("Price: {0:F2} lv.",this.price);
            return description;
        }
        
    }
}
