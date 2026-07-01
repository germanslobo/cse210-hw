using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Collect numbers from the user
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            // Only add the number if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        // Check if the list has any numbers
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }
        
        // ============ CORE REQUIREMENTS ============
        
        // 1. Calculate the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        // 2. Calculate the average
        float average = (float)sum / numbers.Count;
        
        // 3. Find the maximum (largest) number
        int max = numbers[0]; // Start with the first number
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        // ============ STRETCH CHALLENGES ============
        
        // 4. Find the smallest positive number (closest to zero)
        int smallestPositive = int.MaxValue; // Start with a very large number
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        
        // 5. Sort the list
        numbers.Sort();
        
        // ============ DISPLAY RESULTS ============
        
        // Display core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
        // Display stretch challenge results
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        
        // Display the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}