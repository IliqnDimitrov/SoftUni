using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public class Broccoli : VegetableBehavior
    {
        private const int increasePower = 10;

        public override void VegetableEffect(INinja ninja)
        {
            ninja.Power += increasePower;
        }
    }
}