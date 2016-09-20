using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Xml.Linq;

namespace PolleCalculator.DataSpecification.Downloader
{
    public class JsonFilesDownloader : IJsonFilesDownloader
    {
        private string _json;

        public string DownloadJsonFile(string path)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    webClient.Headers.Add("Accept", "application/json");
                    webClient.Encoding = Encoding.UTF8;
                    _json = webClient.DownloadString(path);
                }
            }
            catch (Exception)
            {
                MessageBoxResult result = MessageBox.Show("Server Error, please try later.");
            }
            return _json;
        }
    }
}