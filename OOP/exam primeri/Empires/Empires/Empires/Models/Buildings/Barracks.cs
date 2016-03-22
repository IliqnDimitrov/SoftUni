using Empires.Enum;
using Empires.Interfaces;

namespace Empires.Models.Buildings
{
    public class Barracks : Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksCycleLength = 4;

        private const ResourceType BarracksResourceType = ResourceType.Steel;
        private const int BarracksResourceCycleLength = 3;
        private const int BarracksResourceQuantity = 10;

        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(
            BarracksUnitType,
            BarracksCycleLength,
            BarracksResourceType,
            BarracksResourceCycleLength, 
            BarracksResourceQuantity,
            unitFactory, 
            resourceFactory)
        {
        }
    }
}