namespace BigMani.GoodStuff
{
    using System.Collections.Generic;
    using System.Linq;
    using BigMani.Exceptions;
    using BigMani.Files;

    public static class Database
    {
        static Database()
        {
            AirConditioners = new List<dynamic>();
            Reports = new List<Report>();
        }

        public static List<Report> Reports { get;  set; }
  
        internal static List<dynamic> AirConditioners { get; set; }

        public static void AddReport(Report report)
        {
            Reports.Add(report);
        }

        public static void RemoveReport(Report report)
        {
            Reports.Remove(report);
        }

        public static Report GetReport(string manufacturer, string model)
        {
            return Reports.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
        }

        public static int GetReportsCount()
        {
            return Reports.Count;
        }

        public static List<Report> GetReportsByManufacturer(string manufacturer)
        {
            return Reports.Where(x => x.Manufacturer == manufacturer).ToList();
        }

        internal static void AddAirConditioner(BlowWind airConditioner)
        {
            AirConditioners.Add(airConditioner);
        }

        internal static void RemoveAirConditioner(BlowWind airConditioner)
        {
            AirConditioners.Remove(airConditioner);
        }

        internal static BlowWind GetAirConditioner(string manufacturer, string model)
        {
            return AirConditioners.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
        }

        internal static int GetAirConditionersCount()
        {
            return AirConditioners.Count;
        }
    }
}
