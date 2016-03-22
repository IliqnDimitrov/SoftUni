using System.Collections;
using System.Collections.Generic;

namespace Blobs.Interfaces
{
    public interface IData
    {
        IEnumerable<IBlob> Blobs { get; }

        void AddBlobs(IBlob blob);
    }
}