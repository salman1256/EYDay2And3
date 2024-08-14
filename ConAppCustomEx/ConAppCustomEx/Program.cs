using System;
namespace ConAppCustomEx
{
   public class InvalidLuckyNumber:Exception
    {
        public InvalidLuckyNumber():base() { }
        public InvalidLuckyNumber(string msg) : base(msg) { }
        public InvalidLuckyNumber(string msg,Exception innerEx) : base(msg,innerEx) { }
    }

    internal class Program
    {
        public static void CheckLuckyNumber(int num)
        {
            if (num % 2 == 0)
            {
                throw new InvalidLuckyNumber("Lucky Number must be an odd Number"); }
           
        }
        static void Main(string[] args)
        {
            int luckyNum;
            try { Console.WriteLine("Enter your lucky Odd Number");
                luckyNum = Convert.ToInt32(Console.ReadLine());
                CheckLuckyNumber(luckyNum);
                Console.WriteLine("Your Lucky Odd Number is: "+luckyNum);

            }
            catch (FormatException fe) { Console.WriteLine("Format Exception: "+fe.Message); }
            catch (InvalidLuckyNumber ex)
            { Console.WriteLine("Invalid Lucky Number Exception: "+ex.Message); }
            catch (Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
            finally {
                Console.ReadKey();
            }
        }
    }
}
