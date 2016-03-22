using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
    public interface IResourceProducer
    {
        bool CanProduceResource { get; }

        IResource ProduceResource();
    }
}
