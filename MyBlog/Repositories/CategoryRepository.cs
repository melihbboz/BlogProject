using MyBlog.Models;

namespace MyBlog.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private BlogDbContext _context;
        public CategoryRepository(BlogDbContext context)
        {
            _context = context;
        }
        public void AddCategory(BlogCategory category)
        {
            _context.Categories.Add(category);

            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (category !=  null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public IQueryable<BlogCategory> GetAll()
        {
            return _context.Categories;
        }

        public BlogCategory GetById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

            
        }

        public void UpdateCategory(BlogCategory category)
        {
            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
