using System;
using Blobs.blobs;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Factory : IBlobFactory
    {
        public IBlob CreateBlob(string blobType, string name, int health, int damage)
        {
            switch (blobType)
            {
                case "AggresivePutridFartBlob":
                    return new blob(name,health,damage,new AggressiveBehavior(), new Putrid());
                case "AggressiveBlobplodeBlob":
                    return new blob(name,health,damage,new AggressiveBehavior(), new Bloodplode());
                case "InflatedBlobplodeBlob":
                    return new blob(name,health,damage,new InflatedBehavior(), new Bloodplode());
                case "InflatedPutridFartBlob":
                    return new blob(name,health,damage,new InflatedBehavior(), new Putrid());
                default:
                    throw new ArgumentException("Unknown blob type");
            }
        }
    }
}