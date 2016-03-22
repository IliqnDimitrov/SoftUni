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
                    return new AggresivePutridFartBlob(name,health,damage);
                case "AggressiveBlobplodeBlob":
                    return new AggressiveBlobplodeBlob(name,health,damage);
                case "InflatedBlobplodeBlob":
                    return new InflatedBlobplodeBlob(name,health,damage);
                case "InflatedPutridFartBlob":
                    return new InflatedPutridFartBlob(name,health,damage);
                default:
                    throw new ArgumentException("Unknown blob type");
            }
        }
    }
}