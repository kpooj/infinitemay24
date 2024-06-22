using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_interger
{
    class Program2
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Reverse the word
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            Console.WriteLine($"The reversed word is: {reversedWord}");
            Console.ReadLine();
        }
    }
}

