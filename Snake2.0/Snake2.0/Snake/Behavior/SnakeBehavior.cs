using System;
using System.Collections.Generic;
using Snake2._0.Meal;
using Snake2._0.Snake.Behavior;

namespace Snake2._0.Snake
{
    public class SnakeBehavior : ISnakeBehavior
    {
        private FieldType[][] _playGround;
        private SnakePositionDispatcher _positionDispatcher;
        private static int _ateMeals = 0;

        public SnakePosition SetSnakeStartPosition(FieldType[][] playGround)
        {
            _playGround = playGround;

            _positionDispatcher = new SnakePositionDispatcher(_playGround);
            var startPosition = _positionDispatcher.SetPosition();

            return startPosition;
        }
        public FieldType[][] SetPlayGroundWithSnake()
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

        public void SnakeHitsBoundarys(FieldType[][] completePlayground, ISnakeBehavior snakeBehavior, SnakePosition snakePosition)
        {
            if (completePlayground[snakePosition.HeadCoordinates.X + 1][snakePosition.HeadCoordinates.Y + 1] ==
                FieldType.Boundary
                ||
                completePlayground[snakePosition.HeadCoordinates.X - 1][snakePosition.HeadCoordinates.Y - 1] ==
                FieldType.Boundary)
            {
                Console.Clear();
                Console.WriteLine("Game Over!!");
                Console.ReadKey();
                var exit = Environment.ExitCode;
                Environment.Exit(exit);
            }
        }

        public void SnakeNextParts(FieldType[][] completePlayground, SnakePosition snakePosition, IMealBehavior meal)
        {
            var foo = meal.MealContainer();
        }

        public void SnakeAteMeal(FieldType[][] completePlayground, SnakePosition snakePosition)
        {
            if (completePlayground[snakePosition.HeadCoordinates.X + 1][snakePosition.HeadCoordinates.Y + 1] == FieldType.Meal)
                _ateMeals++;
        }
    }
}