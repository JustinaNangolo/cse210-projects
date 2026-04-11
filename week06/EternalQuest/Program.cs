using System;
/*
EXCEEDING REQUIREMENTS:
  Added error handling in LoadGoals to prevent program crashes if a filename is mistyped or missing.
  
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}