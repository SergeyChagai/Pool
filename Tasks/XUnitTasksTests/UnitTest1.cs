using System;
using Tasks.Task1;
using Xunit;
using System.Linq;

namespace XUnitTasksTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(20000)]
        [InlineData(50000)]
        [InlineData(-1)]
        [InlineData(-20000)]
        [InlineData(200000)]
        public void GetScoreTest(int offset)
        {
            //Arrange
            var sut = Game.generateGame();
            var gameStamps = (GameStamp[])typeof(Game).GetProperty("gameStamps")?.GetValue(sut);
            var expected = gameStamps?.FirstOrDefault(s => s.offset == offset).score ?? new Score();
            
            //Act
            var actual = sut.getScore(offset);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
