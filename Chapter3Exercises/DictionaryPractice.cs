using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chapter3Exercises
{
    class DictionaryPractice
    {
        public static Dictionary<int, string> CreateStudentDictionary()
        {
            Dictionary<int, string> classList = new Dictionary<int, string>();
            string studentName;

            Console.WriteLine("Enter the student ID number (or Enter to finish): ");

            do
            {
                Console.WriteLine("Student name: ");
                string input = Console.ReadLine();
                studentName = input;

                if (!Equals(studentName, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    int studentID = int.Parse(input);
                    classList.Add(studentID, studentName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(studentName, ""));

            return classList;
        }
    }
}
