using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUsername();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userNumber, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program.");
    }
    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int userNumber, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your favorite number {userNumber} is {squareNumber}.");
    }
}