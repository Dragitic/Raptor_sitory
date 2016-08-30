using System;
using System.Collections.Generic;
using Snake2._0.Snake.Behavior;

namespace Snake2._0.Snake
{
    public class SnakeBehavior : ISnakeBehavior
    {
        private FieldType[][] _playGround;
        private SnakePositionDispatcher _positionDispatcher;

        public SnakePosition SetSnakeStartPosition(FieldType[][] playGround)
        {
            _playGround = playGround;

            _positionDispatcher = new SnakePositionDispatcher(_playGround);
            var startPosition = _positionDispatcher.SetPosition();

            return startPosition;
        }
        public FieldType[][] SetCompletePlayGround()
        {
            try
            {
                _positionDispatcher.AddSnakeToArena();
            }
            catch (Exception)
            {
                Console.WriteLine("Nie ustawiono startowej pozycji węża [SnakePositionDispatcher().SetPosition");
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

        public void SnakeHitsBoundarys()
        {
            Console.Clear();
            Console.WriteLine("Game Over!!");
            Console.ReadKey();
            var exit = Environment.ExitCode;
            Environment.Exit(exit);
        }
    }
}