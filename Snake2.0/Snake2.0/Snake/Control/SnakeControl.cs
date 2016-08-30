using System;
using System.Collections;
using System.Collections.Generic;
using Snake2._0.Snake;

namespace Snake2._0
{
    public class SnakeControl : ISnakeControl
    {
        private int _xAxis;
        private int _yAxis;
        private SnakePosition _snakePosition;
        private FieldType[][] _playGround;
        ConsoleKey _direction;

        public SnakePosition MoveSnake(FieldType[][] playGround, ConsoleKey key)
        {
            _playGround = playGround;
            int x = _snakePosition.HeadCoordinates.X;
            int y = _snakePosition.HeadCoordinates.Y;

            MoveToChoosenDirection(key, x, y);
            SetSnakeAssetInNewPosition(x, y);

            _snakePosition.HeadCoordinates.X = _xAxis;
            _snakePosition.HeadCoordinates.Y = _yAxis;

            return _snakePosition;
        }

        public ConsoleKey SnakeControlKeys(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.KeyChar)
            {
                case 'w':
                    _direction = ConsoleKey.W;
                    break;
                case 's':
                    _direction = ConsoleKey.S;
                    break;
                case 'a':
                    _direction = ConsoleKey.A;
                    break;
                case 'd':
                    _direction = ConsoleKey.D;
                    break;
            }
            return _direction;
        }
        public void SnakeHeadCoordinates(SnakePosition snakePosition)
        {
            _snakePosition = new SnakePosition();
            _snakePosition = snakePosition;
        }

        private void MoveToChoosenDirection(ConsoleKey key, int x, int y)
        {
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        _xAxis = x - 1;
                        _yAxis = y;
                        break;
                    case ConsoleKey.A:
                        _xAxis = x;
                        _yAxis = y - 1;
                        break;
                    case ConsoleKey.S:
                        _xAxis = x + 1;
                        _yAxis = y;
                        break;
                    case ConsoleKey.D:
                        _xAxis = x;
                        _yAxis = y + 1;
                        break;
                    default:
                        _xAxis = x;
                        _yAxis = y;
                        break;
                }
            }
        }
        private void SetSnakeAssetInNewPosition(int x, int y)
        {
            _playGround[_xAxis][_yAxis] = FieldType.SnakePart;
        }
    }
}