using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Enhancements;

namespace MassEffect.GameObjects.Ships
{
    public abstract class Starship : IStarship
    {
        private string name;
        private int health;
        private int shields;
        private int damage;
        private double fuel;
        private StarSystem location;
        private IList<Enhancement> enhancements;

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Shields
        {
            get { return this.shields; }
            set { this.shields = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
        public StarSystem Location { get; set; }
        public IEnumerable<Enhancement> Enhancements
        {
            get { return this.enhancements; }
        }

        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
            this.enhancements = new List<Enhancement>();
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement == null)
            {
                throw new ArgumentNullException("Enhancement cannot be null");
            }
            this.enhancements.Add(enhancement);
            this.EnhancementEffect(enhancement);
        }
        public void EnhancementEffect(Enhancement enhancement)
        {
            this.Shields += enhancement.ShieldBonus;
            this.Damage += enhancement.DamageBonus;
            this.Fuel += enhancement.FuelBonus;
        }
        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile projectile)
        {
            projectile.Hit(this);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("--{0} - {1}", this.Name, this.GetType().Name));
            if (this.Health <= 0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                
                output.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(string.Format("-Health: {0}",this.Health));
                output.AppendLine(string.Format("-Shields: {0}",this.Shields));
                output.AppendLine(string.Format("-Damage: {0}",this.Damage));
                output.AppendLine(string.Format("-Fuel: {0:F1}",this.Fuel));
                string enhancementsOutput = "N/A";
                
                if (this.enhancements.Any())
                {
                    enhancementsOutput = string.Join(", ", this.enhancements.Select(n => n.Name));
                }
                output.Append(string.Format("-Enhancements: {0}",enhancementsOutput));
           
            }
            return output.ToString();
        }
    }
}
