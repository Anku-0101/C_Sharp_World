using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_Practice_15_July
{
    public class CreateInstaller
    {
        /// <summary>
        /// This method is also a subscriber to FileDownloaded
        /// </summary>
        public void CreateInstallerForDownloadedFile()
        {
            Console.WriteLine("creating Installer for downloaded file");
        }
    }
}
