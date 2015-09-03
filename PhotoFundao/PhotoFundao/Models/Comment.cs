using System.ComponentModel.DataAnnotations;

namespace PhotoFundao.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Photo Photo { get; set; }
    }
}