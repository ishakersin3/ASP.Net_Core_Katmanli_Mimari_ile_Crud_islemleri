using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Product_Demo.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        JobManager customermanager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {  
            List<SelectListItem> values = (from x in customermanager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();   
            ViewBag.v= values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer c) 
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult results = validationRules.Validate(c);
            if (results.IsValid)
            {
                customerManager.InserT(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult DeleteCustomer(Customer c)
        {
            customerManager.DeleteT(c);           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) 
        {
            List<SelectListItem> values = (from x in customermanager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = customerManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer c)
        {
            customerManager.UpdateT(c);
            return RedirectToAction("Index");
        }
    }
}
