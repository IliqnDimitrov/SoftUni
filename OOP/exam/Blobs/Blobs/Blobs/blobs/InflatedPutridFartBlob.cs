namespace Blobs.blobs
{
    public class InflatedPutridFartBlob : blob
    {
        private int health;

        public InflatedPutridFartBlob(string name, int health, int damage) 
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
        }
    }
}