using System;
using System.Collections.Generic;
using Snake2._0.Snake.Behavior;

namespace Snake2._0.Snake
{
    public class SnakeBehavior : ISnakeBehavior
    {
        private int[][] _playGround;
        private SnakePositionDisposer _positionDisposer;
        public List<int> Set_X_YStartPosition(int[][] playGround)
        {
            _playGround = playGround;

            _positionDisposer = new SnakePositionDisposer(_playGround);
            var startPosition = _positionDisposer.SetSnakeStartPosition();

            return startPosition;
        }
        public int[][] SetCompletePlayGround()
        {
            try
            {
                _playGround = _positionDisposer.AddSnakeToArena();
            }
            catch (Exception)
            {
                Console.WriteLine("Nie ustawiono startowej pozycji węża [SnakePositionDisposer().SetSnakeStartPosition");
            }
            return _playGround;
        }
        public ISnakeControl SnakeControl()
        {
            ISnakeControl snakeControl = new SnakeControl();
            return snakeControl;
        }
        public void SnakeNextParts()
        {
            throw new System.NotImplementedException();
        }
        public void SnakeHitsBoundarys(int[][] completePlayground, List<int> currentSnakePosition)
        {
            if (completePlayground[currentSnakePosition[0]][currentSnakePosition[1]] == 0)
            {
                Console.Clear();
                Console.WriteLine("Game Over!!");
                Console.ReadKey();
                var exit = Environment.ExitCode;
                Environment.Exit(exit);
            }
        }
    }
}