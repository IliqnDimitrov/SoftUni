using System;
using VegetableNinja.Interfaces;

namespace VegetableNinja.Models
{
    public class Field : IField
    {
        private int fieldRows;
        private int fieldCols;

        public Field(int fieldRows, int fieldCols)
        {
            this.FieldRows = fieldRows;
            this.FieldCols = fieldCols;
            this.GameField = new char[fieldRows][];
            this.GenerateField();
        }
        public int FieldRows
        {
            get { return this.fieldRows; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Field Rows must be in range 0-100");
                }
                this.fieldRows = value;
            }
            
        }

        public int FieldCols
        {
            get { return this.fieldCols; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Field Cols must be in range 0-100");
                }
                this.fieldCols = value;
            }           
        }

        public char[][] GameField { get; set; }

        private void GenerateField()
        {
            for (int i = 0; i < this.fieldRows; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                this.GameField[i] = new char[this.fieldCols];
                for (int j = 0; j < this.fieldCols; j++)
                {
                    this.GameField[i][j] = Convert.ToChar(input[j]);
                }
            }
        }
    }
}