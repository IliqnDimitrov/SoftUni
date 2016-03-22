using System.Threading;
using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class InflatedBehavior : Behavior
    {
        private bool isTrigered = false;

        public override void CurrentBehavior(IBlob blob)
        {
            if (isTrigered == true)
            {
                if (blob.Health - 10 <= 0)
                {
                    blob.Health = 0;
                }
                else
                {
                    blob.Health -= 10;
                }             
                goto done;
            }

            isTrigered = true;

            blob.Health += 50;
            done:;
        }
    }
}