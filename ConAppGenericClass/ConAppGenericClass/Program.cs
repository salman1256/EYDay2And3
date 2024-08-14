using System;

namespace ConAppGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass<string> objs = new OurClass<string>("Sam");
            OurClass<int> obji = new OurClass<int>(12);
            OurClass<char> objc = new OurClass<char>('A');
            objs.Display();
            obji.Display();
            objc.Display();
            Console.ReadKey();  
        }
    }
}
