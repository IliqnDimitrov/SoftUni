namespace BigMani.Files
{
    using System;
    using System.Text;
    using BigMani.IO;

    public class Report
    {
        public Report(string manufacturer, string model, int mark)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Mark = mark;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Mark { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            if (this.Mark == 0)
            {
                result = "Failed";
            }
            else if (this.Mark == 1)
            {
                result = "Passed";
            }

            result += "Report" + "\r\n" + "====================" + "\r\n" + "Manufacturer: " + this.Manufacturer + "\r\n" +
                      "Model: " + this.Model + "\r\n" + "Mark: " + result + "\r\n" + "====================";

            new ConsoleWriter().WriteLine(result);
            return result;
        }
    }
}
