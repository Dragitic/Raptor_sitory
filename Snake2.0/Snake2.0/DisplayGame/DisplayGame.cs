using Snake2._0.Assets;

namespace Snake2._0.DisplayGame
{
    public class DisplayGame : IDisplayArena
    {
        private string[] _arenaComplete;
        private string _arenaInProgress;
        private FieldType[][]_playGround;
        private readonly SnakeAssets _snakeAssets;
        public DisplayGame()
        {
            _snakeAssets = new SnakeAssets();
        }
        public string[] DisplayArena(FieldType[][] playGround)
        {
            _playGround = playGround;
            _arenaComplete = new string[playGround.GetLength(0)];
            GetStringRepresentationOfPlayGroundArena();

            return _arenaComplete;
        }
        private void GetStringRepresentationOfPlayGroundArena()
        {
            for (int x = 0; x < _playGround.Length; x++)
            {
                for (int y = 0; y < _playGround[0].Length; y++)
                {
                    if (_playGround[x][y] == FieldType.Empty)
                    {
                        _arenaInProgress += $"{_snakeAssets.Empty}{_snakeAssets.Empty}";
                    }
                    if (_playGround[x][y] == FieldType.Boundary)
                    {
                        _arenaInProgress += $"{_snakeAssets.Boundary}{_snakeAssets.Boundary}";
                    }
                    if (_playGround[x][y] == FieldType.SnakePart)
                    {
                        _arenaInProgress += $"{_snakeAssets.SnakeHead}{_snakeAssets.SnakeHead}";
                    }
                    if (_playGround[x][y] == FieldType.Meal)
                    {
                        _arenaInProgress += $"{_snakeAssets.Meal}{_snakeAssets.Meal}";
                    }
                }
                _arenaComplete[x] = _arenaInProgress;
                _arenaInProgress = string.Empty;
            }
        }
    }
}