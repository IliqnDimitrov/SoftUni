using Empires.Enum;
using Empires.Interfaces;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private int cycleCount = 0;
        private const int ProductionDelay = 1;
        private string unitType;
        private int unitCycleLength;
        private ResourceType resourceType;
        private int resourceCycleLength;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;

        protected Building(
            string unitType,
            int unitCycleLength,
            ResourceType resourceType,
            int resourceCycleLength,
            int resourceQuantity,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.unitCycleLength = unitCycleLength;
            this.resourceType = resourceType;
            this.resourceCycleLength = resourceCycleLength;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource = this.cycleCount > ProductionDelay &&
                                          (this.cycleCount - ProductionDelay)%this.resourceCycleLength == 0;
                return canProduceResource;
            }
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cycleCount > ProductionDelay &&
                                          (this.cycleCount - ProductionDelay) % this.unitCycleLength == 0;
                return canProduceUnit;
            }
        }

        public IResource ProduceResource()
        {
            var resource = this.resourceFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }

        
        public IUnit ProdcueUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }

        public void Update()
        {
            this.cycleCount++;
        }

        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLength - (this.cycleCount - ProductionDelay)%this.unitCycleLength;
            int turnsUntilResource = this.resourceCycleLength-(this.cycleCount-ProductionDelay)%this.resourceCycleLength;

            var result = string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.cycleCount-ProductionDelay,
                turnsUntilUnit,
                this.unitType,
                turnsUntilResource,
                this.resourceType);
            return result;
        }
    }
}