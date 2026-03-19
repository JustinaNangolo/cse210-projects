using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What are you grateful for this morning, and what intentions do you have for today?",
        "How did you take care of your body today, and how did it make you feel?",
        "What emotions did you experience today, and what influenced them?",
        "How did you spend your evening, and what moments felt meaningful?",
        "What is one moment from today that you want to remember and why?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
