using Empires.Interfaces;

namespace Empires.Models.Units
{
    public abstract class Unit : IUnit
    {
        protected Unit(int attackDamage, int health)
        {
            AttackDamage = attackDamage;
            Health = health;
        }

        public int AttackDamage { get; private set; }

        public int Health { get; private set; }
    }
}