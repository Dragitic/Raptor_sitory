using CageMaster.Animals;
using CageMaster.Constants;
using CageMaster.PrisonHolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CageMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new AnimalFactory().Create(StringsDontDoThisNormally.Housecat);
            Animal bird = new AnimalFactory().Create(StringsDontDoThisNormally.Bird);
            Prison prison = new PrisonFactory().Create(StringsDontDoThisNormally.CatPrison, StringsDontDoThisNormally.Small);

            prison.Catch(cat);
            prison.Catch(bird);

            List<Animal> escapees = prison.Escaped();
            List<Animal> imprisoned = prison.Held();

        }

        public string Fluffy()
        {
            StringBuilder sb = new StringBuilder();
            new List<int> { 1, 2, 3, 4 }.ForEach(i => sb.Append(i));
            return sb.ToString();
        }
    }
}
