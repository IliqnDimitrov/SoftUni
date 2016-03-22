using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public class CherryBerry : VegetableBehavior
    {
        private const int increseStamina = 10;

        public override void VegetableEffect(INinja ninja)
        {
            ninja.Stamina += increseStamina;
        }
    }
}