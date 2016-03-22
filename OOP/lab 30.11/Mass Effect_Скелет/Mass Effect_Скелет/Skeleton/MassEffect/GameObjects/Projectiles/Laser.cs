using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    class Laser : Projectile
    {
        public Laser(int damage)
            :base(damage)
        {

        }
        public override void Hit(Interfaces.IStarship targetShip)
        {
            int reminder = this.Damage - targetShip.Shields;
            targetShip.Shields -= this.Damage;
            if (reminder > 0)
            {
                targetShip.Health -= reminder;
            }
        }
    }
}
