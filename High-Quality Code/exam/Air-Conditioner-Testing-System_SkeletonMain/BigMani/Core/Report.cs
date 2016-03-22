namespace ACTester.Core
{
    using System.Text;
    using Interfaces;

    public class Report : IReport
    {
        private string manufacturer;
        private string model;
        private string mark;

        public Report(string manufacturer,string model,string mark)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Mark = mark;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }     

        public string Mark { get; set; }

        public bool IsPassed { get; set; }

        public override string ToString()
        {
          var sb = new StringBuilder();
            sb.Append($"Report" +
                      $"\n====================" +
                      $"\nManufacturer: {this.Manufacturer}" +
                      $"\nModel: {this.Model}" +
                      $"\nMark: {this.Mark}" +
                      $"\n====================");

            return sb.ToString();
        }
    }
}
