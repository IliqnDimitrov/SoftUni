namespace AnimalFarm
{
    using System;

    public class AnimalFarm
    {
        public static void Main()
        {
            Chicken chicken = new Chicken("Mara", 5);
            Console.WriteLine(chicken.ProductPerDay);
            Console.WriteLine(chicken.GetHumanAge());
        }
    }
}
