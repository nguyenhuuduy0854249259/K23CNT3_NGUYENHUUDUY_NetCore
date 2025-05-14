using Microsoft.AspNetCore.Mvc;
using NhdLesson01Mvc.Models;
using System.Diagnostics;

namespace NhdLesson01Mvc.Controllers
{
    public class NhdHomeController : Controller
    {
        private readonly ILogger<NhdHomeController> _logger;

        public NhdHomeController(ILogger<NhdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
