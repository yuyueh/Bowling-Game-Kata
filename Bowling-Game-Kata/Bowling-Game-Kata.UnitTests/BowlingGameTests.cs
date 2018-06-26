using NUnit.Framework;

namespace BowlingGameKata.UnitTests
{
    public class BowlingGameTests
    {
        [Test]
        public void Test_GutterGame()
        {
            // Arrange
            var target = new BowlingGame();
            var expected = 0;

            // Act
            for (int i = 0; i < 20; i++)
            {
                target.Roll(0);
            }
            var result = target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
