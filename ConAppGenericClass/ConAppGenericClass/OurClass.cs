using System;
namespace ConAppGenericClass
{
    public class OurClass<T>
    {
        T ourField;
        public OurClass(T param)
        {
            ourField = param;
        }
        public void Display()
        {
            Console.WriteLine("Value stored inside field is: \t"+ourField );
            Console.WriteLine("DataType of our field is : \t" + ourField.GetType());
        }
    }
}
