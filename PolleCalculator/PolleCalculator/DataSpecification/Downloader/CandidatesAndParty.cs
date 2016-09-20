using System.Net;
using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public class CandidatesAndParty : IStoreJsonFile
    {
        IJsonFilesDownloader _jsonFilesDownloader;
        private string _json;
        public CandidatesAndParty()
        {
            _jsonFilesDownloader = new JsonFilesDownloader();
        }
        public void GetFile()
        {
            _json = _jsonFilesDownloader.DownloadJsonFile("http://webtask.future-processing.com:8069/candidates");
        }

        public void SaveFile()
        {
            throw new System.NotImplementedException();
        }
    }
}