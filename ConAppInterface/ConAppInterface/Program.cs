using System;
namespace ConAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            obj.Age = 15;
            Console.WriteLine("Age is: "+obj.Age);
            obj.Display();
            Console.ReadKey();
        }
    }
}
