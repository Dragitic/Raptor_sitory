using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CageMaster.Animals;
using CageMaster.MoveTypes;

namespace CageMaster.Containers
{
    class Moat : IContain
    {
        Animal _heldAnimal;
        List<IMoveType> _blocksMoveTypes;

        public Moat()
        {
            _heldAnimal = null;
            _blocksMoveTypes = new List<IMoveType>();

            _blocksMoveTypes.Add(new Run());
            _blocksMoveTypes.Add(new Walk());
        }

        public bool ApplicableTo(Animal animal)
        {
            return animal.CannotEscapeFrom(_blocksMoveTypes);
        }

        public void Catch(Animal animal)
        {
            _heldAnimal = animal;
        }

        public Animal HeldAnimal()
        {
            return _heldAnimal;
        }
    }
}
