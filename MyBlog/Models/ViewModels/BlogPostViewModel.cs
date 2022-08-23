namespace MyBlog.Models.ViewModels
{
    public class BlogPostViewModel
    {
        public int PostId { get; set; }

        public int CategoryId { get; set; }
        public string PostTitle { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public string Image { get; set; }
    }
}
