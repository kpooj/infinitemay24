﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_interger
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The words are the same.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The words are different.");
                Console.ReadLine();
            }
        }
    }
}
