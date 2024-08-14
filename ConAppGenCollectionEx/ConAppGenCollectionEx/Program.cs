using System;
using System.Collections.Generic;


namespace ConAppGenCollectionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> namelist = new List<string>() { "Arsh", "Sam", "Maan", "Ravi", "Deep" };
            //Console.WriteLine("Number of items in List \t"+namelist.Count);
            //Console.WriteLine("Capacity \t"+namelist.Capacity);
            //Console.WriteLine("Stored names");
            //foreach(string name in namelist) 
            //{ 
            //    Console.WriteLine(name);
            //}
            //namelist.Add("Amit");
            //Console.WriteLine("Adding a new name");
            //Console.WriteLine("Number of items in List \t" + namelist.Count);
            //Console.WriteLine("Capacity \t" + namelist.Capacity);
            //Console.WriteLine("Stored names");
            //foreach (string name in namelist)
            //{
            //    Console.WriteLine(name);
            //}
            //namelist.Clear();
            //Console.WriteLine("After Clear");
            //Console.WriteLine("Number of items in List \t" + namelist.Count);
            //Console.WriteLine("Capacity \t" + namelist.Capacity);
            //Console.WriteLine("Stored names");
            //foreach (string name in namelist)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                { 1,"Laptop"},{ 2,"Earbuds"},{ 5,"Webcam"},{ 4,"Earphone"} };
                Console.WriteLine("ID \t Product");
                foreach (int k in dictionary.Keys) 
                {
                Console.WriteLine(k + "\t " + dictionary[k]);
                }
            Console.ReadKey();
           
        }
    }
}
