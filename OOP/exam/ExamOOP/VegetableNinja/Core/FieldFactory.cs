namespace VegetableNinja.Core
{
    using VegetableNinja.Interfaces;
    using VegetableNinja.Models;

    public class FieldFactory : IFieldFactory
    {
        public IField CreateField(int rows, int cols)
        {
            return new Field(rows, cols);
        }
    }
}