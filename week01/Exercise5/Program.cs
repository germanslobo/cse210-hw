using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        DisplayGreeting(userName);
        
        int squaredNumber = SquareNumber(userNumber);
        int cubedNumber = CubeNumber(userNumber);
        
        DisplayResult(userName, squaredNumber, cubedNumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    
    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static int CubeNumber(int number)
    {
        return number * number * number;
    }
    
    static void DisplayResult(string name, int squared, int cubed)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, the cube of your number is {cubed}");
    }
}