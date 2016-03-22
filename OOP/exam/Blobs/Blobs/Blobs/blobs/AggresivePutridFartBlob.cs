using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class AggresivePutridFartBlob : blob
    {
        private int health;

        public AggresivePutridFartBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
           
            
        }

        public override void Attack()
        {
            int DamageToTarget = this.Damage;

            if (this.health/2 < this.Health )
            {
                DamageToTarget = this.Damage*2;
            }
        }
    }
}