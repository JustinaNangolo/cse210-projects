using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber  = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Use numbers.Count to see how many items are in the list
        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = -1; // Assuming positive numbers, or use numbers[0]

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // If this number is greater than the current max, it becomes the new max
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

    }
}