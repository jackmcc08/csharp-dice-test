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

            //int[][] expectedArray = new int[3][];
            //expectedArray[0] = new int[] { 2, 2 };
            //expectedArray[1] = new int[] { 2, 2, 2 };
            //expectedArray[2] = new int[] { 2 };
            //foreach (int[] roll in expectedArray)
            //{
            //    foreach (int ele in roll) Console.Write($"{ele}, ");
            //    Console.Write("\n");
            //}
            //Dice testsDice = new Dice();
            //testsDice.RollDice(2, out int rollScore4, true);
            //testsDice.RollDice(3, out int rollScore2, true);
            //testsDice.RollDice(1, out int rollScore3, true);
            //foreach (int[] roll in testsDice.RollHistory)
            //{
            //    foreach (int ele in roll) Console.Write($"{ele}, ");
            //    Console.Write("\n");
            //}



            Dice dice = new Dice();
            string contRoll;

            do
            {
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

                int[] resultRolls = dice.RollDice(numDice, out int rollScore);

                Console.WriteLine("You rolled:");
                foreach (int roll in resultRolls)
                {
                    Console.Write($"{roll}, ");
                }
                Console.WriteLine($"\nYour roll score was: {rollScore}");
                Console.WriteLine($"\nYour total score is: {dice.TotalScore}");
                Console.WriteLine("Your roll history:");
                foreach (int[] roll in dice.RollHistory)
                {
                    foreach (int ele in roll) Console.Write($"{ele}, ");
                    Console.Write("\n");
                }

                Console.WriteLine("Would you like to roll again? Enter No to stop.");
                contRoll = Console.ReadLine();
            } while (contRoll != "No");
        }

        public static string WelcomeJungle()
        {
            return "Welcome to the Jungle!";
        }

    }
}

