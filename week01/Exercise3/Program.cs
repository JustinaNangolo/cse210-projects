using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        // Ask the user to guess a magic number between 1 and 100. If they guess too low, display "Higher". If they guess too high, display "Lower". If they guess it right, display "You guessed it!".
        Console.Write("What is the magic number? ");
        int magicNumber1 = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess1 = int.Parse(Console.ReadLine());

        if (guess1 < magicNumber1)
        {
            Console.WriteLine("Higher");
        }
        else if (guess1 > magicNumber1)
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
// PART 2: Loop Until Correct
        Console.Write("What is the magic number? ");
        int magicNumber2 = int.Parse(Console.ReadLine());
        int guess2 = -1; 

        while (guess2 != magicNumber2)
        {
            Console.Write("What is your guess? ");
            guess2 = int.Parse(Console.ReadLine());

            if (guess2 < magicNumber2)
            {
                Console.WriteLine("Higher");
            }
            else if (guess2 > magicNumber2)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

*/



// PART 3: Loop Until Correct with Option to Play Again


        string response = "yes";

        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber3 = randomGenerator.Next(1, 101);
            int guess3 = -1;

            while (guess3 != magicNumber3)
            {
                Console.Write("What is your guess? ");
                guess3 = int.Parse(Console.ReadLine());

                if (guess3 < magicNumber3)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess3 > magicNumber3)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("Do you want to play again (yes/no)? ");
            response = Console.ReadLine();
        }

    }
}

