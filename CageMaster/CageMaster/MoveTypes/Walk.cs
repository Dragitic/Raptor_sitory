using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster.MoveTypes
{
    class Walk : IMoveType
    {
        public bool IsTheSameAs(IMoveType tryToEscape)
        {
            return tryToEscape.Name() == this.Name();
        }

        public string Name()
        {
            return "Walk";
        }
    }
}
