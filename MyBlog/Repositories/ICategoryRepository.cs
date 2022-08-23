using MyBlog.Models;

namespace MyBlog.Repositories
{
    public interface ICategoryRepository
    {
        BlogCategory GetById (int categoryId);
        IQueryable<BlogCategory> GetAll();

        void AddCategory(BlogCategory category);
        void UpdateCategory(BlogCategory category);
        void DeleteCategory(int categoryId);

    }
}
