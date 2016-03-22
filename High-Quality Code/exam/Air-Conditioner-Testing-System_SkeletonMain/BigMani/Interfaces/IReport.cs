using System.Collections;
using System.Collections.Generic;

namespace ACTester.Interfaces
{
    public interface IReport
    {
        string Manufacturer { get; set; }

        string Model { get; set; }

        bool IsPassed { get; set; }

        string Mark { get; set; }
    }
}