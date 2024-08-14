using System;

namespace ConAppAbstractEx
{
    public class OurClass : Calc
    {
        public OurClass(int _age) : base(_age)
        {
            Console.WriteLine("Child class Constructor");
        }

        public override double Add(double num1, double num2)
        {
            double result=num1 + num2;
            return result;
        }

        public override double Multi(double num1, double num2)
        {
            double result=num1 * num2;
            return result;
        }
    }
}
