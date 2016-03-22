namespace ACTester.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Data : IData
    {
        private readonly ICollection<IAirConditioner> airConditioners = new List<IAirConditioner>();
        private readonly ICollection<IReport> reports = new List<IReport>();

        public IEnumerable<IAirConditioner> AirConditioners
        {
            get
            {
                return this.airConditioners;
            }
        }

        public IEnumerable<IReport> Reports
        {
            get
            {
                return this.reports;
            }
        }

        public void AddAirConditioner(IAirConditioner airConditioner)
        {
            if (airConditioner == null)
            {
                throw new ArgumentNullException("Air conditioner cannot be null");
            }

            this.airConditioners.Add(airConditioner);
        }

        public void AddReport(IReport report)
        {
            if (report == null)
            {
                throw new ArgumentNullException("Report cannot be null");
            }

            this.reports.Add(report);
        }

        public IAirConditioner GetAirConditioner(string manufacturer, string model)
        {
            var airConditionerByManufacturerAndModel = airConditioners.FirstOrDefault(
                air => air.Manufacturer == manufacturer && air.Model == model);

            return airConditionerByManufacturerAndModel;
        }

        public IReport GetReport(string manufacturer, string model)
        {
            var reportByManufacturerAndModel = reports.FirstOrDefault(
                rep => rep.Manufacturer == manufacturer && rep.Model == model);

            return reportByManufacturerAndModel;
        }

        public List<IReport> GetReportByManufacturer(string manufacturer)
        {
            return reports.Where(x => x.Manufacturer == manufacturer).ToList();
        }
    }
}
