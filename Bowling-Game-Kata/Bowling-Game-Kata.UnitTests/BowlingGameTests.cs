using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata.UnitTests
{
    public class BowlingGameTests
    {
        private BowlingGameKata _target;

        [SetUp]
        public void SetUp()
        {
            _target = new BowlingGameKata();
        }

        [Test]
        public void Test_GattaGame()
        {
            // arrange
            var except = 0;

            // act
            RollMany(20, 0);

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
        }

        [Test]
        public void Test_Roll_All_One()
        {
            // arrange
            var except = 20;

            // act
            RollMany(20, 1);

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
        }

        [Test]
        public void Test_Perfect_Game()
        {
            // arrange
            var except = 300;

            // act
            RollMany(12, 10);

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
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
