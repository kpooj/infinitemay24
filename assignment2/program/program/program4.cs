using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public static class program4
    {
        public static int MarksValue()
        {
            int[] marks = new int[10];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            int totalMarks = marks.Sum();

            return totalMarks;
        }
    }
}
