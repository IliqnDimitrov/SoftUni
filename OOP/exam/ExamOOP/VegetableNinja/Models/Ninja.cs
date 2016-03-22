using System;
using System.Collections.Generic;
using VegetableNinja.Core;
using VegetableNinja.Interfaces;
using VegetableNinja.Models.Vegetables;

namespace VegetableNinja.Models
{
    public class Ninja : INinja
    {
        private string name;
        private int power;
        private int stamina;

        public Ninja(string name, int power, int stamina)
        {
            this.Name = name;
            this.Power = power;
            this.Stamina = stamina;
            this.Vegetables = new List<VegetableBehavior>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value; 
            }
        }

        public int Power
        {
            get { return this.power; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Power cannot be negative.");
                }
                this.power = value;                 
            }
        }

        public int Stamina
        {
            get { return this.stamina; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Stamina cannot be negative.");
                }
                this.stamina = value;              
            }
        }

        public List<VegetableBehavior> Vegetables { get; set; }

        public int RowPositionField { get; set; }

        public int ColPositionFIeld { get; set; }

    }
}