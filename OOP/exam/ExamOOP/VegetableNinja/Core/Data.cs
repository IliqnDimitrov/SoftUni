namespace VegetableNinja.Core
{
    using System;
    using System.Collections.Generic;
    using VegetableNinja.Interfaces;

    public class Data : IData
    {
        private readonly ICollection<INinja> ninjas = new List<INinja>();
        private readonly ICollection<IField> fields = new List<IField>(); 

        public IEnumerable<INinja> Ninjas
        {
            get { return this.ninjas; }            
        }

        public IEnumerable<IField> Fields
        {
            get { return this.fields; } 
        }

        public void AddNinjas(INinja ninja)
        {
            if (ninja == null)
            {
                throw new ArgumentNullException("ninja cannot be null");
            }
            this.ninjas.Add(ninja);
        }

        public void AddFIeld(IField field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field cannot be null");
            }
            this.fields.Add(field);
        }
    }
}