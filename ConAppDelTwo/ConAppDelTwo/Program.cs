using System;
namespace ConAppDelTwo
{
    public delegate void OurDel(double fnum, double snum);
    internal class Program
    {
       
        static void Main(string[] args)
        {
            OurDel del = new OurDel(Calculator.Add);
            Console.WriteLine("Delegate Call when it have one method in invocation list");
            del(12.50, 6.25);
            // to add method in invocation list  of delegate +=
            del += new OurDel(Calculator.Avg);
            Console.WriteLine("Call when it has 2 methods");
            del(12.50, 6.25);
            del += new OurDel(Calculator.Multi);
            del += new OurDel(Calculator.Multi);
            del += new OurDel(Calculator.Div);
            del += new OurDel(Calculator.Diff);
            Console.WriteLine("Invocaion of delegate when it has 6 methods");
            del(12.50, 6.25);

            //to remove a method from invocation list -=
            del -= new OurDel(Calculator.Avg);
            Console.WriteLine("Invocaion of delegate when we removed the Avg from Invocation list");
            del(12.50, 6.25);
            del-=new OurDel(Calculator.Multi);
            Console.WriteLine("Invocaion of delegate when we removed the Muti from Invocation list");
            del(12.50, 6.25);
            Console.ReadKey();
        }
    }
}
