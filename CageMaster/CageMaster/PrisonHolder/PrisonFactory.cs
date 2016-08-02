using CageMaster.Constants;
using CageMaster.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster.PrisonHolder
{
    class PrisonFactory
    {
        public Prison Create(string prisonIdentifier, string size)
        {
            if (prisonIdentifier == StringsDontDoThisNormally.CatPrison)
            {
                if (size == StringsDontDoThisNormally.Small)
                {
                    List<IContain> containers = new List<IContain>();
                    containers.Add(new Moat());
                    containers.Add(new Moat());
                    containers.Add(new Moat());

                    return new Prison(containers);
                }
            }

            throw new NotImplementedException("Oopsie");
        }
    }
}
