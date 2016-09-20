using System.Collections.Generic;
using Newtonsoft.Json;

namespace PolleCalculator.DataSpecification.Parser
{
    public class CandidatesObject
    {
        [JsonProperty("candidates")]
        public Candidates Candidates;
    }
    public class Candidate
    {
        public string Name;
        public string Party;
    }
    public class Candidates
    {
        [JsonProperty("publicationDate")]
        public string PublicationDate;

        [JsonProperty("candidate")]
        public IList<Candidate> Candidate;
    }
}