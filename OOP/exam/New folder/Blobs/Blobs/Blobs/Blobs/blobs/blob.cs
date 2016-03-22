using System;
using System.Runtime.InteropServices;
using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class blob : IBlob
    {
 
        private string name;
        private int health;
        private int damage;
        private IBehavior behavior;
        private IAttackBehavior attack;

        public blob(string name, int health, int damage, IBehavior behavior, IAttackBehavior attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;
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
                    if (!isTriged)
                    {
                        value = 0;
                        this.isTriged = true;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Health cannot be negative.");
                    }                    
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

        public bool isTriged { get; set; }

        public IBehavior Behavior
        {
            get { return behavior; }
            set { behavior = value; }
        }

        public IAttackBehavior Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public void AttackBH(IBlob currentBlob)
        {
            attack.AttackBehavior(currentBlob);                   
        }

        public void BH(IBlob currentBlob)
        {
            this.isTriged = true;
            behavior.CurrentBehavior(currentBlob); 
        }
    }
}