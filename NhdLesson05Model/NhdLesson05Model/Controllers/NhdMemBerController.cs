using Microsoft.AspNetCore.Mvc;
using NhdLesson05Model.Models.DataModels;

namespace NhdLesson05Model.Controllers
{
    public class NhdMemBerController : Controller
    {
        private static List<NhdMemBer> nhdListMember = new List<NhdMemBer>()
        {
            new NhdMemBer
    {
        NhdMemBerId = "2310900019",
        NhdUserName = "duy01",
        NhdPassWord = "pass01",
        NhdFullName = "Nguyễn Hữu Duy 01",
        NhdEmail = "huuduy090603@gmail.com.com"
    },
    new NhdMemBer
    {
        NhdMemBerId = "0912",
        NhdUserName = "duy02",
        NhdPassWord = "pass02",
        NhdFullName = "Nguyễn Hữu Duy 02",
        NhdEmail = "duy02@example.com"
    },
    new NhdMemBer
    {
        NhdMemBerId = "0913",
        NhdUserName = "duy03",
        NhdPassWord = "pass03",
        NhdFullName = "Nguyễn Hữu Duy 03",
        NhdEmail = "duy03@example.com"
    },
    new NhdMemBer
    {
        NhdMemBerId = "0914",
        NhdUserName = "duy04",
        NhdPassWord = "pass04",
        NhdFullName = "Nguyễn Hữu Duy 04",
        NhdEmail = "duy04@example.com"
    },
    new NhdMemBer
    {
        NhdMemBerId = "0915",
        NhdUserName = "duy05",
        NhdPassWord = "pass05",
        NhdFullName = "Nguyễn Hữu Duy 05",
        NhdEmail = "duy05@example.com"
    }
        };
        public IActionResult NhdIndex() // list member
        {
            return View(nhdListMember);
        }
    }
}
