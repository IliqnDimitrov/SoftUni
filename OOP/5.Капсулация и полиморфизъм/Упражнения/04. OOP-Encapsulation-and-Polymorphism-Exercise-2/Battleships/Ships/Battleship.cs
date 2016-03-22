using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Contacts;

namespace Battleships.Ships
{
    public abstract class Battleship : Ship,IAttack
    {
         protected Battleship(string name, double lengthInMeters, double volume)
             :base(name,lengthInMeters,volume)
        {

        }

        public abstract string Attack(Ship target);

        protected void DestroyTarget(Ship target)
        {
            target.IsDestroyed = true;
        }
    }
}
