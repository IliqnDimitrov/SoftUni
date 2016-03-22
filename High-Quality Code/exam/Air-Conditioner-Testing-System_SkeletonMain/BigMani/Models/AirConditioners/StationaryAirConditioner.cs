namespace ACTester.Models
{
    using System.Text;
    using System;

    public class StationaryAirConditioner : AirConditionerBase
    {
        private int powerUsage;
        private char energyRating;

        public StationaryAirConditioner(string manufacturer, string model,char energyRating,int powerUsage) 
            : base(manufacturer, model)
        {
            this.PowerUsage = powerUsage;
            this.EnergyRating = energyRating;
            this.Type = "stationary";
        }

        public char EnergyRating
        {
            get
            {
                return this.energyRating;
            }

            set
            {
                if (value != 'A' && value != 'B' && value != 'C' && value != 'D' && value != 'E')
                {
                    throw new ArgumentException("Energy efficiency rating must be between \"A\" and \"E\".");
                }

                this.energyRating = value;
            }
        }

        public int PowerUsage
        {
            get
            {
                return this.powerUsage;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Power Usage must be a positive integer.");
                }

                this.powerUsage = value;
            }
        }

        public override bool Test()
        {
            if (this.PowerUsage / 100 <= energyRating)
            {
                return true;
            }

            return false;
        }

        public override bool IsPassed()
        {
            if (Test())
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Required energy efficiency rating: {this.EnergyRating}\n" +
                      $"Power Usage(KW / h): {this.PowerUsage}\n" +
                      $"====================\n");

            return sb.ToString();
        }
    }
}