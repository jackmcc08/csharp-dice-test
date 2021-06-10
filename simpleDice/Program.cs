using System;

namespace simpleDice
{
    public class Dice
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(WelcomeJungle());

            int numDice = 0;
            do
            {
                Console.Write("How many dice would you like to roll: ");
                string userInput = Console.ReadLine();
                int userInputInt;

                try
                {
                    userInputInt = Convert.ToInt32(userInput);
                } catch 
                {
                    Console.WriteLine("Please enter a positive whole number above 0. e.g. 4");
                    continue;
                }

                numDice = userInputInt;                    
            } while (numDice <= 0);

            Console.WriteLine($"You are going to roll {numDice} dice.");

            int[] resultRolls = RollDice(numDice);

            Console.WriteLine("You rolled:");
            foreach (int roll in resultRolls)
            {
                Console.Write($"{roll}, ");
            }


            //Console.WriteLine(Roll());
            //Array.ForEach(RollDice(2), Console.WriteLine);
            //Array.ForEach(RollDice(2, true), Console.WriteLine);
            //Console.WriteLine(RollDice(2));
            //Console.WriteLine(RollDice(2, true));
        }

        public static string WelcomeJungle()
        {
            return "Welcome to the Jungle!";
        }

        public static int Roll(bool test = false)
        {
            Random rnd = test ? new Random(1) : new Random();
            return rnd.Next(1,6);
        }

        public static int[] RollDice(int numDice, bool test = false)
        {
            int[] results = new int[numDice];
            for (int i = 0; i < numDice; i++)
            {
                results[i] = Roll(test);
            }
            return results;
        }
    }
}

