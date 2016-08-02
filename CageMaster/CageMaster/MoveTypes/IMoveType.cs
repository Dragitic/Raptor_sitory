using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster.MoveTypes
{
    interface IMoveType
    {
        string Name();
        bool IsTheSameAs(IMoveType tryToEscape);
    }
}
