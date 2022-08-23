using MyBlog.Models;

namespace MyBlog.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private BlogDbContext _context;
        public BlogRepository(BlogDbContext context)
        {
            _context = context;
        }
        public void AddBlog(BlogPost post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void DeleteBlog(int postId)
        {
            var blog = _context.Posts.FirstOrDefault(c => c.PostId == postId);
            if (blog!= null)
            {
                _context.Posts.Remove(blog);
                _context.SaveChanges();
            }
        }

        public IQueryable<BlogPost> GetAll()
        {
            return _context.Posts;
        }

        public BlogPost GetById(int postId)
        {
            return _context.Posts.FirstOrDefault(c => c.PostId == postId);
        }

        public void UpdateBlog(BlogPost post)
        {
            _context.Entry(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
