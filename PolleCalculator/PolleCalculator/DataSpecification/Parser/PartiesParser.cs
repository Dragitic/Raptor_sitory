using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PolleCalculator.DataSpecification.Parser
{
    public class PartiesParser : IJsonParser
    {
        private CandidatesObject _partyObject;
        public List<string> Party;

        public PartiesParser()
        {
            _partyObject = new CandidatesObject();
            Party = new List<string>();
        }
        public void ParseFile(string jsonFile)
        {
            _partyObject = JsonConvert.DeserializeObject<CandidatesObject>(jsonFile);
            for (int i = 0; i < _partyObject.Candidates.Candidate.Count; i++)
            {
                Party.Add(_partyObject.Candidates.Candidate.ElementAt(i).Party);
            }
        }

        public List<string> GetParsedObjects()
        {
            return Party;
        }
    }
}