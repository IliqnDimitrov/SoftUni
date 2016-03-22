using System;
using System.Runtime.InteropServices;
using Blobs.Interfaces;

namespace Blobs.blobs
{
    public abstract class blob : IBlob,IAttack
    {
        private string name;
        private int health;
        private int damage;

        protected blob(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative.");
                }
                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage cannot be negative.");
                }
                this.damage = value;
            }
        }

        public abstract void Attack();
    }
}