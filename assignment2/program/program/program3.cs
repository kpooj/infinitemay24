﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class program3
    {
        public static int Avgcalc()
        {
            int[] numbers = new int[] { 11, 52, 43, 64, 97 };
            int valuesum = 0;

            foreach (int i in numbers)
            {
                valuesum += i;
            }
            return valuesum / numbers.Count();

        }
        public static int maxvalue()
        {
            int[] numbers = new int[] { 11, 52, 43, 64, 97 };
            int valuesum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > valuesum)
                {
                    valuesum = numbers[i];
                }
            }
            return valuesum;

        }

        public static int minvalue()
        {
            int[] numbers = new int[] { 11, 52, 43, 64, 97 };
            int valuesum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < valuesum)
                {
                    valuesum = numbers[i];
                }
            }
            return valuesum;

        }

    }
}
