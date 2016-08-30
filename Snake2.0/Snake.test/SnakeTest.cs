using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Snake2._0;
using Assert = NUnit.Framework.Assert;

namespace Snake.test
{
    [TestFixture]
    public class SnakeTest
    {
        [TestCase(1, 1)]
        [TestCase(10, 10)]
        [TestCase(20, 10)]
        [TestCase(10, 20)]
        [TestCase(20, 10)]
        public void ShouldCreateGameArena(int xAxis, int yAxis)
        {
            //given
            ICreateGameArena createGameArena = new CreateGameArena();

            //when
            var arena = createGameArena.PrepareArenaToPlay(xAxis, yAxis);
            var firstArray = arena.Length;
            var secondArray = arena[0].Length;
            //then
            Assert.IsTrue(firstArray == xAxis);
            Assert.IsTrue(secondArray == yAxis);
        }
    }


}
