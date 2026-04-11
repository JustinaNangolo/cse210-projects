using System;
// CREATIVITY: I added a level-up system based on score thresholds
// and a color-coded console for different goal types.
class Program
{
    static void Main(string[] args)
    {
    
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}