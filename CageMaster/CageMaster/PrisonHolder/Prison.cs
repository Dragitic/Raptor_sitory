using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CageMaster.Animals;
using CageMaster.Containers;

namespace CageMaster.PrisonHolder
{
    class Prison
    {
        private List<IContain> containers;
        private List<Animal> _freeAnimals;

        public Prison(List<IContain> containers)
        {
            this._freeAnimals = new List<Animal>();
            this.containers = containers;
        }

        internal void Catch(Animal animal)
        {
            foreach(IContain container in containers)
            {
                if(container.ApplicableTo(animal))
                {
                    container.Catch(animal);
                    return;
                }
            }

            _freeAnimals.Add(animal);
        }

        internal List<Animal> Escaped()
        {
            return _freeAnimals;
        }

        internal List<Animal> Held()
        {
            List<Animal> heldAnimals = new List<Animal>();
            foreach (IContain container in containers)
            {
                if (container.HeldAnimal() != null)
                {
                    heldAnimals.Add(container.HeldAnimal());
                }
            }

            return heldAnimals;
        }
    }
}
