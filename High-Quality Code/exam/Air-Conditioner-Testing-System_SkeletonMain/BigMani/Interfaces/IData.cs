using System.Collections;
using System.Collections.Generic;

namespace ACTester.Interfaces
{
    public interface IData
    {
        IEnumerable<IAirConditioner> AirConditioners { get;}

        IEnumerable<IReport> Reports { get; }

        void AddAirConditioner(IAirConditioner airConditioner);

        void AddReport(IReport report);

        IAirConditioner GetAirConditioner(string manufacturer, string model);

        IReport GetReport(string manufacturer, string model);

        List<IReport> GetReportByManufacturer(string manufacturer);
    }
}