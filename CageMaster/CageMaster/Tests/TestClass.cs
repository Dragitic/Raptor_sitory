using System.Collections.Generic;
using CageMaster.Animals;
using CageMaster.Constants;
using CageMaster.PrisonHolder;
using NUnit.Framework;

namespace CageMaster.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ShouldImprisonCatAndRealiseBird()
        {
            //given
            Animal cat = new AnimalFactory().Create(StringsDontDoThisNormally.Housecat);
            Animal bird = new AnimalFactory().Create(StringsDontDoThisNormally.Bird);
            Prison prison = new PrisonFactory().Create(StringsDontDoThisNormally.CatPrison, StringsDontDoThisNormally.Small);

            //when
            prison.Catch(cat);
            prison.Catch(bird);
            List<Animal> escapees = prison.Escaped();
            List<Animal> imprisoned = prison.Held();

            //than  
            foreach (var escapee in escapees)
            {
                Assert.AreSame(escapee, bird);
            }

            foreach (var imprison in imprisoned)
            {
                Assert.AreSame(imprison, cat);
            }
        }
    }
}