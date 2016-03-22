using VegetableNinja.Interfaces;
using VegetableNinja.Models;

namespace VegetableNinja.Core
{
    public class NinjaFactory : INinjaFactory
    {
        private const int defaultPower = 1;
        private const int defaultStamina = 1;

        public INinja CreateNinja(string name)
        {
            return new Ninja(name, defaultPower, defaultStamina);
        }
    }
}