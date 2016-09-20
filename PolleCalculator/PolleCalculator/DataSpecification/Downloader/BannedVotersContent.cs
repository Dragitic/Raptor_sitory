using System.Net;
using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public class BannedVotersContent : IStoreJsonFile
    {
        readonly IJsonFilesDownloader _jsonFilesDownloader;
        private string _json;
        public BannedVotersContent()
        {
            _jsonFilesDownloader = new JsonFilesDownloader();
        }
        public string GetJsonFile()
        {
            return _json = _jsonFilesDownloader.DownloadJsonFile("http://webtask.future-processing.com:8069/blocked");
        }
    }
}