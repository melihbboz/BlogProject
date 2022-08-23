using Microsoft.EntityFrameworkCore;

namespace MyBlog.Models
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {


        }


        public DbSet<BlogPost> Posts { get; set; }

        public DbSet<BlogCategory> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
