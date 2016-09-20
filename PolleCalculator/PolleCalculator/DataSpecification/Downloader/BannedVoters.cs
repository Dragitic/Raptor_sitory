using System.Net;
using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public class BannedVoters :IStoreJsonFile
    {
        IJsonFilesDownloader _jsonFilesDownloader;
        private string _json;
        public BannedVoters()
        {
            _jsonFilesDownloader = new JsonFilesDownloader();
        }
        public void GetFile()
        {
            _json = _jsonFilesDownloader.DownloadJsonFile("http://webtask.future-processing.com:8069/blocked");
        }

        public void SaveFile()
        {
            throw new System.NotImplementedException();
        }
    }
}