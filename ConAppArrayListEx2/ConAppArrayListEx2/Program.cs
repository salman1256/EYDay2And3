using System;
using System.Collections;

namespace ConAppArrayListEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            { 
            new Customer{ Id=1,Fname="Sam",Lname="Dicosta",ODLimit=900000,SSDate=new DateTime(day:19,month:10,year:2024)},
            new Customer{ Id=3,Fname="Leena",Lname="Goyal",ODLimit=700000,SSDate=new DateTime(day:23,month:10,year:2012)},
            new Customer{ Id=5,Fname="Gauri",Lname="Kaanti",ODLimit=450000,SSDate=new DateTime(day:12,month:09,year:2013)},
            new Customer{ Id=6,Fname="Rohan",Lname="Kapoor",ODLimit=500000,SSDate=new DateTime(day:02,month:02,year:2012)},
            new Customer{ Id=7,Fname="Vipin",Lname="Dhingar",ODLimit=360000,SSDate=new DateTime(day:12,month:02,year:2023)},
            new Customer{ Id=11,Fname="Naina",Lname="Mahajan",ODLimit=500000,SSDate=new DateTime(day:22,month:10,year:2012)},
            new Customer{ Id=12,Fname="Deep",Lname="Das",ODLimit=700000,SSDate=new DateTime(day:12,month:11,year:2012)},
            new Customer{ Id=19,Fname="Arsh",Lname="Maan",ODLimit=600000,SSDate=new DateTime(day:15,month:10,year:2021)},
            };
            Console.WriteLine("Number of Customers are: "+arrayList.Count);
            Console.WriteLine("ID \t Full Name \t ODLimit \t SStartDate");
            foreach (Customer customer in arrayList)
            { 
                Console.WriteLine(customer.Id +"\t"+customer.Fname +" "+customer.Lname +"\t"+customer.ODLimit +"\t \t"+(customer.SSDate).ToShortDateString());
            }
            Console.ReadKey();  
        }
    }
}
