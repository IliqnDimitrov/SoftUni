using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class Battery
    {
        private string batteryDescription;
        private double batteryLife;

        public Battery(string batteryDescription, double batteryLife)
        {
            this.BatteryDescription = batteryDescription;
            this.BatteryLife = batteryLife;
        }
        
        public string BatteryDescription 
        {
            get { return this.batteryDescription; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Battery description cannot be empty");
                }
                this.batteryDescription = value;
            }
        }

        public double BatteryLife 
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("value must be >0");
                }
                this.batteryLife = value;
            }
        }

    }
}
