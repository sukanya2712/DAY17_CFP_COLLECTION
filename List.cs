using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class List
    {
        public static void Lista() 
        {
            List<string> list = new List<string>();

            list.Add("Apple");
            list.Add("Banana");
            list.Add("Orange");

            // Insert an element at a specific index
            list.Insert(1, "Mango");

            // Remove an element at a specific index
            list.RemoveAt(2);

            // Get the first and last element in the list
            string firstElement = list[0];
            string lastElement = list[list.Count - 1];

            // Check if an element exists in the list
            bool containsBanana = list.Contains("Banana");
            Console.WriteLine("Contains 'Banana': " + containsBanana);

            // Get the index of an element
            int index = list.IndexOf("Mango");
            Console.WriteLine("Index of 'Mango': " + index);

            // Sort the list 
            list.Sort();

            // Reverse the order 
            list.Reverse();

            // Display the elements 
            Console.WriteLine("List elements (sorted and reversed):");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("First element: " + firstElement);
            Console.WriteLine("Last element: " + lastElement);
        }
    }
}
