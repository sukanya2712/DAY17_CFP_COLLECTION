using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class LinkedList
    {
        public static void Linkedlista()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddFirst("Apple");
            linkedList.AddLast("Banana");
            linkedList.AddLast("Orange");

            // Insert an element at the beginning of the list
            linkedList.AddFirst("Mango");

            // Remove an element from the list
            linkedList.RemoveLast();

            // Get the first and last element in the list
            string firstElement = linkedList.First.Value;
            string lastElement = linkedList.Last.Value;

            // Display the elements in the list
            Console.WriteLine("LinkedList elements:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFirst element: " + firstElement);
            Console.WriteLine("Last element: " + lastElement);
        }
    }
}
