using System;
using System.IO;

// CREATIVITY AND EXCEEDING REQUIREMENTS:
// 1. Added an Activity Log feature that persists to a file (activity_log.txt).
// 2. Added a menu option (4) to read and display this log directly in the program.
// 3. Implemented anti-repetition logic in the ReflectingActivity to ensure questions 
//    are not repeated until the full list has been used.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                DisplayLog();
            }
        }
    }

    static void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("-- Activity Log --");
        Console.WriteLine("------------------");

        string fileName = "activity_log.txt";

        if (File.Exists(fileName))
        {
            string[] logEntries = File.ReadAllLines(fileName);
            if (logEntries.Length == 0)
            {
                Console.WriteLine("The log is currently empty.");
            }
            else
            {
                foreach (string entry in logEntries)
                {
                    Console.WriteLine(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("No log file found. Complete an activity to start logging!");
        }

        Console.WriteLine("\nPress Enter to return to the main menu.");
        Console.ReadLine();
    }
}