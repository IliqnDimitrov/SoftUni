namespace ACTester
{
    using UI;
    using Data;

    public class StartTester
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Data.Data();

            var engine = new Engine(writer, reader,data);
            engine.Run();
        }
    }
}
