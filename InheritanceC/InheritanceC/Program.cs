using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

        }

        public void ExecutorForPostInheritance()
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Kumar Raju");
            Console.WriteLine(post1.ToString());

            //B b = new B();
            //Console.ReadKey();

            VideoPost videoPost = new VideoPost("Intro video", "https:/video1.mkv",
                10, "User5", true);
            videoPost.Play();
            Console.WriteLine("Press any key to stop playing");
            Console.ReadKey();
            videoPost.Stop();
            Console.ReadKey();
        }
    }
}
