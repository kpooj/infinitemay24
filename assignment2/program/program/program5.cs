﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class program5
    {
        public static int length()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;
            Console.WriteLine($"The length of the word '{word}' is {length}.");
            Console.ReadLine();
            return length;
        }
    }
}
