using System;

class Program
    {
        static void Main(string[] args)
        {
        // --- PART 1: Core Requirements 1-3 (Single Guess) ---
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}



// --- PART 2: Adding the Loop ---
/*
    Console.Write("What is the magic number? ");
    int magicNumber = int.Parse(Console.ReadLine());

    int guess = -1; // Initialize with a value that won't match

    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {   
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}

*/

/*
       // --- PART 3

       string playAgain = "yes";

       while (playAgain.ToLower() == "yes")
       {
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1, 101);

           int guess = -1;
           int count = 0;

           while (guess != magicNumber)
           {
               Console.Write("What is your guess? ");
               guess = int.Parse(Console.ReadLine());
               count++;

               if (guess < magicNumber)
               {
                   Console.WriteLine("Higher");
               }
               else if (guess > magicNumber)
               {
                   Console.WriteLine("Lower");
               }
               else
               {
                   Console.WriteLine("You guessed it!");
               }
           }

           Console.WriteLine($"It took you {count} guesses.");
           Console.Write("Do you want to play again (yes/no)? ");
           playAgain = Console.ReadLine();
       }

   }
}
*/