using System;

namespace Snake2._0
{
    public class CreateGameArena : ICreateGameArena
    {
        private int[][] _gameBoardArea;
        private int _xAxis;
        private int _yAxis;
        public int[][] PrepareArenaToPlay(int xAxis, int yAxis)
        {
            _xAxis = xAxis;
            _yAxis = yAxis;
            _gameBoardArea = new int[xAxis][];

            CreateArena();
            PopulateArena();

            return _gameBoardArea;
        }
        private void CreateArena()
        {
            for (int i = 0; i < _gameBoardArea.Length; i++)
            {
                _gameBoardArea[i] = new int[_yAxis];
            }
        }
        private void PopulateArena()
        {
            for (int x = 0; x < _xAxis; x++)
            {
                for (int y = 0; y < _yAxis; y++)
                {
                    _gameBoardArea[x][y] = 1;
                }
            }
        }
    }
}