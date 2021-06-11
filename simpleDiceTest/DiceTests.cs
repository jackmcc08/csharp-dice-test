using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleDice;


namespace simpleDiceTest
{
    [TestClass]
    public class simpleTests
    {
        [TestMethod]
        public void WelcomeJungleTest()
        {
            // Dice test = new Dice();
            string expected = "Welcome to the Jungle!";
            string actual = Program.WelcomeJungle();
            // Console.WriteLine("Program welcomes you to the Jungle");
            Assert.AreEqual(expected, actual, false, "This is not connecting");
        }

        [TestMethod]
        public void RollingDieGivesNum1to6()
        {
            // Arrange
            int[] possibleResults = {1,2,3,4,5,6};

            // Act
            Dice testDice = new Dice();
            int rollResult = testDice.Roll();
            bool rollBetween1to6 = possibleResults.Contains(rollResult);
            // Assert
            Assert.IsTrue(rollBetween1to6, "Roll function is not returning a result between 1 and 6");
        }

        [TestMethod]
        public void CanRollAnyNumberOfDie_RollTwoDie()
        {
            // Arrange
            int[] expected = new int[] { 2, 2 };
            int expectedLength = expected.Length;


            // Act
            Dice testDice = new Dice();
            int[] actual = testDice.RollDice(2, out int rollScore, true);
            int actualLength = actual.Length;

            // Assert
            Assert.AreEqual(expectedLength, actualLength, "You did not throw two dice");
            CollectionAssert.AreEqual(expected, actual, "The thrown dice are not equal");
        }

        [TestMethod]
        public void CalculateTotalOfRolls()
        {
            // Arrange
            int expected = 12;

            // Act
            Dice testDice = new Dice();
            testDice.RollDice(2, out int rollScore, true);
            testDice.RollDice(3, out int rollScore2, true);
            testDice.RollDice(1, out int rollScore3, true);

            // Assert
            Assert.AreEqual(expected, testDice.TotalScore, "these rolls are not the same");
        }

        [TestMethod]
        public void CanRollThreeSetsOfDice_AndStoreResults()
        {
            // Arrange
            int[][] expectedArray = new int[3][];
            expectedArray[0] = new int[] { 2 };
            expectedArray[1] = new int[] { 2 };
            expectedArray[2] = new int[] { 2 };
            int expectedLength = expectedArray.Length;

            // Act
            Dice testDice = new Dice();
            testDice.RollDice(1, out int rollScore, true);
            testDice.RollDice(1, out int rollScore2, true);
            testDice.RollDice(1, out int rollScore3, true);
            //int[][] actualArray = testDice.RollHistory;
            int actualLength = testDice.RollHistory.Length;



            // Assert
            Assert.AreEqual(expectedLength, actualLength, "the arrays are not the same length");
            //CollectionAssert.AreEqual(expectedArray, testDice.RollHistory, $"The Array history is not the same {expectedArray[0][0]}, actual {testDice.RollHistory[0][0]}");

        }
    }
}
