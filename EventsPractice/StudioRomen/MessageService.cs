using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioRomen
{
    public class MessageService
    {
        public void NotifyByMessageOnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message  " + args.video.Title);
        }
    }
}
