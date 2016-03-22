using Empires.Enum;
using Empires.Interfaces;

namespace Empires.Models.Buildings
{
    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int ArcheryCycleLength = 3;

        private const ResourceType ArcheryResourceType = ResourceType.Gold;
        private const int ArcheryResourceCycleLength = 2;
        private const int ArcherResourceQuantity = 5;

        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(
            ArcheryUnitType, 
            ArcheryCycleLength, 
            ArcheryResourceType, 
            ArcheryResourceCycleLength,
            ArcherResourceQuantity,
            unitFactory, 
            resourceFactory)
        {
        }
    }
}