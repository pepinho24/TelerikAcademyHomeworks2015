/*
 Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.

*Implement methods for 
 * adding element, 
 * accessing element by index, 
 * removing element by index, 
 * inserting element at given position, 
 * clearing the list, 
 * finding element by its value and 
 * ToString().

 * Check all input parameters to avoid accessing elements at invalid positions.
  Problem 6. Auto-grow
 
Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 
 */
namespace _05_07.GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyGenericList<T>
    {
        private T[] elements;
        private int NextFree = 0;

        public MyGenericList(int capacity)
        {
            if (capacity < 0) { throw new ArgumentOutOfRangeException("Capacity cannot be negative number!"); }

            this.elements = new T[capacity];
        }

        public T[] Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this.Elements[index];
            }
            set
            {
                CheckIndex(index);
                this.Elements[index] = value;
            }
        }

        public void Add(T item)
        {
            if (NextFree >= this.Elements.Length)
            {
                DoubleCapacity();
            }

            this.Elements[NextFree] = item;
            NextFree++;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);

            var removedElement = this.Elements[index];

            for (int i = index+1; i < this.Elements.Length; i++)
            {
                this.Elements[i - 1] = this.Elements[i];
            }

            this.Elements[this.Elements.Length - 1] = default(T);

            return removedElement;
        }

        public void InsertAt(int index, T item)
        {
            CheckIndex(index);
            
            for (int i = this.Elements.Length; i > index; i--)
            {
                if (i == this.Elements.Length)
                {
                    this.Add(this.Elements[i - 1]);
                }
                else
                {
                    this.Elements[i] = this.Elements[i - 1];
                }
            }

            this.Elements[index] = item;
        }

        public void Clear()
        {
            this.Elements = new T[0];
            this.NextFree = 0;
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int ind = 0; ind < this.NextFree; ind++)
            {
                if (this.Elements[ind].Equals(element))
                {
                    return ind;
                }
            }

            return index;
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= NextFree)
            {
                throw new IndexOutOfRangeException(
                 String.Format("Index {0} is invalid!", index));
            }
        }

        private void DoubleCapacity()
        {
            var newCapacity = this.Elements.Length == 0 ? 2 : this.Elements.Length * 2;

            var newElements = new T[newCapacity];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                newElements[i] = this.Elements[i];
            }

            this.Elements = newElements;
        }
    }
}
