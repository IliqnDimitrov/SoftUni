namespace Blobs.blobs
{
    public class InflatedBlobplodeBlob : blob
    {
        private int health;

        public InflatedBlobplodeBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
        }

        public override void Attack()
        {
            int DamageToTarget = this.Damage;

            if (this.health / 2 < this.Health)
            {
                this.Health = this.Health + 50;
            }
            this.Health = this.Health/2;
            DamageToTarget = this.Damage*2;
        }

        }
    }
