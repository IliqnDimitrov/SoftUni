using Blobs.Interfaces;

namespace Blobs.blobs
{
    public abstract class Behavior : IBehavior
    {
        public abstract void CurrentBehavior(IBlob blob);
    }
}