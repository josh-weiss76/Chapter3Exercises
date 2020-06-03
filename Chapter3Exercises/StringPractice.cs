using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Exercises
{
    class StringPractice
    {
        public static string[] StringSplitSpace(string input)
        {
            string[] output = input.Split(' ');
            Console.WriteLine(string.Join(",", output));
            return output;
        }
        public static string[] StringSplitPeriod(string input)
        {
            string[] output = input.Split('.');
            Console.WriteLine(string.Join(",", output));
            return output;
        }
    }
}
