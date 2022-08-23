using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class BlogCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<BlogPost> Posts { get; set; }

    }
}
