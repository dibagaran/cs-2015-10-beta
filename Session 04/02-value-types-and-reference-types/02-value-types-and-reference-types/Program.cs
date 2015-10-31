using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // This is a value type.
            int[] j = new int[10]; // All arrays are reference types.

            ValueTypeTest(i);
            Console.WriteLine(i); // The output is 0 because just a copy of value is passed to the method.

            ReferenceTypeTest(j);
            Console.WriteLine(j[0]); // The output is 1 because a copy of reference is passed to the method.

            ValueTypeByRefTest(ref i);
            Console.WriteLine(i); // The output is 1 because the value is passed by reference.
        }

        static void ValueTypeTest(int param)
        {
            param++;
        }

        static void ReferenceTypeTest(int[] param)
        {
            param[0]++;
        }

        static void ValueTypeByRefTest(ref int param)
        {
            param++;
        }
    }
}
