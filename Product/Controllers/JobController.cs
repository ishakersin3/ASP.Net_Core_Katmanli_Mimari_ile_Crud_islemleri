using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Product_Demo.Controllers
{
    public class JobController : Controller
    {
        JobManager JobManager = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var values = JobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job j)
        {
            JobManager.InserT(j);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJob(int id)
        {
            var value = JobManager.TGetById(id);
            JobManager.DeleteT(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = JobManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job j)
        {
            JobManager.UpdateT(j);
            return RedirectToAction("Index");
        }
    }
}
