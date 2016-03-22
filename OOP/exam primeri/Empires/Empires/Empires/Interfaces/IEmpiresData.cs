using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enum;

namespace Empires.Interfaces
{
    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Biuldings { get;  }

        void AddBulding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resource { get; }
    }
}
