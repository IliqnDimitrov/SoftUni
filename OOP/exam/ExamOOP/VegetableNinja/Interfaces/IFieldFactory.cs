namespace VegetableNinja.Interfaces
{
    public interface IFieldFactory
    {
        IField CreateField(int rows, int cols);  
    }
}