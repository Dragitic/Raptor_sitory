using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class DoIt
    {
        public delegate void OddDelegate(float Value);
        public event OddDelegate Odd;

        public float Div(float X, float Y)
        {
            float Z = X / Y;

            if (Z % 2 == 0)
            {
                Odd(Z);
            }
            return Z;
        }
    }
}
