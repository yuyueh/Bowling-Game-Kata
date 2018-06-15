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
            RollMany(20, 1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_RollOneSpare()
        {
            // Arrange
            var expected = 17; // (5 + 5 + 2) + 2 + 3

            // Act
            _target.Roll(5);
            _target.Roll(5);
            _target.Roll(2);
            _target.Roll(3);
            RollMany(16, 0);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_RollOneStrike()
        {
            // Arrange
            var expected = 20; // (10 + 5) + 2 + 3

            // Act
            _target.Roll(10);
            _target.Roll(2);
            _target.Roll(3);
            RollMany(17, 0);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_PerfectGame()
        {
            // Arrange
            var expected = 300;

            // Act
            RollMany(12, 10);
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
