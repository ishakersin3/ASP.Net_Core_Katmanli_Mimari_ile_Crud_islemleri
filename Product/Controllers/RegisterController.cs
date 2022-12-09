using Microsoft.AspNetCore.Mvc;

namespace Product_Demo.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
