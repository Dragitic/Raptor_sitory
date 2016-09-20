using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public interface IJsonFilesDownloader
    {
        string DownloadJsonFile(string path);
    }
}