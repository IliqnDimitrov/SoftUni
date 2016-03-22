namespace ACTester.Models
{
    using System;
    using System.Text;
    using Interfaces;

    public abstract class AirConditionerBase : IAirConditioner
    {     
        private string manufacturer;
        private string model;
        private string mark;

        protected AirConditionerBase(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Mark = "Failed";
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value.Length < 4)
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

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model's name must be at least 2 symbols long.");
                }

                this.model = value;
            }
        }

        public string Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value),"Mark cannot be null.");
                }

                this.mark = value;
            }
        }

        public virtual string Type { get; set; }

        public abstract bool Test();

        public abstract bool IsPassed();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Air Conditioner\n" +
                      $"====================\n" +
                      $"Manufacturer: {this.Manufacturer}\n" +
                      $"Model: {this.Model}\n");

            return sb.ToString();
        }
    }
}
