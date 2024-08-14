using System;
using System.Collections;
namespace ConAppCollectionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList arrayList=new ArrayList ();
            Hashtable hashtable = new Hashtable() { { "HDD", "Hard Disc" }, { "FDD", "Floppy Disc" }, { "RAM", "Random Access Memory" }, { "CD", "Compact Disc" } };
            //Console.WriteLine("Number of items in Hashtable: "+hashtable.Count);
            //Console.WriteLine("Keys:");
            //foreach (string key in hashtable.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.WriteLine("Values:");
            //foreach (string v in hashtable.Values)
            //{
            //    Console.WriteLine(v);
            //}
            //Console.WriteLine("Key \t Value");
            //foreach (string key in hashtable.Keys)
            //{
            //    Console.WriteLine(key + "\t" + hashtable[key]);
            //}


            //SortedList sortedList=new SortedList () { { "HDD", "Hard Disc" }, { "FDD", "Floppy Disc" }, { "RAM", "Random Access Memory" }, { "CD", "Compact Disc" } };
            //Console.WriteLine("Output from Sorted List");
            //Console.WriteLine("Number of items in Sorted List: " + sortedList.Count);
            //Console.WriteLine("Key \t Value");
            //foreach (string key in sortedList.Keys)
            //{
            //    Console.WriteLine(key + "\t" + sortedList[key]);
            //}
            Queue queue=new Queue ();
            queue.Enqueue("Raj");
            queue.Enqueue("Ravi");
            queue.Enqueue("Anant");
            queue.Enqueue("Vijay");
            Console.WriteLine($"Stored Items in Queue {queue.Count} are: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
               queue.Dequeue ();
            Console.WriteLine($" after removing one item Stored Items in Queue {queue.Count} are: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Result: "+queue.Peek());
            Console.WriteLine($" after peek Items in Queue {queue.Count} are: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Clear ();
            Console.WriteLine($"After clear number of items in Queue are:\t "+queue.Count);

            Stack stack = new Stack();
            stack.Push("Raj");
            stack.Push("Ravi");
            stack.Push("Anant");
            stack.Push("Vijay");
            Console.WriteLine($"Stored Items in stack {stack.Count} are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine($" after removing one item Stored Items in stack {stack.Count} are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Result: " + stack.Peek());
            Console.WriteLine($" after peek Items in stack {stack.Count} are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Clear();
            Console.WriteLine($"After clear number of items in stack are:\t " + stack.Count);
            Console.ReadKey();
        }
    }
}
