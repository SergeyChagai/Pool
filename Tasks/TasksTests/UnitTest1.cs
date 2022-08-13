using NUnit.Framework;
using System;
using Tasks.Task1;

namespace TasksTests
{
    public class Tests
    {
        private Game sut;

        [SetUp]
        public void Setup()
        {
            sut = Game.generateGame();
        }

        [Test]
        public void Test1()
        {
            //Arrange

            //Act
            var actual = sut.getScore(20000);
            sut.printGameStamps();
            Console.WriteLine($"Find: {actual.home} - {actual.away}" );

            //Assert
            Assert.Pass();
        }
    }
}