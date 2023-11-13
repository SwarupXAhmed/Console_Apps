/*
 name: ahmed javed kamal
 class; comp sci 20
 description: guess the number
 */

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        int userGuess;

        Console.WriteLine("Welcome to the Number Guessing Game!");

        while (true)
        {
            Console.Write("Guess the number between 1 and 10: ");
            userGuess= Convert.ToInt32(Console.ReadLine());

        
             

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again. Your guess was incorrect.");
                }
          }
      
        
    }
}
