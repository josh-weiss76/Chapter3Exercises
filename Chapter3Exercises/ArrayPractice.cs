using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Exercises
{
    public class ArrayPractice
    {
        public static int ArrayDisplay (int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return 0;
        }
    }
}
