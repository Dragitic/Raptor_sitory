using System;
using System.Linq;
using Snake2._0.Snake;

namespace Snake2._0.Meal
{
    public class MealBehavior : IMealBehavior
    {
        private readonly Random _random;
        private FieldType[][] _playGround;
        private MealPosition _mealPosition;
        private Meal _meal;

        public MealBehavior()
        {
            _random = new Random();
            _mealPosition = new MealPosition();
            _meal = new Meal();
        }

        public Meal MealContainer()
        {
            return _meal;
        }

        public Meal SetMealOnArena(FieldType[][] playGround)
        {
            _playGround = playGround;
            RandomizeMealPosition();
            CheckIfMealPositionIsIrrelevant();
            AddMealToArena(CheckIfOnPlaygroundIsOnlyOneMeal());

            _meal.Container.Add(_mealPosition);
            return _meal;
        }

        private int CheckIfOnPlaygroundIsOnlyOneMeal()
        {
            var mealCounter = _playGround.SelectMany(row => row).Count(type => type == FieldType.Meal);
            return mealCounter;
        }

        public void AddMealToArena(int mealConter)
        {
            if (mealConter < 1)
                _playGround[_mealPosition.HeadCoordinates.X][_mealPosition.HeadCoordinates.Y] = FieldType.Meal;
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