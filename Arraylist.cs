using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Arraylist
    {
        public static void Arraylista()
        {
            ArrayList list = new ArrayList();

            
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Orange");

            // Insert an element at  index
            list.Insert(1, "Mango");

            // Remove an element at index
            list.RemoveAt(2);

            // Get the first and last element in the list
            object firstElement = list[0];
            object lastElement = list[list.Count - 1];

            // Display 
            Console.WriteLine("ArrayList elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("First element: " + firstElement);
            Console.WriteLine("Last element: " + lastElement);
        }
    }
}
