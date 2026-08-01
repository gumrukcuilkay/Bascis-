using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace Basics.Controllers
{
    //localhost/home/index
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}