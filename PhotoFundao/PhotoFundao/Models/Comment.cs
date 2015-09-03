using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoFundao.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Photo Photo { get; set; }

    }
}