using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegate
{
  public  class OurClass
    {
        public string Display(string name) {
            return "Welcome to OurClass Mr.\\Ms. "+name;
        }
        public string Display(string fname,string lname)
        {
            return "Welcome to OurClass Mr.\\Ms. " + fname +" "+lname;
        }
    }
}
