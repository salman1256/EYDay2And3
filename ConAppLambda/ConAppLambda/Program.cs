using System;
namespace ConAppLambda
{
    public delegate void OurDel(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            OurDel del = (n)=>
            {
                Console.WriteLine("Number befor increment is: \t " + n);
                n += 5;
                Console.WriteLine("Number after increment is: \t " + n);

            };

            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            del(number);
            Console.ReadKey();
        }
    }
}
