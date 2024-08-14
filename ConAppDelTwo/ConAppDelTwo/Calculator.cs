using System;
namespace ConAppDelTwo
{
    public static  class Calculator
    {
        public static void Add(double num1, double num2)
        {
            double result=num1 + num2;
            Console.WriteLine($"Result after adding {num1} and {num2} = \t {result}");
        }
        public static void Avg(double num1, double num2)
        {
            double result = (num1 + num2)/2;
            Console.WriteLine($"Average of {num1} and {num2} = \t {result}");
        }
        public static void Diff(double num1, double num2)
        {
            double result = num1 -num2;
            Console.WriteLine($"Result after subtracting {num2} from {num1} = \t {result}");
        }
        public static void Multi(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"Result after multiplying {num1} and {num2} = \t {result}");
        }
        public static void Div(double num1, double num2)
        {
            double result = num1 /num2;
            Console.WriteLine($"Result after dividing {num2} by {num1} = \t {result}");
        }

    }
}
