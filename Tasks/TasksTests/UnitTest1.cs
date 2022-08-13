using NUnit.Framework;
using System;
using System.Linq;
using Tasks.Task1;

namespace TasksTests
{
    [TestFixture]
    public class Tests
    {
        private Game sut;
        private GameStamp[] gameStamps;

        [SetUp]
        public void Setup()
        {
            sut = Game.generateGame();
            // gameStamps = typeof(Game).GetProperty("gameStamps")?.GetValue(sut) as GameStamp[];
            gameStamps = sut.gameStamps;
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(20000)]
        [TestCase(-20000)]
        [TestCase(50000)]
        [TestCase(200000)]
        public void Test1(int offset)
        {
            //Arrange
            var score = gameStamps?.FirstOrDefault(s => s.offset == offset).score;
            var expected = score ?? new Score();
            //Act
            var actual = sut.getScore(offset);
            sut.printGameStamps();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}