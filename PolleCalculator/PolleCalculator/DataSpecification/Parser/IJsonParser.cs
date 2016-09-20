using System.Collections;
using System.Collections.Generic;

namespace PolleCalculator.DataSpecification.Parser
{
    public interface IJsonParser
    {
        void ParseFile(string jsonFile);
        List<string> GetParsedObjects();
    }
}