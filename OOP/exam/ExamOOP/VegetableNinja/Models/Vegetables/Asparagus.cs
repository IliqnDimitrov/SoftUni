using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public class Asparagus : VegetableBehavior
    {
        private const int increasePower = 5;
        private const int reduceStamina = 5;

        public override void VegetableEffect(INinja ninja)
        {
            ninja.Power += increasePower;
            if (ninja.Stamina - reduceStamina < 0)
            {
                ninja.Stamina = 0;
            }
            else
            {
                ninja.Stamina -= reduceStamina;
            }            
        }
    }
}