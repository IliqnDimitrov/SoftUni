namespace BigMani
{
    using BigMani.Core;
    using BigMani.UI;
    using BigMani.Wokr;

    public class Program
    {
        public static void Main()
        {
            var engine = new Engine(new ConsoleUserInterface());
            engine.Run();
        }
    }
}
