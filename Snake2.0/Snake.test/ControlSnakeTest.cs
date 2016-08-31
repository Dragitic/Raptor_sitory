using System;
using System.Collections.Generic;
using NUnit.Framework;
using Snake2._0;
using Snake2._0.Snake;
using Snake2._0.Snake.Behavior;

namespace Snake.test
{
    //    public class ControlSnakeTest
    //    {
    //        readonly ICreateGameArena _createGameArena = new CreateGameArena();
    //        readonly IArenaRules _arenaRules = new ArenaRules();
    //        readonly ISnakeBehavior _snakeBehavior = new SnakeBehavior();
    //        readonly SnakeControl _moveSnake = new SnakeControl();

    //        private List<int> _snakePosition;
    //        private int[][] _playGround;
    //        private int _xAxis;
    //        private int _yAxis;

    //        [SetUp]
    //        public void Init()
    //        {
    //            var playGround = _createGameArena.PrepareArenaToPlay(30, 30);
    //            _playGround = _arenaRules.SetBoundaries(playGround);
    //            _snakePosition = _snakeBehavior.SetSnakeStartPosition(playGround);

    //            _xAxis = _snakePosition[0];
    //            _yAxis = _snakePosition[1];
    //        }

    //        [Test]              //TODO DODAĆ POZYCJĘ GŁOWY SNAKE'A

    //        public void ShouldBeSnakeOnArena()
    //        {
    //            //given
    //            int expected = 2;

    //            //When
    //            _playGround = _snakeBehavior.SetPlayGroundWithSnake();

    //            //Than
    //            Assert.AreEqual(expected, _playGround[_xAxis][_yAxis]);
    //        }

    //        [Test]
    //        public void ShouldMove_xAxisOneFieldToRight()
    //        {
    //            //given
    //            var expected = _xAxis + 1;
    //            var key = ConsoleKey.RightArrow;

    //            //When
    //            _playGround = _snakeBehavior.SetPlayGroundWithSnake();
    //            _moveSnake.MoveSnake(_playGround, key);

    //            //Than
    //            //Assert.IsTrue(_moveSnake.PlayGround[expected][_yAxis] == 2);
    //        }
    //        [Test]

    //        public void ShouldMove_xAxisOneFieldToLeft()
    //        {
    //            //given
    //            var expected = _xAxis - 1;
    //            var key = ConsoleKey.LeftArrow;

    //            //When
    //            _moveSnake.MoveSnake(_playGround, key);
    //            _playGround = _snakeBehavior.SetPlayGroundWithSnake();

    //            //Than
    //            //Assert.IsTrue(_moveSnake.PlayGround[expected][_yAxis] == 2);
    //        }

    //        [Test]
    //        public void ShouldMove_xAxisOneFieldToUp()
    //        {
    //            //given
    //            var expected = _yAxis - 1;
    //            var key = ConsoleKey.UpArrow;

    //            //When
    //            _moveSnake.MoveSnake(_playGround, key);
    //            _playGround = _snakeBehavior.SetPlayGroundWithSnake();

    //            //Than
    //            //Assert.IsTrue(_moveSnake.PlayGround[_xAxis][expected] == 2);
    //        }

    //        [Test]
    //        public void ShouldMove_xAxisOneFieldToDown()
    //        {
    //            //given
    //            var expected = _yAxis + 1;
    //            var key = ConsoleKey.DownArrow;

    //            //When
    //            _moveSnake.MoveSnake(_playGround, key);
    //            _playGround = _snakeBehavior.SetPlayGroundWithSnake();

    //            //Than
    //            //Assert.IsTrue(_moveSnake.PlayGround[_xAxis][expected] == 2);
    //        }

    //    }
}