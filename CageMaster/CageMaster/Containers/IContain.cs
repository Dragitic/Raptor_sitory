using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CageMaster.Animals;

namespace CageMaster.Containers
{
    interface IContain
    {
        bool ApplicableTo(Animal animal);

        void Catch(Animal animal);

        Animal HeldAnimal();
    }
}
