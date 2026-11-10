using API_template.backend;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using template.Models;

namespace template.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            new auto_createDatabase();
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult events()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult dashboard()
        {
            return View();
        }
        public IActionResult overview()
        {
            return View();
        }
        public IActionResult profile()
        {
            return View();
        }
        public IActionResult BrowseEvents()
        {
            return View();
        }
        public IActionResult MyJoinedEvents()
        {
            return View();
        }

      
        public IActionResult Categories()
        {


            return View();
        }


        public IActionResult CreateEvent()
        {


            return View();
        }
        public IActionResult MyEvents()
        {


            return View();
        }
        public IActionResult Participants()
        {


            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
