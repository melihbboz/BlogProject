using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public string PostTitle { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public string Image { get; set; }

        public DateTime Date { get; set; }

        public bool isApproved { get; set; }


        public BlogCategory Category { get; set; }


    }
}
