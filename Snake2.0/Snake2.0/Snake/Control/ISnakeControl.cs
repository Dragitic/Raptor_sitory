using System;
using System.Collections;
using System.Collections.Generic;

namespace Snake2._0.Snake
{
    public interface ISnakeControl
    {
        IEnumerable MoveSnake(int[][] playGround, ConsoleKey key);
        void SnakeHeadCoordinates(List<int> snakePosition);
        ConsoleKey SnakeControlKeys(ConsoleKeyInfo keyInfo);
    }
}