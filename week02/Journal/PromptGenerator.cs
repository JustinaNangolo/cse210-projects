using System;
using System.Collections.Generic;
using System.Linq;

public class PromptGenerator
{
    private Dictionary<string, List<string>> _promptsByCategory;
    private Random _rand = new Random();

    public PromptGenerator()
    {
        _promptsByCategory = new Dictionary<string, List<string>>()
        {
            { "Morning", new List<string> {
                "What are you grateful for this morning?",
                "What  do you want to achieve today?"
            }},
            { "Exercise", new List<string> {
                "How did you move your body today?",
                "What physical activity helped you feel better?"
            }},
            { "Hydration", new List<string> {
                "How did you take care of your body today?",
                "Did you stay hydrated, and how did it affect your productivity?"
            }},
            { "Emotions", new List<string> {
                "What emotions did you experience today?",
                "What influenced your feelings the most today?"
            }},
            { "Evening", new List<string> {
                "How did you spend your evening?",
                "What moment brought you peace or joy tonight?"
            }}
        };
    }

    public string GetRandomPrompt()
    {
        List<string> categories = new List<string>(_promptsByCategory.Keys);

        // pick ONE random category
        string randomCategory = categories[_rand.Next(categories.Count)];

        // pick ONE prompt from that category
        List<string> prompts = _promptsByCategory[randomCategory];
        string prompt = prompts[_rand.Next(prompts.Count)];

        return prompt;
    } 

}
