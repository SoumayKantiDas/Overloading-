using System;

namespace Overloading_
{
    class TestComplex
    {
        static void Main()
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(3, 4);
            //add two complex objects through the overloading plus operator:
            Complex sum = num1 + num2;
            // print the numbers and the sum using the overriden Tostring method:
            Console.WriteLine("Frist complex number: {0},num1");
            Console.WriteLine("The sum of the two numbers:{0}", sum);
        }
    }
}
