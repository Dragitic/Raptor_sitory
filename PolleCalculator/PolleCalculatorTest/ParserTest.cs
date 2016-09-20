using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;
using PolleCalculator.DataSpecification.Downloader;
using PolleCalculator.DataSpecification.Parser;
using System.Collections.Generic;
using NUnit.Framework.Constraints;

namespace PolleCalculatorTest
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void ParsedFileShouldNotBeNull()
        {
            //given
            IStoreJsonFile storeJsonFile = new CandidatesAndPartyContent();
            string jsonFile = storeJsonFile.GetJsonFile();
            IJsonParser jsonParser = new CandidatesParser();

            //when
            jsonParser.ParseFile(jsonFile);

            //then
            Assert.IsNotNull(jsonParser.GetParsedObjects());
        }

        [TestCase("Władysław Łokietek")]
        [TestCase("Mieszko I")]
        [TestCase("Bolesław Chrobry")]
        [TestCase("Kazimierz Wielki")]
        [TestCase("Władysław Jagiełło")]
        public void ParsedFileShouldContainsCandidates(string expected)
        {
            //given
            IStoreJsonFile storeJsonFile = new CandidatesAndPartyContent();
            string jsonFile = storeJsonFile.GetJsonFile();
            IJsonParser jsonParser = new CandidatesParser();

            //when
            jsonParser.ParseFile(jsonFile);

            //then
            Assert.Contains(expected, jsonParser.GetParsedObjects());
        }

        [TestCase("Piastowie")]
        [TestCase("Dynastia Jagiellonów")]
        [TestCase("Elekcyjni dla Polski")]
        [TestCase("Wazowie")]
        public void ParsedFileShouldContainsParties(string expected)
        {
            //given
            IStoreJsonFile storeJsonFile = new CandidatesAndPartyContent();
            string jsonFile = storeJsonFile.GetJsonFile();
            IJsonParser jsonParser = new PartiesParser();

            //when
            jsonParser.ParseFile(jsonFile);

            //then
            Assert.Contains(expected, jsonParser.GetParsedObjects());
        }

        [Test]
        public void ParsedFileShouldContainSomeBannedVoters()
        {
            //given
            IStoreJsonFile storeJsonFile = new BannedVotersContent();
            string jsonFile = storeJsonFile.GetJsonFile();
            IJsonParser jsonParser = new BannedVotersParser();

            //when
            jsonParser.ParseFile(jsonFile);

            //then
            Assert.IsNotNull(jsonParser.GetParsedObjects());
        }
    }
}