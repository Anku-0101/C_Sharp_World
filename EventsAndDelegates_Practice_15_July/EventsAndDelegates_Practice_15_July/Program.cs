using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_Practice_15_July
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDownloader fileDownloader = new FileDownloader();
            CheckSize checkSize = new CheckSize();
            CreateInstaller createInstaller = new CreateInstaller();

            fileDownloader.FileDownloaded += checkSize.CheckSizeOfDownloadedFile;
            fileDownloader.FileDownloaded += createInstaller.CreateInstallerForDownloadedFile;

            fileDownloader.DownloadFile();

            Console.ReadKey();
        }
    }
}
