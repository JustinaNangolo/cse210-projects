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

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

