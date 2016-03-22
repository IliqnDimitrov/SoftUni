using VegetableNinja.Interfaces;

namespace VegetableNinja.Models.Vegetables
{
    public class Mushroom : VegetableBehavior
    {
        private const int powerReduce = 10;
        private const int staminaReduce = 10;

        public override void VegetableEffect(INinja ninja)
        {
            if (ninja.Power - powerReduce < 0)
            {
                ninja.Power = 0;
            }
            else
            {
                ninja.Power -= powerReduce;
            }
            if (ninja.Stamina - staminaReduce < 0)
            {
                ninja.Stamina = 0;
            }
            else
            {
                ninja.Stamina -= staminaReduce;
            }
        }
    }
}