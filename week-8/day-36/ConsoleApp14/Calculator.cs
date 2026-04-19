using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            }
            return a / b;

        }

        }
}
