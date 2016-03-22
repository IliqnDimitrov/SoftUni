using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public abstract class VegetableBehavior : IVegetableBehavior
    {
        public abstract void VegetableEffect(INinja ninja);
    }
}