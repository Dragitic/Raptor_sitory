using System;
using System.Linq;
using Snake2._0.Snake;

namespace Snake2._0
{
    public class ArenaRules : IArenaRules
    {
        private readonly Random _random;
        private FieldType[][] _playGround;
        private MealPosition _mealPosition;

        public ArenaRules()
        {
            _random = new Random();
            _mealPosition = new MealPosition();
        }

        public FieldType[][] SetBoundaries(FieldType[][] playGround)
        {
            _playGround = playGround;
            SetBoundaries();
            return _playGround;
        }

        public MealPosition SetMealOnArena(FieldType[][] playGround)
        {
            _playGround = playGround;
            RandomizeMealPosition();
            CheckIfMealPositionIsIrrelevant();
            AddMealToArena();
            return _mealPosition;
        }

        public void AddMealToArena()
        {
            _playGround[_mealPosition.HeadCoordinates.X][_mealPosition.HeadCoordinates.Y] = FieldType.SnakePart;
        }

        private void SetBoundaries()
        {
            for (int x = 0; x < _playGround.Length; x++)
            {
                for (int y = 0; y < _playGround[0].Length; y++)
                {
                    bool isBoundary = x == 0
                                      || y == 0
                                      || x == _playGround.Length - 1
                                      || y == _playGround[0].Length - 1;
                    if (isBoundary)
                    {
                        _playGround[x][y] = FieldType.Boundary;
                    }
                }
            }
        }

        private void CheckIfMealPositionIsIrrelevant()
        {
            if (_playGround[_mealPosition.HeadCoordinates.X][_mealPosition.HeadCoordinates.Y] != FieldType.Empty)
            {
                RandomizeMealPosition();
            }
        }

        private void RandomizeMealPosition()
        {
            int xPosition = _random.Next(_playGround.Length);
            int yPosition = _random.Next(_playGround[0].Length);
            _mealPosition.HeadCoordinates = new Coordinates(xPosition, yPosition);
        }
    }
}