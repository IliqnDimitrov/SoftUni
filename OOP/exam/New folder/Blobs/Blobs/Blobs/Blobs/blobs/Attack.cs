using Blobs.Interfaces;

namespace Blobs.blobs
{
    public abstract class Attack : IAttackBehavior
    {
        public abstract void AttackBehavior(IBlob blob);
    }
}