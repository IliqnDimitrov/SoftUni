namespace BigMani.Models
{
    using System;
    using System.Runtime.InteropServices;
    
    public class StationaryAirConditioners
    {
        private string manufacturer;
        private string model;
        private int powerUsage;
        private string requiredEnergyEfficiencyRating;

        public StationaryAirConditioners(string manufacturer, string model, string requiredEnergyEfficiencyRating, int powerUsage)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.RequiredEnergyEfficiencyRating = requiredEnergyEfficiencyRating;
            this.PowerUsage = powerUsage;
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Manufacturer's name must be at least 4 symbols long.");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Model's name must be at least 2 symbols long.");
                }

                this.model = value;
            }
        }

        public int PowerUsage
        {
            get
            {
                return this.powerUsage;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Power Usage must be a positive integer.");
                }

                this.powerUsage = value; 
            }
        }

        public string RequiredEnergyEfficiencyRating
        {
            get
            {
                return this.requiredEnergyEfficiencyRating;
            }

            private set
            {
                switch (value)
                {
                    case "A":
                        value = "A";
                        break;
                    case "B":
                        value = "B";
                        break;
                    case "C":
                        value = "C";
                        break;
                    case "D":
                        value = "D";
                        break;
                    case "E":
                        value = "E";
                        break;
                    default:
                        throw new ArgumentException("Energy efficiency rating must be between \"A\" and \"E\".");
                }

                this.requiredEnergyEfficiencyRating = value;      
            }
        }
    }
}