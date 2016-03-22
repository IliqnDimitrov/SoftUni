namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;
    using MassEffect.Engine.Factories;
    using MassEffect.GameObjects.Ships;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            IStarship ship = this.GetStarshipByName(shipName);
            System.Console.WriteLine(ship.ToString());
        }
    }
}
