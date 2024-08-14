using System;
namespace ConAppAnonymousMethod
{
    public delegate void OurDel(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
           
            OurDel del = delegate (int num)
            {
                Console.WriteLine("Number befor increment is: \t " + num);
                num += 5;
                Console.WriteLine("Number after increment is: \t "+num);

            };

            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            del(number);
            Console.ReadKey();  
        }
    }
}
