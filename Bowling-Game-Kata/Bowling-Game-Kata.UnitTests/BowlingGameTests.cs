using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BowlingGameKata.UnitTests
{
    [TestFixture]
    public class BowlingGameTests
    {
        BowlingGame _target;

        [SetUp]
        public void SetUp()
        {
            _target = new BowlingGame();
        }

        [Test]
        public void Test_Rolling_Zero_Pin_Score_Zero()
        {
            // Arrange
            var expect = 0;
            var _target = new BowlingGame();

            // Act
            RollMany(19, 0);
            var result = _target.score();

            // Assert
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void Test_Rolling_One_Pin_Score_One()
        {
            // Arrange
            var expect = 1;
            var _target = new BowlingGame();

            // Act
            _target.roll(1);
            RollMany(19, 0);
            var result = _target.score();

            // Assert
            Assert.That(result, Is.EqualTo(expect));
        }

        private void RollMany(int count, int pin)
        {
            for (int i = 0; i < count; i++)
            {
                _target.roll(pin);
            }
        }
    }
}
