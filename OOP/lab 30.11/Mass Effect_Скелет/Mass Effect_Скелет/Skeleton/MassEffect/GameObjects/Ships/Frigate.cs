using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;

namespace MassEffect.GameObjects.Ships
{
    class Frigate : Starship
    {
        private int projectilesFired;

        public Frigate(string name, StarSystem location)
            :base(name,60,50,30,220,location)
        {
            this.projectilesFired = 0;
        }

        public override Interfaces.IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            string output = base.ToString();
            if (this.Health > 0)
            {
                output += string.Format("\n-Projectiles fired: {0}", this.projectilesFired);
            }
            return output;
        }
    }
}
