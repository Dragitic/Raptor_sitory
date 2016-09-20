using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using PolleCalculator.DataSpecification.Downloader;

namespace PolleCalculator.DataSpecification.Parser
{
    public class BannedVotersParser : IJsonParser
    {
        private BannedVotersObject _bannedVotersObject;
        public List<string> Pesel;
        public BannedVotersParser()
        {
            _bannedVotersObject = new BannedVotersObject();
            Pesel = new List<string>();
        }
        public void ParseFile(string jsonFile)
        {
            _bannedVotersObject = JsonConvert.DeserializeObject<BannedVotersObject>(jsonFile);
            for (int i = 0; i < _bannedVotersObject.Candidates.Candidate.Count; i++)
            {
                Pesel.Add(_bannedVotersObject.Candidates.Candidate.ElementAt(i).Pesel);
            }
        }

        public List<string> GetParsedObjects()
        {
            return Pesel;
        }
    }
}