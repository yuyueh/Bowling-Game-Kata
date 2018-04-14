using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BowlingGameKata.UnitTests
{
    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void Test_Rolling_Zero_Pin_Score_Zero()
        {
            // Arrange
            var expect = 0;
            var _target = new BowlingGame();

            // Act
            for (int i = 0; i < 20; i++)
            {
                _target.roll(0);
            }
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
            for (int i = 0; i < 19; i++)
            {
                _target.roll(0);
            }
            var result = _target.score();

            // Assert
            Assert.That(result, Is.EqualTo(expect));
        }
    }
}
