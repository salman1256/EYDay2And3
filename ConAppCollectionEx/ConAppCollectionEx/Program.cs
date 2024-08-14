using System;
using System.Collections;

namespace ConAppCollectionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList()
            //{ 1,"Sam","Ravi",new DateTime()};
            //Console.WriteLine("Number of items in arrary list are: "+arrayList.Count);
            //Console.WriteLine("Capacity of Array List : "+arrayList.Capacity);
            //Console.WriteLine("All Items are: ");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Sandeep");
            //Console.WriteLine("After adding one more item");
            //Console.WriteLine("Number of items in arrary list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of Array List : " + arrayList.Capacity);
            //Console.WriteLine("All Items are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Jai");
            //Console.WriteLine("After adding Jai");
            //Console.WriteLine("Number of items in arrary list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of Array List : " + arrayList.Capacity);
            //Console.WriteLine("All Items are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Deep");
            //arrayList.Add(1);
            //arrayList.Add('A');

            //Console.WriteLine("Adding 3 more items");
            //Console.WriteLine("Number of items in arrary list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of Array List : " + arrayList.Capacity);
            //Console.WriteLine("All Items are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            ArrayList arrayList = new ArrayList() { "Sam", "Ravi", "Anuj", "Arsh", "Zia", "Deep" };
            Console.WriteLine("Stored Names");
            foreach (var item in arrayList) {
                Console.WriteLine(item);
            }
            arrayList.Sort();
            Console.WriteLine("List in Ascending Order");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            Console.WriteLine("List in Dsc Order");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter Name to remove from ArrayList");
            string name=Console.ReadLine();
            if(arrayList.Contains(name))
            {
                arrayList.Remove(name);
                Console.WriteLine($"{name} has removed from list ");
            }
            else
            {
                Console.WriteLine("No such name exist");
            }
            Console.WriteLine("List as follows!!!");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
