using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _unusedQuestions = new List<string>();

    
    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.AddRange(new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        });

        _questions.AddRange(new string[] {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        });

        
        ResetQuestions();
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            
            ShowSpinner(8);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();

        
        if (_unusedQuestions.Count == 0)
        {
            ResetQuestions();
        }

        int index = random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index); 

        return question;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
    }

    private void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }

    private void ResetQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
    }
}