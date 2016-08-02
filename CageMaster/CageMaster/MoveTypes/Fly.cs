using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster.MoveTypes
{
    class Fly : IMoveType
    {
        
        public string Name()
        {
            return "Fly";
        }

        public bool IsTheSameAs(IMoveType tryToEscape)
        {
            return tryToEscape.Name() == this.Name();
        }
    }
}
