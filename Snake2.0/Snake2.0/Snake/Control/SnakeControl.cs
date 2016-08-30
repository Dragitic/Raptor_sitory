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
        private List<int> _snakePosition;
        private List<int> _currentSakePosition;
        private int[][] _playGround;
        ConsoleKey _direction;
        public IEnumerable MoveSnake(int[][] playGround, ConsoleKey key)
        {
            _playGround = playGround;
            int x = _snakePosition[0];
            int y = _snakePosition[1];

            MoveToChoosenDirection(key, x, y);
            SetSnakeAssetInNewPosition(x, y);

            _snakePosition[0] = _xAxis;
            _snakePosition[1] = _yAxis;

            AddCurrentSnakePostionToList();

            yield return _playGround;
            yield return _currentSakePosition;
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
        public void SnakeHeadCoordinates(List<int> snakePosition)
        {
            _snakePosition = new List<int>();
            _snakePosition = snakePosition;
        }
        private void AddCurrentSnakePostionToList()
        {
            _currentSakePosition = new List<int>();
            _currentSakePosition.Add(_xAxis);
            _currentSakePosition.Add(_yAxis);
        }
        private void MoveToChoosenDirection(ConsoleKey key, int x, int y)
        {
            {
                switch (key)
                {
                    case ConsoleKey.A:
                        _xAxis = x - 1;
                        _yAxis = y;
                        break;
                    case ConsoleKey.W:
                        _xAxis = x;
                        _yAxis = y - 1;
                        break;
                    case ConsoleKey.D:
                        _xAxis = x + 1;
                        _yAxis = y;
                        break;
                    case ConsoleKey.S:
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
            _playGround[y][x] = 1;
            _playGround[_yAxis][_xAxis] = 2;
        }
    }
}