using System.Collections.Generic;
using VegetableNinja.Models.Vegetables;

namespace VegetableNinja.Interfaces
{
    public interface INinja
    {
        string Name { get; set; }
        int Power { get; set; }
        int Stamina { get; set; }

        int RowPositionField { get; set; }
        int ColPositionFIeld { get; set; }

        List<VegetableBehavior> Vegetables { get; set; }
    }
}