using System;
using System.Collections.Generic;
using Empires.Enum;
using Empires.Interfaces;

namespace Empires.Core
{
    public class EmpiresData : IEmpiresData
    {
        private readonly ICollection<IBuilding> biuldings = new List<IBuilding>(); 
        private readonly ICollection<KeyValuePair<string, int>> units = new Dictionary<string, int>();

        public EmpiresData()
        {
            this.Units = new Dictionary<string, int>();
            this.Resource = new Dictionary<ResourceType, int>();
            this.InitResources();
        }

        private void InitResources()
        {
            var resourceTypes = System.Enum.GetValues(typeof (ResourceType));

            foreach (ResourceType resourceType in resourceTypes)
            {
                this.Resource.Add(resourceType, 0);
            }
        }

        public IEnumerable<IBuilding> Biuldings 
        {
            get { return this.biuldings; }
        }
       
        public void AddBulding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException("building");
            }
            this.biuldings.Add(building);
        }

       
        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentException("unit");
            }
            var unitType = unit.GetType().Name;

            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }

            this.Units[unitType]++;
        }

        public IDictionary<string, int> Units { get; private set; }
        public IDictionary<ResourceType, int> Resource { get; private set; }
    }
}