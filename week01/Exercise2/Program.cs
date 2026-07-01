using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        
        // Determine letter grade
        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is: D");
        }
        else
        {
            Console.WriteLine("Your letter grade is: F");
        }
        
        // Check if passed (70 or higher)
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course! 🎉");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll get it next time. 💪");
        }
    }
}