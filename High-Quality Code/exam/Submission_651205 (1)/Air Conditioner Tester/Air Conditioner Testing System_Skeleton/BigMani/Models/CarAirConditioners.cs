namespace BigMani.Models
{
    using System;

    public class CarAirConditioners
    {
        private string manufacturer;
        private string model;
        private int volumeCovered;

        public CarAirConditioners(string manufacturer, string model, int volumeCovered)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.VolumeCovered = volumeCovered;
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
    }
}