using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Stack
    {
        public static void Stacka() 
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Orange");

            // top element 
            string topElement = stack.Peek();

            // Pop elements
            string poppedElement = stack.Pop();

            //contains 
            bool containsBanana = stack.Contains("Banana");
            Console.WriteLine("Contains 'Banana': " + containsBanana);

            // Display the elements 
            Console.WriteLine("Stack elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Top element: " + topElement);
            Console.WriteLine("Popped element: " + poppedElement);
        }
    }
}
