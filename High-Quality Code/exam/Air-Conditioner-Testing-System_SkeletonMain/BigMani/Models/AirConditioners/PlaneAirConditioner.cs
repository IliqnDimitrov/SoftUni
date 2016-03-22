namespace ACTester.Models
{
    using System;
    using System.Text;

    public class PlaneAirConditioner : AirConditionerBase
    {
        private const int MinPlaneElectricity = 150;

        private int volumeCovered;
        private int electricityUsed;

        public PlaneAirConditioner(string manufacturer, string model,int volumeCovered, int electricityUsed)
            : base(manufacturer, model)
        {
            this.VolumeCovered = volumeCovered;
            this.ElectricityUsed = electricityUsed;
            this.Type = "plane";
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

        public int ElectricityUsed
        {
            get
            {
                return this.electricityUsed;
            }

            set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Electricity Used must be a positive integer.");
                }

                this.electricityUsed = value;
            }
        }

        public override bool Test()
        {
            double sqrtVolume = Math.Sqrt(volumeCovered);
            if (this.ElectricityUsed / sqrtVolume < MinPlaneElectricity)
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
                      $"Electricity Used: {this.ElectricityUsed}\n" +
                      $"====================\n");

            return sb.ToString();
        }
    }
}
