using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MassEffect.GameObjects.Projectiles
{
    class ShieldReaver : Projectile
    {
        public ShieldReaver(int damage)
            :base(damage)
        {

        }
        public override void Hit(Interfaces.IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
            targetShip.Shields -= 2 * this.Damage;
        }
        
       



    }
}
