using System;
using Fractions;
class Program
{
    static void Main(string[] args)
    {
        // Test 1: First constructor (no parameters -> 1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test 2: Second constructor (one parameter -> 5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test 3: Third constructor (two parameters -> 3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test 4: Passing 1/3
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test 5: Verifying Getters and Setters
        Console.WriteLine("\n--- Testing Getters and Setters ---");
        Fraction testFraction = new Fraction();
        testFraction.SetTop(6);
        testFraction.SetBottom(7);
        Console.WriteLine($"New Top using Getter: {testFraction.GetTop()}");
        Console.WriteLine($"New Bottom using Getter: {testFraction.GetBottom()}");
        Console.WriteLine($"Result: {testFraction.GetFractionString()}");
    }
}