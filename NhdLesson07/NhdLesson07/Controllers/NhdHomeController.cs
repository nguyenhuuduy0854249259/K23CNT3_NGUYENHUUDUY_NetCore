using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NhdLesson07.Models;

namespace NhdLesson07.Controllers
{
    public class NhdHomeController : Controller
    {
        private readonly ILogger<NhdHomeController> _logger;

        public NhdHomeController(ILogger<NhdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhdIndex()
        {
            return View();
        }

        public IActionResult NhdAbout()
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
