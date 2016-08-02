using CageMaster.Constants;
using CageMaster.MoveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster.Animals
{
    class AnimalFactory
    {
        public Animal Create(string animalIdentifier)
        {
            Animal animal = null;

            if (animalIdentifier == StringsDontDoThisNormally.Housecat)
            {
                List<IMoveType> moves = new List<IMoveType>();
                moves.Add(new Walk());
                moves.Add(new Run());
                animal = new Animal(StringsDontDoThisNormally.Housecat, moves);
            }
            else if (animalIdentifier == StringsDontDoThisNormally.Bird)
            {
                List<IMoveType> moves = new List<IMoveType>();
                moves.Add(new Walk());
                moves.Add(new Fly());
                animal = new Animal(StringsDontDoThisNormally.Bird, moves);
            }
            else
            {
                throw new NotImplementedException("More animals needed");
            }

            return animal;
        }
    }
}
