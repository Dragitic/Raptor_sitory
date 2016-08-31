using System.Collections.Generic;
using Snake2._0.Meal;

namespace Snake2._0.Snake.Behavior
{
    public interface ISnakeBehavior
    {
        SnakePosition SetSnakeStartPosition(FieldType[][] playGround);
        FieldType[][] SetPlayGroundWithSnake();
        ISnakeControl SnakeControl();
        void SnakeHitsBoundarys(FieldType[][] completePlayground, ISnakeBehavior snakeBehavior, SnakePosition snakePosition);
        void SnakeNextParts(FieldType[][] completePlayground, SnakePosition snakePosition, IMealBehavior meal);
        void SnakeAteMeal(FieldType[][] completePlayground, SnakePosition snakePosition);
    }
}