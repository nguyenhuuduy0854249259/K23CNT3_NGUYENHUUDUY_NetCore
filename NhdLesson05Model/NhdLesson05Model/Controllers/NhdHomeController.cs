using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NhdLesson05Model.Models;
using NhdLesson05Model.Models.DataModels;

namespace NhdLesson05Model.Controllers
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
            NhdMemBer nhdMemBer = new NhdMemBer
            {
                NhdMemBerId = Guid.NewGuid().ToString(),
                NhdUserName = "Nguyễn hữu Duy",
                NhdPassWord = "123456789",
                NhdFullName = "Nguyễn Hữu Duy",
                NhdEmail = "huuduy090603@gmail.com"
            };

            ViewData["Title"] = "Thông tin sinh viên"; // Cũng thêm dòng này nếu bạn muốn sử dụng ViewData
            return View(nhdMemBer); // ✅ Truyền model vào view
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
