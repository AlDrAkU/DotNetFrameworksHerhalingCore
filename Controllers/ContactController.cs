using DotNetFrameworksHerhalingCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFrameworksHerhalingCore.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactForm model)
        { 
        
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success() {
            return View();
        }
    }
}
