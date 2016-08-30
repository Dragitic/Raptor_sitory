using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake2._0.Snake
{
    internal class SnakePositionDispatcher
    {
        private readonly FieldType[][] _playGround;
        private readonly Random _random;
        private readonly SnakePosition _snakePosition;

        public SnakePositionDispatcher(FieldType[][] playGround)
        {
            _playGround = playGround;
            _random = new Random();
            _snakePosition = new SnakePosition();
        }
        public SnakePosition SetPosition()
        {
            RandomizeSnakePosition();
            CheckIfSnakePositionIsOnBoundaries();

            return _snakePosition;
        }
        public void AddSnakeToArena()
        {
            _playGround[_snakePosition.HeadCoordinates.X][_snakePosition.HeadCoordinates.Y] = FieldType.SnakePart;
        }
        private void CheckIfSnakePositionIsOnBoundaries()
        {
            if (_playGround[_snakePosition.HeadCoordinates.X][_snakePosition.HeadCoordinates.Y] != FieldType.Empty)
            {
                RandomizeSnakePosition();
            }
        }
        private void RandomizeSnakePosition()
        {
            int xPosition = _random.Next(_playGround.Length);
            int yPosition = _random.Next(_playGround[0].Length);
            _snakePosition.HeadCoordinates = new Coordinates(xPosition, yPosition);
        }
    }
}