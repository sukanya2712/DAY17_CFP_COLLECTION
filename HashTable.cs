using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTable
    {
        public static void HashTablea() 
        {
            Hashtable hashtable = new Hashtable();

            
            hashtable.Add("Name", "John");
            hashtable.Add("Age", 25);
            hashtable.Add("City", "New York");

            
            bool containsAge = hashtable.ContainsKey("Age");
            Console.WriteLine("Contains key 'Age': " + containsAge);

            // Get the value associated with a key
            object nameValue = hashtable["Name"];

            
            hashtable.Remove("City");

            // Display 
            Console.WriteLine("Hashtable elements:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
            }

            Console.WriteLine("\nValue for key 'Name': " + nameValue);
        }
    }
}
