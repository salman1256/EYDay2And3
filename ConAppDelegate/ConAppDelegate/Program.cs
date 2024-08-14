using System;

namespace ConAppDelegate
{
    public delegate string  OurDel(string userName);
    internal class Program
    {

        static void Main(string[] args)
        {
            OurClass ourClass = new OurClass();
            OurDel del=new OurDel(ourClass.Display);
            Console.WriteLine("Enter User Name");
            string userName=Console.ReadLine();
            //Invocation of delegate
            Console.WriteLine(del(userName));
            

            OurDel objDel = new OurDel(CricInfo);
            Console.WriteLine("Enter Winner");

            Console.WriteLine(objDel(Console.ReadLine())); 

            Console.ReadKey();
        }
        public static string CricInfo(string winner)
        {
            return "Winner of Today's Cricket match is: "+winner;
        }
    }
}
