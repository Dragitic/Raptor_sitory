using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PolleCalculator.DataSpecification.Downloader;

namespace PolleCalculator.DataSpecification.Parser
{
    public class CandidatesParser : IJsonParser
    {
        private CandidatesObject _candidatesObject;
        public List<string> Name;

        public CandidatesParser()
        {
            _candidatesObject = new CandidatesObject();
            Name = new List<string>();
        }
        public void ParseFile(string jsonFile)
        {
            _candidatesObject = JsonConvert.DeserializeObject<CandidatesObject>(jsonFile);
            for (int i = 0; i < _candidatesObject.Candidates.Candidate.Count; i++)
            {
                Name.Add(_candidatesObject.Candidates.Candidate.ElementAt(i).Name);
            }
        }

        public List<string> GetParsedObjects()
        {
            return Name;
        }
    }
}