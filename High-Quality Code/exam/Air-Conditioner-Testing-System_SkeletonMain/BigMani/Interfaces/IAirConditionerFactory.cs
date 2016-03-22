namespace ACTester.Interfaces
{
    public interface IAirConditionerFactory
    {
        IAirConditioner CreateAirConditioner(string[] inputLine);
    }
}