using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InheritanceC
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDurartion = 0;
        Timer timer;

        //Properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost()
        {

        }
        public VideoPost(string title, string url, int length, string SenderUser, bool isPublic)
        {
            this.VideoURL = url;
            this.Length = length;
            this.SendByUsername = SenderUser;

            this.ID = GetNextID();
            this.Title = title;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} of length {3} by {4}", ID, Title,
                VideoURL, Length, SendByUsername);
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if(currDurartion < Length)
            {
                currDurartion++;
                Console.WriteLine("Video at {0}s", currDurartion);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDurartion);
                currDurartion = 0;
                timer.Dispose();
            }
            
        }
    }
}
