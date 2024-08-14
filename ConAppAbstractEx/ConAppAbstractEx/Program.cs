using System;
namespace ConAppAbstractEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calc obj = new Calc(); Can'nt create instance of Abstract Class
            OurClass obj = new OurClass(21);
            obj.Welcome("Sam");
            Console.WriteLine("Result after addition: \t"+obj.Add(12.45,34.56));
            Console.WriteLine("Result after multiplication: \t"+obj.Multi(12.45, 34.56));
            Console.ReadKey();

        }
    }
}
