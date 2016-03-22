using Blobs.Interfaces;

namespace Blobs.blobs
{
    public class AggressiveBehavior : Behavior
    {
        private bool isTrigered = false;
        private int initDamage;

        public override void CurrentBehavior(IBlob blob)
        {
            if (isTrigered == true)
            {
                if (blob.Damage - 5 < initDamage)
                {
                    blob.Damage = initDamage;
                }
                else
                {
                    blob.Damage -= 5;
                }
                goto done;
            }
            else
            {
                initDamage = blob.Damage;

                isTrigered = true;

                blob.Damage *= 2;
            }
            done:;
        }
    }
}