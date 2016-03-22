namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;
    using MassEffect.Exceptions;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];
            IStarship attackingShip = GetStarshipByName(attackerName), targetShip = GetStarshipByName(targetName);
            this.ProcessStarshipBattle(attackingShip, targetShip);
            
        }
        public void ProcessStarshipBattle(IStarship attackingShip, IStarship targetShip)
        {
            base.ValidateAlive(attackingShip);
            base.ValidateAlive(targetShip);
            if (attackingShip.Location != targetShip.Location)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            IProjectile attack = attackingShip.ProduceAttack();
            targetShip.RespondToAttack(attack);
            System.Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, targetShip.Name);

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }
            if (targetShip.Health <= 0)
            {
                targetShip.Health = 0;
                System.Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
        }     
    }
}
