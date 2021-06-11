using System;
using System.Collections;

namespace simpleDice
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine(WelcomeJungle());

            Dice dice = new Dice();
            //Console.WriteLine(dice.Roll());
            //int[] result = dice.RollDice(2);
            //Array.ForEach(result, Console.WriteLine);

            int numDice = 0;
            do
            {
                Console.Write("How many dice would you like to roll: ");
                string userInput = Console.ReadLine();
                int userInputInt;

                try
                {
                    userInputInt = Convert.ToInt32(userInput);
                }
                catch
                {
                    Console.WriteLine("Please enter a positive whole number above 0. e.g. 4");
                    continue;
                }

                numDice = userInputInt;
            } while (numDice <= 0);

            Console.WriteLine($"You are going to roll {numDice} dice.");

            int[] resultRolls = dice.RollDice(numDice);

            Console.WriteLine("You rolled:");
            foreach (int roll in resultRolls)
            {
                Console.Write($"{roll}, ");
            }

            Console.WriteLine($"\nYour current score is: {dice.TotalScore}");
        }

        public static string WelcomeJungle()
        {
            return "Welcome to the Jungle!";
        }

    }
}

