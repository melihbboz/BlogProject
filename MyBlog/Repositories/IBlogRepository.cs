using MyBlog.Models;

namespace MyBlog.Repositories
{
    public interface IBlogRepository
    {
        BlogPost GetById(int postId);
        IQueryable<BlogPost> GetAll();
        void AddBlog(BlogPost post);
        void UpdateBlog(BlogPost post);
        void DeleteBlog(int postId);

    }
}
