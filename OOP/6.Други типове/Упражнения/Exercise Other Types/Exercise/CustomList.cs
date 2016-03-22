using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class CustomList<T> where T : IComparable<T>
    {
        private int currentIndex;
        private const int defaultCapacity = 10;
        private T[] elements;

        public CustomList(int initialCapacity = defaultCapacity)
        {
            this.elements = new T[initialCapacity];
            currentIndex++;
            
        }

        public void Add(T elementToAdd)
        {
            elements[this.currentIndex - 1] = elementToAdd;
            currentIndex++;
        }
        public int IndexOf(T elementToFind)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (this.elements[i].Equals(elementToFind))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(T elementsToRemove)
        {
            int index = this.IndexOf(elementsToRemove);
            for (int i = index ; i < currentIndex -1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[currentIndex - 1] = default(T);
            this.currentIndex--;
        }

        public override string ToString()
        {
            return String.Format("{0}",string.Join(", ",this.elements));
        }

        public T Max()
        {
            T maxElement = this.elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (maxElement.CompareTo(this.elements[i])<0)
                {
                    maxElement = this.elements[i];
                }
            }
            return maxElement;
        }

        public T Min()
        {
            T minElement = this.elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (minElement.CompareTo(this.elements[i]) > 0)
                {
                    minElement = this.elements[i];
                }
            }
            return minElement;
        }


    }
}
