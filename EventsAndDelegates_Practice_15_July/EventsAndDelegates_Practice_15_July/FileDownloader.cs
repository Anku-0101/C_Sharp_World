using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegates_Practice_15_July
{
    /// <summary>
    /// Publisher class, it publishes an event i.e when file is downloaded
    /// </summary>
    public class FileDownloader
    {
        public delegate void DownloadFileEventHandler();

        public event DownloadFileEventHandler FileDownloaded;
      

        public void DownloadFile()
        {
            Console.WriteLine("Downloading File");
            Thread.Sleep(3000);
            Console.WriteLine("File Downloaded");
            OnFileDownlaoded();
        }

        private void OnFileDownlaoded()
        {
            if (FileDownloaded != null)
                FileDownloaded.Invoke();
        }
    }
}
