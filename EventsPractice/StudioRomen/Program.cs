using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioRomen
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };

            var videoEncoder = new VideoEncoder(); //Publisher

            var mailService = new MailService();        //Subscriber
            var messageService = new MessageService();  //Subscriber

            videoEncoder.VideoEncoded += mailService.NotifyByMailOnVideoEncoded;        //Subscribing to the event
            videoEncoder.VideoEncoded += messageService.NotifyByMessageOnVideoEncoded;  //Subscribing to the event
            videoEncoder.Encode(video);
            
            Console.ReadKey();
        }
    }
}
