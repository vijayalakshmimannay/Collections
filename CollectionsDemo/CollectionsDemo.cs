using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class CollectionsDemo
    {
        public void Dictionary()
        {
            Console.WriteLine("\nIn Dictionary");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(100, "Vijaya");
            dictionary.Add(101, "Lakshmi");
            dictionary.Add(102, "Mannay");

            Console.WriteLine("Access value using key(key=100): " + dictionary[102]);

            Console.WriteLine("\nIterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " & Value =" + element.Value);
            }
        }
        public void Set()
        {
            Console.WriteLine("\nIn Set");

            var Set = new HashSet<String>();
            Set.Add("Laxmi");
            Set.Add("Harsha");
            Set.Add("Ramesh");
            Set.Add("Sita");

            HashSet<String>.Enumerator enumerator = Set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public void Queue()
        {
            Console.WriteLine("\nIn Queue");

            //Creating Queue
            Queue<String> queue = new Queue<String>();
            queue.Enqueue("Vijaya");
            queue.Enqueue("Lokesh");
            queue.Enqueue("Satya");
            queue.Enqueue("Paru");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            // Iterating Queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element");

            // Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public void Stack()
        {
            Console.WriteLine("\nIn Stack");
            //Creating Stack
            Stack<String> stack = new Stack<String>();
            stack.Push("Vijaya");
            stack.Push("Lakshmi");
            stack.Push("Talluri");
            stack.Push("Harsha");
            stack.Push("Talluri");
            string pop = stack.Pop();

            // Iterating stck elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);

        }
        public void List()
        {
            Console.WriteLine("\nIn List");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Lokesh");
            list.Add("Vijaya");
            list.Add("Harsha");
            list.Add("Satya");

            //Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
    }
}

