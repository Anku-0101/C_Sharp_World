using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioRomen
{
    public class MailService
    {
        public void NotifyByMailOnVideoEncoded(object souce, VideoEventArgs args)
        {
            Console.WriteLine("Sending an email... <Video Encoded>  " + args.video.Title);
        }
    }
}
