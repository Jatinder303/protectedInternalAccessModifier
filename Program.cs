
using ProjectParent;
using System;

namespace protectedInternalAccessModifier
{
    class Program : Parent
    {
        // Main Method
        public static void Main(string[] args)
        {
            // Accessing value in another assembly 
            Program obj3 = new Program();

            // Member value is Accessible 
            obj3.value = 9;
            Console.WriteLine("Value = " + obj3.value);
        }
    }
}
