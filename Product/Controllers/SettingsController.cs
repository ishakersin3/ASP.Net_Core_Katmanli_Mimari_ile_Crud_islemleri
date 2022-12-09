using Microsoft.AspNetCore.Mvc;

namespace Product_Demo.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
