using System.Collections.Generic;

namespace Snake2._0.Snake.Behavior
{
    public interface ISnakeBehavior
    {
        List<int>Set_X_YStartPosition(int[][] playGround);
        int[][] SetCompletePlayGround();
        ISnakeControl SnakeControl();
        void SnakeNextParts();
        void SnakeHitsBoundarys(int[][] completePlayground, List<int> currentSnakePosition);
    }
}