using Snake2._0.Assets;

namespace Snake2._0.DisplayGame
{
    public class DisplayGame : IDisplayArena
    {
        private string[] _arenaComplete;
        private string _arenaInProgress;
        private int[][] _playGround;
        private readonly SnakeAssets _snakeAssets;
        public DisplayGame()
        {
            _snakeAssets = new SnakeAssets();
        }
        public string[] DisplayArena(int[][] playGround)
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
                    if (_playGround[x][y] == 1)
                    {
                        _arenaInProgress += $"{_snakeAssets.RegularField}{_snakeAssets.RegularField}";
                    }
                    if (_playGround[x][y] == 0)
                    {
                        _arenaInProgress += $"{_snakeAssets.Boundarys}{_snakeAssets.Boundarys}";
                    }
                    if (_playGround[x][y] == 2)
                    {
                        _arenaInProgress += $"{_snakeAssets.SnakeHead}{_snakeAssets.SnakeHead}";
                    }
                }
                _arenaComplete[x] = _arenaInProgress;
                _arenaInProgress = string.Empty;
            }
        }
    }
}