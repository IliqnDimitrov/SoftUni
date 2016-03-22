namespace ACTester.Interfaces
{
    public interface IAirConditioner
    {
        string Manufacturer { get; set; }

        string Model { get; set; }

        bool Test();

        bool IsPassed();

        string Mark { get; set; }
        
        string Type { get; set; }
    }
}