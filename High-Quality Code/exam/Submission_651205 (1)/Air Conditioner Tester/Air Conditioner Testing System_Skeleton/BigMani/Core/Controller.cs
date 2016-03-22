namespace BigMani.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using BigMani.Exceptions;
    using BigMani.Files;
    using BigMani.GoodStuff;
    using BigMani.IO;
    using BigMani.Models;

    public class Controller
    {
        private Engine vroom;

        public Controller(Engine vrooom)
        {
            this.vroom = vrooom;
        }

        public void DoMagic()
        {
            var input = this.vroom.Magic;
            try
            {
                switch (input.Name)
                {
                    case "RegisterStationaryAirConditioner":
                        this.vroom.ValidateParametersCount(input, 4);
                        this.RegisterStationaryAirConditioner(
                            input.Parameters[0],
                            input.Parameters[1],
                            input.Parameters[2],
                            int.Parse(input.Parameters[3]));
                        break;
                    case "RegisterCarAirConditioner":
                        this.vroom.ValidateParametersCount(input, 3);
                        this.RegisterCarAirConditioner(
                            input.Parameters[0],
                            input.Parameters[1],
                            int.Parse(input.Parameters[2]));
                        break;
                    case "RegisterPlaneAirConditioner":
                        this.vroom.ValidateParametersCount(input, 4);
                        this.RegisterPlaneAirConditioner(
                            input.Parameters[0],
                            input.Parameters[1],
                            int.Parse(input.Parameters[2]),
                            input.Parameters[3]);
                        break;
                    case "TestAirConditioner":
                        this.vroom.ValidateParametersCount(input, 2);
                        this.TestAirConditioner(
                            input.Parameters[0],
                            input.Parameters[1]);
                        break;
                    case "FindAirConditioner":
                        this.vroom.ValidateParametersCount(input, 2);
                        this.FindAirConditioner(
                            input.Parameters[1],
                            input.Parameters[0]);
                        break;
                    case "FindReport":
                        this.vroom.ValidateParametersCount(input, 2);
                        this.FindReport(
                            input.Parameters[0],
                            input.Parameters[1]);
                        break;
                    case "FindAllReportsByManufacturer":
                        this.vroom.ValidateParametersCount(input, 1);
                        this.FindAllReportsByManufacturer(input.Parameters[0]);
                        break;
                    case "Status":
                        this.vroom.ValidateParametersCount(input, 0);
                        this.vroom.Status();
                        break;
                    default:
                        throw new IndexOutOfRangeException(Utility.InvalidCommand);
                }
            }
            catch (FormatException ex)
            {
                throw new InvalidOperationException(Utility.InvalidCommand, ex.InnerException);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new InvalidOperationException(Utility.InvalidCommand, ex.InnerException);
            }
            catch (NonExistantEntryException ex)
            {
                new ConsoleWriter().WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Registers a stationary air conditioner
        /// and add it to the database.
        /// </summary>
        /// <param name="manufacturer">
        /// Manufacturer name.
        /// </param>
        /// <param name="model">
        /// Model name.
        /// </param>
        /// <param name="energyEfficiencyRating">
        /// Required energy efficiency rating
        /// </param>
        /// <param name="powerUsage">
        /// Power usage in kW/h
        /// </param>
        /// <returns>string</returns>
        public string RegisterStationaryAirConditioner(
            string manufacturer, 
            string model, 
            string energyEfficiencyRating,
            int powerUsage)
        {
            StationaryAirConditioners airConditioner = new StationaryAirConditioners(
                manufacturer, model, energyEfficiencyRating, powerUsage);
            Database.AirConditioners.Add(airConditioner);
            throw new InvalidOperationException(string.Format(Utility.Register, airConditioner.Model, airConditioner.Manufacturer));
        }

        public string RegisterCarAirConditioner(string model, string manufacturer, int volumeCoverage)
        {
            BlowWind airConditioner = new BlowWind(manufacturer, model, volumeCoverage);
            Database.AirConditioners.Add(airConditioner);
            throw new InvalidOperationException(
                string.Format(Utility.Register, airConditioner.Model, airConditioner.Manufacturer));
        }

        public void RegisterPlaneAirConditioner(
            string manufacturer, 
            string model, 
            int volumeCoverage,
            string electricityUsed)
        {
            try
            {
                BlowWind airConditioner = new BlowWind(manufacturer, model, volumeCoverage, electricityUsed);
                Database.AirConditioners.Add(airConditioner);
                throw new InvalidOperationException(
                    string.Format(Utility.Test, airConditioner.Model, airConditioner.Manufacturer));
            }
            catch (ArgumentException ex)
            {
                var message = ex.Message;
                new ConsoleWriter().WriteLine(message);
            }
        }

        public string TestAirConditioner(string manufacturer, string model)
        {
            BlowWind airConditioner = Database.GetAirConditioner(manufacturer, model);
            airConditioner.EnergyRating += 5;
            var mark = airConditioner.Test();
            Database.Reports.Add(new Report(airConditioner.Manufacturer, airConditioner.Model, mark));
            throw new InvalidOperationException(string.Format(Utility.Test, model, manufacturer));
        }

        /// <summary>
        /// Finds an air conditioner by a given manufacturer and model 
        /// </summary>
        /// <param name="manufacturer">
        /// Manufacturer name.
        /// </param>
        /// <param name="model">
        /// Model name.
        /// </param>
        /// <returns>string</returns>
        public string FindAirConditioner(string manufacturer, string model)
        {
            BlowWind airConditioner = Database.GetAirConditioner(manufacturer, model);
            throw new InvalidOperationException(airConditioner.ToString());
        }

        public string FindReport(string manufacturer, string model)
        {
            Report report = Database.GetReport(manufacturer, model);
            List<Report> reports = Database.GetReportsByManufacturer(manufacturer);
            if (!reports.Contains(report))
            {
                throw new NonExistantEntryException("The specified entry does not exist.");
            }

            throw new InvalidOperationException(report.ToString());
        }

        public string FindAllReportsByManufacturer(string manufacturer)
        {
            List<Report> reports = Database.GetReportsByManufacturer(manufacturer);
            if (reports.Count == 0)
            {
                return Utility.NoReports;
            }

            reports = reports.OrderBy(x => x.Mark).ToList();
            StringBuilder reportsPrint = new StringBuilder();
            reportsPrint.AppendLine(string.Format("Reports from {0}:", manufacturer));
            reportsPrint.Append(string.Join(Environment.NewLine, reports));

            return reportsPrint.ToString();
        }
    }
}
