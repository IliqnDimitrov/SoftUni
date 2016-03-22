using ACTester.Core;
using ACTester.Exceptions;

namespace ACTester
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;   

    using Interfaces;
    using Models;

    public class Engine
    {
        private IOutputWriter writer;
        private IInputReader reader;
        private IData data;

        public Engine(IOutputWriter writer, IInputReader reader, IData data)
        {
            this.data = data;
            this.Writer = writer;
            this.Reader = reader;
        }

        public void Run()
        {
            while (true)
            {
                string[] inputLine = reader.ReadLine()
                    .Split(new char[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    ExecuteCommand(inputLine);
                }
                catch (InvalidOperationException ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }

        public void ExecuteCommand(string[] inputLine)
        {
            try
            {
                switch (inputLine[0])
                {
                    case "RegisterStationaryAirConditioner":
                        ValidateParametersCount(inputLine, 4);
                        RegisterStationaryAirConditioner(
                            inputLine[1],
                            inputLine[2],
                            char.Parse(inputLine[3]),
                            int.Parse(inputLine[4]));
                        break;

                    case "RegisterCarAirConditioner":
                        ValidateParametersCount(inputLine, 3);
                        RegisterCarAirConditioner(
                            inputLine[1],
                            inputLine[2],
                            int.Parse(inputLine[3]));
                        break;

                    case "RegisterPlaneAirConditioner":
                        ValidateParametersCount(inputLine, 4);
                        RegisterPlaneAirConditioner(
                            inputLine[1],
                            inputLine[2],
                            int.Parse(inputLine[3]),
                            int.Parse(inputLine[4]));
                        break;

                    case "TestAirConditioner":
                        ValidateParametersCount(inputLine, 2);
                        TestAirConditioner(
                            inputLine[1],
                            inputLine[2]);
                        break;

                    case "FindAirConditioner":
                        ValidateParametersCount(inputLine, 2);
                        FindAirConditioner(
                            inputLine[1],
                            inputLine[2]);
                        break;

                    case "FindReport":
                        ValidateParametersCount(inputLine, 2);
                        FindReport(
                             inputLine[1],
                              inputLine[2]);
                        break;
                    case "FindAllReportsByManufacturer":
                        FindAllReportsByManufacturer(
                            inputLine[1]);
                        break;

                    case "Status":
                        ValidateParametersCount(inputLine, 0);
                        Status();
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid command");
                }
            }
            catch (FormatException)
            {
                throw new InvalidOperationException("Invalid command");
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException("Invalid command");
            }
        }

        public IInputReader Reader
        {
            get
            {
                return this.reader;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Reader cannot be null.");
                }

                this.reader = value;
            }
        }

        public IOutputWriter Writer
        {
            get
            {
                return this.writer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The engine's writer cannot be null");
                }

                this.writer = value;
            }
        }

        public void Status()
        {
            int reports = data.Reports.Count();
            double airConditioners = data.AirConditioners.Count();
            double percent = reports / airConditioners;
            percent = percent * 100;

            writer.WriteLine($"Jobs complete: {percent:F2}%");
        }

        public void ValidateParametersCount(string[] inputLine, int count)
        {
            if (inputLine.Length - 1 != count)
            {
                throw new InvalidOperationException("Invalid command");
            }
        }

        public void RegisterStationaryAirConditioner(string manufacturer, string model, char energyEfficiencyRating, int powerUsage)
        {
            try
            {
                IAirConditioner airConditioner = new StationaryAirConditioner(manufacturer, model, energyEfficiencyRating, powerUsage);

                CheckIfExist(airConditioner);

                this.data.AddAirConditioner(airConditioner);
                writer.WriteLine($"Air Conditioner model {airConditioner.Model} " +
                                 $"from {airConditioner.Manufacturer} registered successfully.");
            }
            catch (DuplicateEntryException e)
            {
                writer.WriteLine(e.Message);
            }
        }

        private void CheckIfExist(IAirConditioner airConditioner)
        {
            foreach (var air in data.AirConditioners)
            {
                if (air.Manufacturer == airConditioner.Manufacturer &&
                    air.Model == airConditioner.Model)
                {
                    throw new DuplicateEntryException("An entry for the given model already exists.");
                }
            }
        }

        public void RegisterCarAirConditioner(string manufacturer, string model, int volumeCoverage)
        {
            try
            {
                IAirConditioner airConditioner = new CarAirConditioner(manufacturer, model, volumeCoverage);

                CheckIfExist(airConditioner);

                this.data.AddAirConditioner(airConditioner);
                writer.WriteLine($"Air Conditioner model {airConditioner.Model}" +
                                 $" from {airConditioner.Manufacturer} registered successfully.");
            }
            catch (Exception e)
            {
                writer.WriteLine(e.Message);
            }
        }

        public void RegisterPlaneAirConditioner(string manufacturer, string model, int volumeCoverage, int electricityUsed)
        {
            try
            {
                IAirConditioner airConditioner = new PlaneAirConditioner(manufacturer, model, volumeCoverage, electricityUsed);

                CheckIfExist(airConditioner);

                this.data.AddAirConditioner(airConditioner);
                writer.WriteLine($"Air Conditioner model {airConditioner.Model} " +
                                 $"from {airConditioner.Manufacturer} registered successfully.");
            }
            catch (Exception e)
            {
                writer.WriteLine(e.Message);
            }
        }

        public void TestAirConditioner(string manufacturer, string model)
        {
            try
            {
                IAirConditioner airConditioner = this.data.GetAirConditioner(manufacturer, model);

                bool isPassed = airConditioner.Test();

                if (isPassed)
                {
                    airConditioner.Mark = "Passed";
                }

                IReport report = new Report(
                    airConditioner.Manufacturer,
                    airConditioner.Model,
                    airConditioner.Mark);

                foreach (var rep in data.Reports)
                {
                    if (rep.Manufacturer == airConditioner.Manufacturer &&
                        rep.Model == airConditioner.Model)
                    {
                        throw new DuplicateEntryException("An entry for the given model already exists.");
                    }
                }

                data.AddReport(report);
                writer.WriteLine(
                    $"Air conditioner model {airConditioner.Model}" +
                    $" from {airConditioner.Manufacturer} tested successfully");
            }
            catch (DuplicateEntryException e)
            {
                writer.WriteLine(e.Message);
            }
            catch (NullReferenceException)
            {
                writer.WriteLine("The specified entry does not exist.");
            }
        }

        public void FindAirConditioner(string manufacturer, string model)
        {
            try
            {
                IAirConditioner airConditioner = data.GetAirConditioner(manufacturer, model);
                writer.WriteLine(airConditioner.ToString());
            }
            catch (NullReferenceException)
            {
                writer.WriteLine("The specified entry does not exist.");
            }
        }

        public void FindReport(string manufacturer, string model)
        {
            try
            {
                IReport report = data.GetReport(manufacturer, model);
                writer.WriteLine(report.ToString());
            }
            catch (NullReferenceException)
            {
                writer.WriteLine("The specified entry does not exist.");
            }
        }

        public void FindAllReportsByManufacturer(string manufacturer)
        {
            try
            {
                List<IReport> reportsByManufacturer = data.GetReportByManufacturer(manufacturer);

                reportsByManufacturer = reportsByManufacturer.OrderBy(x => x.Mark).ToList();
                StringBuilder reportsPrint = new StringBuilder();

                reportsPrint.AppendLine(string.Format("Reports from {0}:", manufacturer));

                reportsPrint.Append(string.Join(Environment.NewLine, reportsByManufacturer));

                writer.WriteLine(reportsPrint.ToString());
            }
            catch (Exception)
            {
                writer.WriteLine("No reports.");
            }
        }
    }
}