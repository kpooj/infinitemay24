using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_interger
{
    class Program1
   {
       static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;
            Console.WriteLine($"The length of the word '{word}' is {length}.");

            Console.ReadLine();
        }
    }
}
