using System.Collections.Generic;

namespace VegetableNinja.Interfaces
{
    public interface IData
    {
        IEnumerable<INinja> Ninjas { get; }

        IEnumerable<IField> Fields { get; }

        void AddNinjas(INinja ninja);    

        void AddFIeld(IField field); 
    }
}