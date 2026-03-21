using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid option. Please try another choice (1-5).");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("\nWrite your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response; // ✅ FIXED

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }
    }
}
