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
            string actual = Dice.WelcomeJungle();
            // Console.WriteLine("Program welcomes you to the Jungle");
            Assert.AreEqual(expected, actual, false, "This is not connecting");
        }

        [TestMethod]
        public void RollingDieGivesNum1to6()
        {
            // Arrange
            int[] possibleResults = {1,2,3,4,5,6};

            // Act
            int rollResult = Dice.Roll();
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
            int[] actual = Dice.RollDice(2, true);
            int actualLength = actual.Length;

            // Assert
            Assert.AreEqual(expectedLength, actualLength, "You did not throw two dice");
            CollectionAssert.AreEqual(expected, actual, "The thrown dice are not equal");
        }
    }
}
