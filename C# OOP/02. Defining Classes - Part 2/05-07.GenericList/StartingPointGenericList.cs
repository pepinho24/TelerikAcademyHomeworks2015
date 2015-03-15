/*
 Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, fiing element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
 
 * Problem 6. Auto-grow

Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

 * Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for fiing the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.
 */
namespace _05_07.GenericList
{
    using System;

    public class StartingPointGenericList
    {
        public static void Main()
        {
            var list = new MyGenericList<int>(1);
            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Original Array (capacity {0}):", list.Elements.Length);
            Console.WriteLine(list);
            Console.WriteLine(new string('-', Console.BufferWidth));

            int element = 555;
            list.Add(element);
            Console.WriteLine("Array after adding {0} (capacity {1}):", element, list.Elements.Length);
            Console.WriteLine(list);
            Console.WriteLine(new string('-', Console.BufferWidth));

            int index = 0;
            int changedElement = 13254687;
            list[index] = changedElement;
            Console.WriteLine("Changing the element at index {0} to {1}:", index, changedElement);
            Console.WriteLine(list);
            Console.WriteLine(new string('-', Console.BufferWidth));

            int insertAtindex = 0;
            int insertAtItem = 123;
            Console.WriteLine("Insert {0} at index {1}", insertAtItem, insertAtindex);
            list.InsertAt(insertAtindex, insertAtItem);
            Console.WriteLine(list);
            Console.WriteLine(new string('-', Console.BufferWidth));

            int removeAtindex = 1;
            list.RemoveAt(removeAtindex);
            Console.WriteLine("Remove element at index {0}", removeAtindex);
            Console.WriteLine(list);
            Console.WriteLine(new string('-', Console.BufferWidth));

            int number = 123;
            Console.WriteLine("Index of {0}: {1}", number, list.indexOf(number));
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
        }
    }
}
