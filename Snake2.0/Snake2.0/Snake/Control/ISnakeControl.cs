using System;
using System.Collections;
using System.Collections.Generic;

namespace Snake2._0.Snake
{
    public interface ISnakeControl
    {
        SnakePosition MoveSnake(FieldType[][] playGround, ConsoleKey key);
        void SnakeHeadCoordinates(SnakePosition snakePosition);
        ConsoleKey SnakeControlKeys(ConsoleKeyInfo keyInfo);
    }
}