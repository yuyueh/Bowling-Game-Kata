using NUnit.Framework;

namespace BowlingGameKata.UnitTests
{
    public class BowlingGameTests
    {

        private BowlingGame _target;

        [SetUp]
        public void SetUp()
        {
            _target = new BowlingGame();
        }

        [Test]
        public void Test_GutterGame()
        {
            // Arrange
            var expected = 0;

            // Act
            RollMany(20, 0);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_RollAllOne()
        {
            // Arrange
            var expected = 20;

            // Act
            for (int i = 0; i < 20; i++)
            {
                _target.Roll(1);
            }
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
        private void RollMany(int rollTimes, int pins)
        {
            for (int i = 0; i < rollTimes; i++)
            {
                _target.Roll(pins);
            }
        }
    }
}
