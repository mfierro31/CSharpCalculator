using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Choose an operator: ");
            string op = Console.ReadLine();
            
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                decimal d1 = Convert.ToDecimal(num1);
                decimal d2 = Convert.ToDecimal(num2);
                Console.WriteLine(d1 / d2);
            } else
            {
                Console.WriteLine("ERRRR!  You entered an invalid operator!  Try again, smarty pants!");
            }

                Console.ReadLine();
        }
    }
}
