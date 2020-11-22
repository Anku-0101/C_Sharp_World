using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsPractice
{
    class DownloadHelper
    {
        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);
        }
    }
}
