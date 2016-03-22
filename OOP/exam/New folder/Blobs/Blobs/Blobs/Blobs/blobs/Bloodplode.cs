using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class Bloodplode : Attack
    {
        public override void AttackBehavior(IBlob blob)
        {
            if (blob.Health == 1)
            {
                goto done;
            }
            if (blob.Health % 2 == 0)
            {
                blob.Health = blob.Health/2;
            }
            else if (blob.Health % 2 != 0)
            {
                blob.Health = blob.Health / 2;
                blob.Health += 1;
            }
            blob.Damage = blob.Damage*2;
            done:;
        }
    }
}