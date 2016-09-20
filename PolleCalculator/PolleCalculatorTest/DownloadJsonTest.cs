using System;
using System.Globalization;
using System.Net;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PolleCalculator.DataSpecification.Downloader;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PolleCalculatorTest
{
    [TestFixture]
    public class DownloadJsonTest
    {
        [TestCase("http://webtask.future-processing.com:8069/candidates")]
        [TestCase("http://webtask.future-processing.com:8069/blocked")]
        public void ShouldDownloadJsonFileFromWeb(string path)
        {
            //given
            IJsonFilesDownloader jsonFilesDownloader = new JsonFilesDownloader();
            string json;

            //when
            json = jsonFilesDownloader.DownloadJsonFile(path);

            //then
            Assert.IsNotNull(json);
        }
    }
}
