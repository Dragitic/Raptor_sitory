using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void AnimalsEventHandler();

    public delegate void DownloadStatusEventHander();
        class Program
    {
        public static event AnimalsEventHandler _show;

        FileDownloader fileDownloader = new FileDownloader();
        static void Main(string[] args)
        {
            _show += new AnimalsEventHandler(Cat);
            _show += new AnimalsEventHandler(Dog);
            _show += new AnimalsEventHandler(Mouse);
            _show += new AnimalsEventHandler(Mouse);

            _show?.Invoke();
            FileDownloader.Download(false);
            FileDownloader.Result();

            FileDownloader.Download(true);
            FileDownloader.Result();

            Console.ReadKey();
        }

        private static void Cat() => Console.WriteLine("Cat");
        private static void Dog() => Console.WriteLine("Dog");
        private static void Mouse() => Console.WriteLine("Mouse");
    }

    class FileDownloader
    {
        private static event DownloadStatusEventHander _status;
        public static void Download(bool isSucceed)
        {
            if (isSucceed)
                _status += Fail;
            else
                _status += Succees;
        }

        public static void Result()
        {
            _status.Invoke();
        }

        private static void Succees() => Console.WriteLine("Udało się pobrać.");

        public static void Fail() => Console.WriteLine("Nie udało się pobrać.");
    }
}
