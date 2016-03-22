using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class Putrid : Attack
    {
        public override void AttackBehavior(IBlob blob)
        {
            blob.Damage = blob.Damage;
        }
    }
}