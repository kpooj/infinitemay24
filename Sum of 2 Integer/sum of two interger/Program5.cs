using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_interger
{
    internal class Program5
    {
        static void Main()
        {
            // Initialization of required array
            int[] sourceArray = { 1, 2, 3, 4, 5 };

            // Create a new array with the same length as the source array
            int[] targetArray = new int[sourceArray.Length];

            // Copy elements from the source array to the target array
            for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i];
            }

            // Print the elements of the target array
            Console.WriteLine("Copied elements:");
            Console.ReadLine();
            foreach (int element in targetArray)
            {
                Console.Write(element + " ");
                Console.ReadLine();            }


        }
    }
}