using System;
namespace ConAppAbstractEx
{
    public abstract class Calc
    {
         readonly int age;
        public Calc(int _age)
        {
            Console.WriteLine("Abstract Class Consturctor!!!");
            age = _age; 
        }
        public int Age { get { return age;} }
        public string Welcome(string userName)
        {
            return "Welcome to Abstract Classes Mr.\\Ms. " + userName;
        }
        public abstract double Add(double num1, double num2);
        public abstract double Multi(double num1, double num2);
    }
}
