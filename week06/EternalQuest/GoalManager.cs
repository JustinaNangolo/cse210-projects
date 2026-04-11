using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1") _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        goal.RecordEvent();

        int earned = goal.GetPoints();
        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            earned += checklist.GetBonus();
        }

        _score += earned;
        Console.WriteLine($"Congratulations! You have earned {earned} points!");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals) sw.WriteLine(g.GetStringRepresentation());
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            try
            {
                _goals.Clear();

                string[] lines = File.ReadAllLines(file);
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string type = parts[0];
                    string[] data = parts[1].Split(',');

                    if (type == "SimpleGoal")
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                    else if (type == "EternalGoal")
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    else if (type == "ChecklistGoal")
                        _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                }
                Console.WriteLine("Goals loaded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("\n[Error] File not found. Please check the name and try again.");
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}