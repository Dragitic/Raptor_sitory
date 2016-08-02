using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CageMaster.MoveTypes;

namespace CageMaster.Animals
{
    class Animal
    {
        private string _housecat;
        private List<IMoveType> _moves;

        public Animal(string housecat, List<IMoveType> moves)
        {
            this._housecat = housecat;
            this._moves = moves;
        }

        public bool CannotEscapeFrom(List<IMoveType> blockedMoves)
        {
            List<IMoveType> escapingMoves = new List<IMoveType>(_moves);

            foreach (IMoveType slaveryMove in blockedMoves)
            {
                foreach (IMoveType tryToEscape in _moves)
                {
                    if(slaveryMove.IsTheSameAs(tryToEscape))
                    {
                        if(escapingMoves.Contains(tryToEscape))
                        {
                            escapingMoves.Remove(tryToEscape);
                        }   
                    }
                }
            }

            if(escapingMoves.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
