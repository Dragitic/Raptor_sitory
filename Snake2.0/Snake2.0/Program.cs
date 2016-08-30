using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Snake2._0.DisplayGame;
using Snake2._0.Snake;
using Snake2._0.Snake.Behavior;

namespace Snake2._0
{
    class Program
    {
        private static ConsoleKey _keyPressed;
        static void Main(string[] args)
        {
            Console.Title = "*** Crashed! *** Length: " + "     Hit 'q' to quit, or 'r' to retry!";
            StreamWriter streamOut = new StreamWriter(Console.OpenStandardOutput(),
                Encoding.GetEncoding(437));

            ISnakeControl snakeControl = new SnakeControl();
            IDisplayArena displayArena;
            ISnakeBehavior snakeBehavior;
            List<int> snakePosition;
            int[][] completePlayground;

            PrimarySnakeSetUp(out displayArena, out snakePosition, out completePlayground, out snakeBehavior);
            snakeControl.SnakeHeadCoordinates(snakePosition);

            completePlayground = DisplayMovingSnake(streamOut, snakeControl, displayArena, completePlayground, snakeBehavior);
        }
        private static int[][] DisplayMovingSnake(StreamWriter streamOut, ISnakeControl snakeControl,
            IDisplayArena displayArena, int[][] completePlayground, ISnakeBehavior snakeBehavior)
        {
            var keyInfo = Console.ReadKey(true);

            while (keyInfo.Key != ConsoleKey.Escape)
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    _keyPressed = snakeControl.SnakeControlKeys(keyInfo);
                }

                _keyPressed = snakeControl.SnakeControlKeys(keyInfo);

                //var moveSnake = snakeControl.MoveSnake(completePlayground, _keyPressed);
                //completePlayground = moveSnake.OfType<int[][]>().ElementAt(0);

                //var currentSnakePosition = moveSnake.OfType<List<int>>().ElementAt(0);
                //snakeBehavior.SnakeHitsBoundarys(completePlayground, currentSnakePosition);

                var moveSnake = snakeControl.MoveSnake(completePlayground, _keyPressed).AsParallel();
                //completePlayground = moveSnake.OfType<int[][]>();

                var display = displayArena.DisplayArena(completePlayground);

                Console.SetCursorPosition(0, 0);
                foreach (var s in display)
                {
                    streamOut.WriteLine(s);
                }
                streamOut.Flush();
                Thread.Sleep(200);
            }
            return completePlayground;
        }

        private static void PrimarySnakeSetUp(out IDisplayArena displayArena, out List<int> snakePosition,
            out int[][] completePlayground, out ISnakeBehavior snakeBehavior)
        {
            ICreateGameArena createGameArena = new CreateGameArena();
            IArenaRules arenaRules = new ArenaRules();
            displayArena = new DisplayGame.DisplayGame();
            snakeBehavior = new SnakeBehavior();

            var playGround = createGameArena.PrepareArenaToPlay(30, 30);
            playGround = arenaRules.GetBoundaries(playGround);
            snakePosition = snakeBehavior.Set_X_YStartPosition(playGround);
            completePlayground = snakeBehavior.SetCompletePlayGround();
        }
    }
}
