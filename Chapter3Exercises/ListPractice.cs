using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Exercises
{
    class ListPractice
    {
        public static int EvenNumberSum(List<int> numberList)
        {
            int returnValue = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i]%2 == 0 )
                {
                    returnValue += numberList[i];
                }
            }
            return returnValue;
        }
        public static void WordLengthSearch(List<string> wordList)
        {
            Console.WriteLine("Please enter the word length you would like to use for the search: ");
            int searchLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Length == searchLength)
                {
                    Console.WriteLine(wordList[i]);
                }
            }
        }
    }
}
