using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudioRomen
{
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }

    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate 
        // 3 - Raise the event 

        public delegate void VideoEncodedEventHandler(object souce, VideoEventArgs args);

        // In order to get rid of declaring delegate for events, .NET provides us with
        // EventHandler
        // EventHandler<TEventArgs>

        //Hence we can just remove the delegate and can write it in 2 different ways :
        // public event EventHandler VideoEncoded; //When no EventArgs is supposed to be passed
        // public event EventHandler<VideoEventArgs> VideoEncoded; 
        //See the definitions for EventHandler and EventHandler<TEventArgs> for more clarification 


        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(5000);

            OnVideoEncoded(video);
        }

        // Raising the event 
        protected virtual void OnVideoEncoded(Video video_)
        {
            if(VideoEncoded != null)
            {
                //Responsible for notifying the subscribers 
                VideoEncoded(this, new VideoEventArgs() {video = video_ });
            }
        }
    }
}
