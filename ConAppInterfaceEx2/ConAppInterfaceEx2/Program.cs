using System;
namespace ConAppInterfaceEx2
{
    internal class Program:IOne,ITwo
    {
        static void Main(string[] args)
        {
            //OurClass ourClass = new OurClass();
            //ourClass.Display("Display is perfectly fine");
            //ourClass.Welcome("We are happy to welcome you ");
            //Console.ReadKey();
            //OurClass obj= new OurClass();
            //ITwo obji2 = obj;
            //IOne obji1 = obj;
            //obji2.Display("Welcome");
            //obji1.Display("Thanks!!!");
            IOne one=new Program();
            one.Display("From Program calling interface one display");
            ITwo two=new Program();
            two.Display("Welcome Again!!!");
            Console.ReadKey();

            //TeaBreak till 11:15
            
        }

        void IOne.Display(string message)
        {
            Console.WriteLine("Ione: "+message);
        }

        void ITwo.Display(string message)
        {
            Console.WriteLine("ITwo: "+message);
        }
    }
}
