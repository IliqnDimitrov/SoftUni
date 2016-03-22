namespace VegetableNinja.Interfaces
{
    public interface IField
    {
        int FieldRows { get; set; }
        int FieldCols { get; set; }
        char[][] GameField { get; set; }

    }
}