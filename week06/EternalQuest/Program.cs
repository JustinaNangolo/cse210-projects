using System;
/*
EXCEEDING REQUIREMENTS:
  1. Added error handling in LoadGoals to prevent program crashes if a filename is mistyped or missing and 
  
  
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}