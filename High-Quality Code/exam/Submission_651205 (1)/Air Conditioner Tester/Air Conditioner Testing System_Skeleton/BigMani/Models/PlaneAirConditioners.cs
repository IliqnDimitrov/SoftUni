namespace BigMani.Models
{
    using System;

    public class PlaneAirConditioners
    {
        private string manufacturer;
        private string model;
        private int volumeCovered;
        private int electricityUsed;

        public PlaneAirConditioners(string manufacturer, string model, int volumeCovered, int electricityUsed)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.VolumeCovered = volumeCovered;
            this.ElectricityUsed = electricityUsed;
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

            private 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Model's name must be at least 2 symbols long.");
                }
                
                this.model = value;          
            }
        }

        public int VolumeCovered
        {
            get
            {
                return this.volumeCovered;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Volume Covered must be a positive integer.");
                }

                this.volumeCovered = value;              
            }
        }

        public int ElectricityUsed
        {
            get
            {
                return this.electricityUsed;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Electricity Used must be a positive integer.");
                }

                this.electricityUsed = value;
            }
        }
    }
}