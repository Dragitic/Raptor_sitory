using System.Collections.Generic;
using Newtonsoft.Json;

namespace PolleCalculator.DataSpecification
{
    public class BannedVotersObject
    {
        [JsonProperty("disallowed")]
        public BannedVoters Candidates;
    }
    public class BannedVoter
    {
        public string Pesel;
    }
    public class BannedVoters
    {
        [JsonProperty("publicationDate")]
        public string PublicationDate;

        [JsonProperty("person")]
        public IList<BannedVoter> Candidate;
    }
}