using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public class Royal : VegetableBehavior
    {
        private const int increasePower = 20;
        private const int increaseStamina = 10;

        public override void VegetableEffect(INinja ninja)
        {
            ninja.Power += increasePower;
            ninja.Stamina += increaseStamina;
        }
    }
}