using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default Constructor. If a derived class does not invoke a base class
        // constructor explicitly, then default constructor is called 
        // implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First post";
            IsPublic = true;
            SendByUsername = "Aman Verma";
        }

        //Instance constructor that has three parameters 
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool ispublic)
        {
            this.Title = title;
            this.IsPublic = ispublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}
