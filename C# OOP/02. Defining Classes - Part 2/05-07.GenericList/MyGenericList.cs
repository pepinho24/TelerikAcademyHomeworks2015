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
 * fiing element by its value and 
 * ToString().

 * Check all input parameters to avoid accessing elements at invalid positions.
  Problem 6. Auto-grow
 
Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 
* Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for fiing the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.
 */
namespace _05_07.GenericList
{
    using System;
    using System.Text;

    public class MyGenericList<T>
        where T : IComparable
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
                Checkindex(index);
                return this.Elements[index];
            }
            set
            {
                Checkindex(index);
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
            Checkindex(index);

            var removedElement = this.Elements[index];

            for (int i = index + 1; i < this.Elements.Length; i++)
            {
                this.Elements[i - 1] = this.Elements[i];
            }

            this.Elements[this.Elements.Length - 1] = default(T);
            this.NextFree--;

            return removedElement;
        }

        public void InsertAt(int index, T item)
        {
            Checkindex(index);

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

            for (int i = 0; i < this.NextFree; i++)
            {
                if (this.Elements[i].Equals(element))
                {
                    return i;
                }
            }

            return index;
        }

        public T Min()
        {
            if (NextFree > 0)
            {
                T min = default(T);

                min = this.Elements[0];

                for (int i = 1; i < this.NextFree; i++)
                {
                    if (min.CompareTo(this.Elements[i]) > 0)
                    {
                        min = this.Elements[i];
                    }
                }

                return min;
            }
            else
            {
                throw new NullReferenceException("There are no elements int the list!");
            }
        }

        public T Max()
        {
            if (NextFree > 0)
            {
                T max = default(T);

                max = this.Elements[0];

                for (int i = 1; i < this.NextFree; i++)
                {
                    if (max.CompareTo(this.Elements[i]) < 0)
                    {
                        max = this.Elements[i];
                    }
                }

                return max;
            }
            else
            {
                throw new NullReferenceException("There are no elements int the list!");
            }
        }


        private void Checkindex(int index)
        {
            if (index < 0 || index >= NextFree)
            {
                throw new IndexOutOfRangeException(String.Format("index {0} is invalid!", index));
            }
        }

        private void DoubleCapacity()
        {
            var newCapacity = this.Elements.Length == 0 ? 1 : this.Elements.Length * 2;
            var newElements = new T[newCapacity];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                newElements[i] = this.Elements[i];
            }

            this.Elements = newElements;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Elements[0]);

            for (int i = 1; i < this.NextFree; i++)
            {
                sb.AppendFormat(", {0}", this.Elements[i]);
            }

            return sb.ToString();
        }
    }
}
