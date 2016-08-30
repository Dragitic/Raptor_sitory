using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Snake2._0.DisplayGame;
using Snake2._0.Meal;
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
            IArenaRules arenaRules = new ArenaRules();
            IMealBehavior mealBehavior = new MealBehavior();
            IDisplayArena displayArena;
            ISnakeBehavior snakeBehavior;
            SnakePosition snakePosition;

            FieldType[][] completePlayground;

            PrimarySnakeSetUp(out displayArena, out snakePosition, out completePlayground, out snakeBehavior, arenaRules);
            snakeControl.SnakeHeadCoordinates(snakePosition);

            DisplayMovingSnake(streamOut, snakeControl, displayArena, completePlayground, snakeBehavior, snakePosition, mealBehavior);
        }
        private static void DisplayMovingSnake(StreamWriter streamOut, ISnakeControl snakeControl,
            IDisplayArena displayArena, FieldType[][] completePlayground, ISnakeBehavior snakeBehavior,
            SnakePosition snakePosition, IMealBehavior mealBehavior)
        {
            var keyInfo = Console.ReadKey(true);

            while (keyInfo.Key != ConsoleKey.Escape)
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    _keyPressed = snakeControl.SnakeControlKeys(keyInfo);
                }

                CheckIfSnakeHitBoundaries(completePlayground, snakeBehavior, snakePosition);

                _keyPressed = snakeControl.SnakeControlKeys(keyInfo);

                snakeControl.MoveSnake(completePlayground, _keyPressed);

                SetNewMealIfSnakeAteAny(completePlayground, snakeBehavior, mealBehavior);

                var display = displayArena.DisplayArena(completePlayground);

                Console.SetCursorPosition(0, 0);
                foreach (var s in display)
                {
                    streamOut.WriteLine(s);
                }
                streamOut.Flush();
                Thread.Sleep(200);
            }
        }

        private static void SetNewMealIfSnakeAteAny(FieldType[][] playGround, ISnakeBehavior snakeBehavior, IMealBehavior mealBehavior)
        {
            CheckIfSnakeAteMeal(playGround, snakeBehavior, mealBehavior);
        }

        private static void CheckIfSnakeAteMeal(FieldType[][] playGround, ISnakeBehavior snakeBehavior,
            IMealBehavior mealBehavior)
        {
            mealBehavior.SetMealOnArena(playGround);
            //snakeBehavior.SnakeNextParts(mealBehavior.MealContainer());       TODO! KONTYNUACJA
        }

        private static void CheckIfSnakeHitBoundaries(FieldType[][] completePlayground, ISnakeBehavior snakeBehavior, SnakePosition snakePosition)
        {
            if (completePlayground[snakePosition.HeadCoordinates.X + 1][snakePosition.HeadCoordinates.Y + 1] == FieldType.Boundary
                                || completePlayground[snakePosition.HeadCoordinates.X - 1][snakePosition.HeadCoordinates.Y - 1] == FieldType.Boundary)
                snakeBehavior.SnakeHitsBoundarys();
        }

        private static void PrimarySnakeSetUp(out IDisplayArena displayArena, out SnakePosition snakePosition,
            out FieldType[][] completePlayground, out ISnakeBehavior snakeBehavior, IArenaRules arenaRules)
        {
            ICreateGameArena createGameArena = new CreateGameArena();
            displayArena = new DisplayGame.DisplayGame();
            snakeBehavior = new SnakeBehavior();

            var playGround = createGameArena.PrepareArenaToPlay(30, 30);
            playGround = arenaRules.SetBoundaries(playGround);
            snakePosition = snakeBehavior.SetSnakeStartPosition(playGround);
            completePlayground = snakeBehavior.SetCompletePlayGround();
        }
    }
}
