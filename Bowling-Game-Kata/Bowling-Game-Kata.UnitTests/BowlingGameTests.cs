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

        [Test]
        public void Test_Rolling_With_Spare()
        {
            // Arrange
            var expect = 14; // ( 5 + 5 ) + 2 + 2 + 0...
            var _target = new BowlingGame();

            // Act
            _target.roll(5);
            _target.roll(5);
            _target.roll(2);
            RollMany(17, 0);
            var result = _target.score();

            // Assert
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void Test_Rolling_With_Strike()
        {
            // Arrange
            var expect = 18; // ( 10 ) + 2 + 2 + 0...
            var _target = new BowlingGame();

            // Act
            _target.roll(10);
            _target.roll(2);
            _target.roll(2);
            RollMany(16, 0);
            var result = _target.score();

            // Assert
            Assert.That(result, Is.EqualTo(expect));
        }

        private void RollMany(int count, int pins)
        {
            for (int i = 0; i < count; i++)
            {
                _target.roll(pins);
            }
        }
    }
}
