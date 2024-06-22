first program 

using System;

namespace SumTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                int tripleSum = 3 * sum;
                Console.WriteLine($"The triple of the sum is: {tripleSum}");
            }
            else
            {
                Console.WriteLine($"The sum is: {sum}");
            }
        }
    }
}
