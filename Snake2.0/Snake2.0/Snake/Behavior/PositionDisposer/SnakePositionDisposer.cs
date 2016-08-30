using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake2._0.Snake
{
    internal class SnakePositionDisposer
    {
        private readonly int[][] _playGroundAfterSetBoundaries;
        private readonly Random _random;
        private readonly List<int> _position;
        public SnakePositionDisposer(int[][] playGroundAfterSetBoundaries)
        {
            _playGroundAfterSetBoundaries = playGroundAfterSetBoundaries;
            _random = new Random();
            _position = new List<int>();
        }
        public List<int> SetSnakeStartPosition()
        {
            RandomizeSnakePosition();
            CheckIfSnakePositionIsOnBoundaries();

            return _position;
        }
        public int[][] AddSnakeToArena()
        {
            _playGroundAfterSetBoundaries[_position[1]][_position[0]] = 2;
            return _playGroundAfterSetBoundaries;
        }
        private void CheckIfSnakePositionIsOnBoundaries()
        {
            var foo = _playGroundAfterSetBoundaries.Where(x => x.Contains(0));
            try
            {
                if (_playGroundAfterSetBoundaries[_position[0]][_position[1]] != 2)
                {
                    RandomizeSnakePosition();
                }
            }
            catch (Exception)
            {
                CheckIfSnakePositionIsOnBoundaries();
            }
        }
        private void RandomizeSnakePosition()
        {
            int xPosition = _random.Next(_playGroundAfterSetBoundaries.Length);
            _position.Add(xPosition);

            int yPosition = _random.Next(_playGroundAfterSetBoundaries[0].Length);
            _position.Add(yPosition);
        }
    }
}