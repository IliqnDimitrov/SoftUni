using System;
using System.Collections.Generic;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Data : IData
    {
        private readonly ICollection<IBlob> blobs = new List<IBlob>();

        public IEnumerable<IBlob> Blobs
        {
            get { return this.blobs; }
        }

        public void AddBlobs(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException("blob");
            }
            this.blobs.Add(blob);
        }
    }
}