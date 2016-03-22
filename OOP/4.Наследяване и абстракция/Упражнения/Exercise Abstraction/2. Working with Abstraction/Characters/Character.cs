using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Working_with_Abstraction.Interfaces;

namespace _2.Working_with_Abstraction.Characters
{
   public abstract class Character : IAttack
    {
        private int health;
        private int mana;
        private int damage;

        protected Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        public abstract void Attack(Character target);
    }
}
