using System;
using System.IO;
using System.Text;

namespace Snake2._0.Assets
{
    public class SnakeAssets
    {
        private StreamWriter _streamOut;
        public SnakeAssets()
        {
            _streamOut = new StreamWriter(Console.OpenStandardOutput(), Encoding.GetEncoding(437));
        }
        public char Empty { get; set; } = Encoding.GetEncoding(437).GetChars(new byte[] { 176 })[0];
        public char SnakeHead { get; set; } = Encoding.GetEncoding(437).GetChars(new byte[] { 178 })[0];
        public char SnakeBody { get; set; } = Encoding.GetEncoding(437).GetChars(new byte[] { 178 })[0];
        public char Meal { get; set; } = Encoding.GetEncoding(437).GetChars(new byte[] { 207 })[0];
        public char Boundary { get; set; } = Encoding.GetEncoding(437).GetChars(new byte[] { 177 })[0];

    }
}