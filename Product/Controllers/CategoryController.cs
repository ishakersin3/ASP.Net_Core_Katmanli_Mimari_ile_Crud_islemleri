using Microsoft.AspNetCore.Mvc;

namespace Product_Demo.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
