using System;
namespace ConAppExceptionHandlingEx
{  internal class Program
    {  static void Main(string[] args)
        {   double fnum, snum;
            try
            {   Console.WriteLine("Enter first Number");
                fnum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                snum = double.Parse(Console.ReadLine());
                Console.WriteLine("choose operation 1. Add 2. for Div");
                int op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {  Console.WriteLine("Result after adding {0} and {1} =\t {2}", fnum, snum, Calculator.Add(fnum,snum));
                            break;
                        }
                    case 2:
                        { Console.WriteLine("Result after dividing {0} by {1} =\t {2}", fnum, snum, Calculator.Div(fnum, snum));
                            break;
                        }
                        default:
                        {  Console.WriteLine("Invalid Operation Choice!!!");
                            break;
                        }
                }

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception " + fe.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);

            }
           
            finally 
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
        }
    }
}
