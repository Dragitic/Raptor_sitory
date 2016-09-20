using System.Net;
using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public class CandidatesAndPartyContent : IStoreJsonFile
    {
        readonly IJsonFilesDownloader _jsonFilesDownloader;
        private string _json;
        public CandidatesAndPartyContent()
        {
            _jsonFilesDownloader = new JsonFilesDownloader();
        }
        public string GetJsonFile()
        {
            return _json = _jsonFilesDownloader.DownloadJsonFile("http://webtask.future-processing.com:8069/candidates");
        }
    }
}   