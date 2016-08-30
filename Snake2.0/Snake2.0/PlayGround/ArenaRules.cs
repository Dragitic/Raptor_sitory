using System;
using System.Linq;

namespace Snake2._0
{
    public class ArenaRules : IArenaRules
    {
        private int[][] _playGround;
        public int[][] GetBoundaries(int[][] playGround)
        {
            _playGround = playGround;
            SetBoundaries();
            return _playGround;
        }
        private void SetBoundaries()
        {
            for (int x = 0; x < _playGround.Length; x++)
            {
                for (int y = 0; y < _playGround[0].Length; y++)
                {
                    if (x == 0)
                    {
                        _playGround[x][y] = 0;
                    }
                    if (x == _playGround.Length - 1)
                    {
                        _playGround[x][y] = 0;
                    }
                    if (y == 0)
                    {
                        _playGround[x][y] = 0;
                    }
                    if (y == _playGround[0].Length - 1)
                    {
                        _playGround[x][y] = 0;
                    }
                }
            }
        }
    }
}