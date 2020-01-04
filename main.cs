using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you want to add, subtract, multiply, or divide these numbers? ");
            string answer = Console.ReadLine();
            if (answer.ToLower().Contains("add"))
            {
                Console.WriteLine(num1 + num2);
            } else if (answer.ToLower().Contains("subtract"))
            {
                Console.WriteLine(num1 - num2);
            } else if (answer.ToLower().Contains("multiply"))
            {
                Console.WriteLine(num1 * num2);
            } else if (answer.ToLower().Contains("divide"))
            {
                decimal d1 = Convert.ToDecimal(num1);
                decimal d2 = Convert.ToDecimal(num2);
                Console.WriteLine(d1 / d2);
            } else
            {
                Console.WriteLine("ERRRR!  WRONG ANSWER!  Try again, smarty pants!");
            }

                Console.ReadLine();
        }
    }
}
