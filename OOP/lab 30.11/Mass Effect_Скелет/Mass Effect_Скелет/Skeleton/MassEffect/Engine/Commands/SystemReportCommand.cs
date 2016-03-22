using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            :base(gameEngine)
        {

        }
        public override void Execute(string[] commandArgs)
        {
            string locationName = commandArgs[1];
            var starships = this.GameEngine.Starships.Where(s => s.Location.Name == locationName);
            IEnumerable<IStarship> intactShips = starships.Where(x => x.Health > 0).OrderByDescending(x => x.Health).ThenByDescending(x => x.Shields);
            IEnumerable<IStarship> destroyedShips = starships.Where(x => x.Health <= 0).OrderBy(x => x.Name);

            StringBuilder output = new StringBuilder();
            output.AppendLine("Intact ships:");
            output.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");
            output.AppendLine("Destroyed ships:");
            output.Append(destroyedShips.Any() ? string.Join("\n", destroyedShips) : "N/A");
            Console.WriteLine(output.ToString());
        }
    }
}
