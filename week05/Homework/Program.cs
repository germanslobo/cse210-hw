// Program.cs
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1: Base Assignment
            Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment1.GetSummary());

            Console.WriteLine(); // Blank line for output readability

            // Test 2: Math Assignment
            MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());

            Console.WriteLine();

            // Test 3: Writing Assignment
            WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(assignment3.GetSummary());
            Console.WriteLine(assignment3.GetWritingInformation());
        }
    }
}