using System;
using System.Collections.Generic;

namespace Chapter3Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] practiceArray = { 1, 1, 2, 3, 5, 8 };
            Console.WriteLine(ArrayPractice.ArrayDisplay(practiceArray));
            string practice = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            StringPractice.StringSplitSpace(practice);
            StringPractice.StringSplitPeriod(practice);
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<string> stringList = new List<string> { "I", "would", "not", "could", "not", "in", "a", "box", "I", "would", "not", "could", "not", "with", "a", "fox", "I", "will", "not", "eat", "them", "in", "a", "house", "I", "will", "not", "eat", "them", "with", "a", "mouse" };
            Console.WriteLine(ListPractice.EvenNumberSum(numberList));
            ListPractice.WordLengthSearch(stringList);
            Dictionary<int, string> studentDictionary = DictionaryPractice.CreateStudentDictionary();
            foreach (KeyValuePair<int, string> student in studentDictionary)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
        }
    }
}
