using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_Practice_15_July
{
    
    public class CheckSize
    {
        /// <summary>
        /// This method is subscriber for the DownloadFile
        /// </summary>
        public void CheckSizeOfDownloadedFile()
        {
            Console.WriteLine("Checking Size");
        }
    }
}
