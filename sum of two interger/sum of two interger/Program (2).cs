using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_interger
{
    internal class Program
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
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The sum is: {sum}");
                Console.ReadLine();
            }
        }
    }
}
