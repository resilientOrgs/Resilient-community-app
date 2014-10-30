using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResilientOrg.Models
{
    class Post
    {
        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int UserId { get; set; }
            public virtual User User { get; set; }
        }
    }
}
