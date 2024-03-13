using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View ();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strResult = "Xin chao " + ps.PersonID + "-" + ps.FullName;
            ViewBag.info = strResult;
            return View ();
        }
    }
}