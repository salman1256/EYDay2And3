using System;
namespace ConAppInterface
{
    public class OurClass : IMynterface
    {
        int age;
        public int Age { get =>age; set => age=value; }

        public void Display()
        {
            Console.WriteLine("Welcome to OurClass Display");
        }
    }
}
