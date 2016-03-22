namespace Blobs.blobs
{
    public class AggressiveBlobplodeBlob : blob
    {
        private int health;

        public AggressiveBlobplodeBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
        }

        public override void Attack()
        {
            int DamageToTarget = this.Damage;

            if (this.health / 2 < this.Health)
            {
                DamageToTarget = this.Damage * 2;
            }
            this.Health = this.Health/2;
            DamageToTarget = this.Damage*2;
        }
    }
}