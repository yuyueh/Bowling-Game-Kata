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
    }
}
