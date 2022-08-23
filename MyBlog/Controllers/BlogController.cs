using Microsoft.AspNetCore.Mvc;
using MyBlog.Repositories;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _repository;

        public BlogController(IBlogRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
