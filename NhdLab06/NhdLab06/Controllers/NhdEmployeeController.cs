using Microsoft.AspNetCore.Mvc;
using NhdLab06.Models;


namespace NhdLab06.Controllers
{
    public class NhdEmployeeController : Controller
    {
        private static List<NhdEmployee> nhdListEmployee = new List<NhdEmployee>
    {
        new NhdEmployee{ NhdId = 1, NhdName = "Nguyễn Hữu Duy", NhdBirthDay = new DateTime(2003,1,1), NhdEmail="huuduy090603@gmail.com", NhdPhone="0123456789", NhdSalary=1000, NhdStatus=true },
        new NhdEmployee{ NhdId = 2, NhdName = "Trần Văn B", NhdBirthDay = new DateTime(1990,5,10), NhdEmail="b@gmail.com", NhdPhone="0987654321", NhdSalary=2000, NhdStatus=false },
        new NhdEmployee{ NhdId = 3, NhdName = "Lê Thị C", NhdBirthDay = new DateTime(1988,3,20), NhdEmail="c@gmail.com", NhdPhone="0911223344", NhdSalary=1500, NhdStatus=true },
        new NhdEmployee{ NhdId = 4, NhdName = "Phạm Văn D", NhdBirthDay = new DateTime(1985,7,15), NhdEmail="d@gmail.com", NhdPhone="0909090909", NhdSalary=1700, NhdStatus=false },
        new NhdEmployee{ NhdId = 5, NhdName = "Sinh Viên - Nguyễn Văn A", NhdBirthDay = new DateTime(2003,10,10), NhdEmail="student@gmail.com", NhdPhone="0123001122", NhdSalary=500, NhdStatus=true }
    };
        public IActionResult NhdIndex()
        {
            return View(nhdListEmployee);
        }
        public IActionResult NhdCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NhdCreateSubmit(NhdEmployee emp)
        {
            emp.NhdId = nhdListEmployee.Max(e => e.NhdId) + 1;
            nhdListEmployee.Add(emp);
            return RedirectToAction("NhdIndex");
        }

        public IActionResult NhdEdit(int id)
        {
            var emp = nhdListEmployee.FirstOrDefault(e => e.NhdId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult NhdEditPUT(NhdEmployee updatedEmp)
        {
            var emp = nhdListEmployee.FirstOrDefault(e => e.NhdId == updatedEmp.NhdId);
            if (emp != null)
            {
                emp.NhdName = updatedEmp.NhdName;
                emp.NhdBirthDay = updatedEmp.NhdBirthDay;
                emp.NhdEmail = updatedEmp.NhdEmail;
                emp.NhdPhone = updatedEmp.NhdPhone;
                emp.NhdSalary = updatedEmp.NhdSalary;
                emp.NhdStatus = updatedEmp.NhdStatus;
            }
            return RedirectToAction("NhdIndex");
        }

        public IActionResult NhdDelete(int id)
        {
            var emp = nhdListEmployee.FirstOrDefault(e => e.NhdId == id);
            if (emp != null)
            {
                nhdListEmployee.Remove(emp);
            }
            return RedirectToAction("NhdIndex");
        }
    }
}
