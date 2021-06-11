using System;
namespace simpleDice
{
    public class Dice
    {
        public Dice()
        {
        }

        public int Roll(bool test = false)
        {
            Random rnd = test ? new Random(1) : new Random();
            return rnd.Next(1, 6);
        }

        public int[] RollDice(int numDice, bool test = false)
        {
            int[] results = new int[numDice];
            for (int i = 0; i < numDice; i++)
            {
                results[i] = Roll(test);
            }

            //foreach (int num in results)
            //{
            //    Dice.totalRollsScore += num;
            //}

            return results;
        }
    }
}
