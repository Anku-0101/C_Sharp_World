using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    // ImagePost derives from post and adds a property (ImageURL) and two constructors

    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() : base()
        { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID(); //Can seamlessly use public and protected fields of Base class
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }

    }
}
