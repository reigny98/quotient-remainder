using System;

namespace quotient_remainder
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                int dividend = 30;
                int divisor = 7;
                int remainder;
                int quotient = Math.DivRem(dividend, divisor, out remainder);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            
        }
    }
}
