using System;
namespace simpleDice
{
    public class Dice
    {
        public Dice()
        {
            this.TotalScore = 0;
            this.RollHistory = new int[0][];
        }

        public int TotalScore
        { get; set; }

        private int[][] rollHistory;

        public int[][] RollHistory
        {
            get { return rollHistory; }
            private set { rollHistory = value; }
        }

        private void SetRollHistory(int[] results)
        {
            //Console.WriteLine(RollHistory.Length);
            int currentHistoryLength = RollHistory.Length;
            int[][] newRollHistory = new int[currentHistoryLength + 1][];
            Array.Copy(RollHistory, newRollHistory, currentHistoryLength);
            newRollHistory[currentHistoryLength] = results;
            RollHistory = newRollHistory;
            //Console.WriteLine(RollHistory);
            //foreach (int[] setRoll in RollHistory)
            //{
            //    Console.Write("Roll: ");
            //    foreach (int ele in setRoll) Console.Write($"{ele}, ");
            //}
            //Console.WriteLine(RollHistory.Length);
        }

        public int Roll(bool test = false)
        {
            Random rnd = test ? new Random(1) : new Random();
            return rnd.Next(1, 6);
        }

        public int[] RollDice(int numDice,out int rollScore, bool test = false)
        {
            int[] results = new int[numDice];
            for (int i = 0; i < numDice; i++)
            {
                results[i] = Roll(test);
            }

            rollScore = 0;
            foreach (int num in results)
            {
                rollScore += num;
            }
            TotalScore += rollScore;

            SetRollHistory(results);

            //Console.WriteLine(RollHistory.Length);
            //int currentHistoryLength = RollHistory.Length;
            //int[][] newRollHistory = new int[currentHistoryLength + 1][];
            //Array.Copy(RollHistory, newRollHistory, currentHistoryLength);
            //newRollHistory[currentHistoryLength] = results;
            //RollHistory = newRollHistory;
            //Console.WriteLine(RollHistory);
            //foreach (int[] setRoll in RollHistory)
            //{
            //    Console.Write("Roll: ");
            //    foreach (int ele in setRoll) Console.Write($"{ele}, ");
            //}


            return results;
        }
    }
}
