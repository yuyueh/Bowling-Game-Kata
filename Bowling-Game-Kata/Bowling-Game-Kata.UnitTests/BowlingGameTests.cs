using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata.UnitTests
{
    public class BowlingGameTests
    {
        [Test]
        public void Test_GattaGame()
        {
            // arrange
            var _target = new BowlingGameKata();
            var except = 0;

            // act
            for (int i = 0; i < 20; i++)
            {
                _target.roll(0);
            }

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
        }

        [Test]
        public void Test_Roll_All_One()
        {
            // arrange
            var _target = new BowlingGameKata();
            var except = 20;

            // act
            for (int i = 0; i < 20; i++)
            {
                _target.roll(1);
            }

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
        }

        [Test]
        public void Test_Perfect_Game()
        {
            // arrange
            var _target = new BowlingGameKata();
            var except = 300;

            // act
            for (int i = 0; i < 12; i++)
            {
                _target.roll(10);
            }

            var result = _target.score();

            // assert
            Assert.That(result, Is.EqualTo(except));
        }
    }
}
