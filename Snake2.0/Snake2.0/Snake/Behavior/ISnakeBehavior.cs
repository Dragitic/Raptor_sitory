using System.Collections.Generic;

namespace Snake2._0.Snake.Behavior
{
    public interface ISnakeBehavior
    {
        SnakePosition SetSnakeStartPosition(FieldType[][] playGround);
        FieldType[][] SetCompletePlayGround();
        ISnakeControl SnakeControl();
        void SnakeNextParts();
        void SnakeHitsBoundarys();
    }
}