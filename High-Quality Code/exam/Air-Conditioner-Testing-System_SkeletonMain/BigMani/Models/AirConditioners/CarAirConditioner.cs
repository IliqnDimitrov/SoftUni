using System.Text;

namespace ACTester.Models
{
    using System;

    public class CarAirConditioner : AirConditionerBase
    {
        private int volumeCovered;

        public CarAirConditioner(string manufacturer, string model, int volumeCovered)
            : base(manufacturer, model)
        {
            this.VolumeCovered = volumeCovered;
            this.Type = "car";
        }

        public int VolumeCovered
        {
            get
            {
                return this.volumeCovered;
            }

            set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Volume Covered must be a positive integer.");
                }

                this.volumeCovered = value;
            }
        }

        public override bool Test()
        {
            double sqrtVolume = Math.Sqrt(volumeCovered);
            if (sqrtVolume < 3)
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
            sb.Append($"Volume Covered: {this.VolumeCovered}\n" +
                      $"====================\n");

            return sb.ToString();
        }
    }
}
