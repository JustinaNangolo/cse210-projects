/*
Scripture Memorizer Exceeding Expectations:
Added Multiple scriptures to the program and allowed the user to cycle through them. 
The user can choose to quit at any time, or continue until all scriptures are completed. 
After each scripture is completed, the full verse is shown again before moving on to the next one.
*/



using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"),

            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),

            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want")
        };

        foreach (Scripture scripture in scriptures)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden!");
                    break;

                }

                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    return;
                }

                scripture.HideRandomWords(3);
            }

            // Show full verse again
            Console.Clear();
            Console.WriteLine("Great job! Here's the full verse:\n");

            scripture.ShowAllWords();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to move to the next verse...");
            Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("All scriptures completed. Well done!");
    }
}
