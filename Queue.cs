using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Queue
    {
        public static void Queuea() 
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue elements into the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Get the front element of the queue
            int frontElement = queue.Peek();

            // Dequeue elements from the queue
            int dequeuedElement = queue.Dequeue();

            // Check if the queue contains an element
            bool containsTwenty = queue.Contains(20);
            Console.WriteLine("Contains 20: " + containsTwenty);

            // Display the elements in the queue
            Console.WriteLine("Queue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFront element: " + frontElement);
            Console.WriteLine("Dequeued element: " + dequeuedElement);
        }
    }
}
