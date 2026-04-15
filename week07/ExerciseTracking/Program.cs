class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity
        Running run = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycle = new Cycling("03 Nov 2022", 30, 12.0);
        Swimming swim = new Swimming("03 Nov 2022", 30, 20);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        // Iterate and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}