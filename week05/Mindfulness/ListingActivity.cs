public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            // This is tricky: ReadLine blocks. If time runs out while typing, it still finishes the line.
            string input = Console.ReadLine();
            userList.Add(input);
        }

        Console.WriteLine($"You listed {userList.Count} items!");
        DisplayEndingMessage();
    }
}