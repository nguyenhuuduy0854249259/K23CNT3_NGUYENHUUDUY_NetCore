using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhdLesson07.Models;
using System.Collections.Generic;

namespace NhdLesson07.Controllers
{
    public class NhdEmployeeController : Controller
    {
        private static List<NhdEmployee> nhdListEmployee = new List<NhdEmployee>
        {
            new NhdEmployee
                {
                    NhdId = 2310900019,
                    NhdName = "Nguyễn Hữu Duy",
                    NhdBirthDay = new DateTime(2003, 5, 10),
                    NhdEmail = "huuduy090603@gmail.com",
                    NhdPhone = "0854249259",
                    NhdSalary = 15000000,
                    NhdStatus = true
                },
                new NhdEmployee
                {
                    NhdId = 2,
                    NhdName = "Trần Thị B",
                    NhdBirthDay = new DateTime(1992, 8, 20),
                    NhdEmail = "b.tran@example.com",
                    NhdPhone = "0912345678",
                    NhdSalary = 17000000,
                    NhdStatus = true
                },
                new NhdEmployee
                {
                    NhdId = 3,
                    NhdName = "Lê Văn C",
                    NhdBirthDay = new DateTime(1985, 12, 15),
                    NhdEmail = "c.le@example.com",
                    NhdPhone = "0923456789",
                    NhdSalary = 14000000,
                    NhdStatus = false
                },
                new NhdEmployee
                {
                    NhdId = 4,
                    NhdName = "Phạm Thị D",
                    NhdBirthDay = new DateTime(1995, 3, 5),
                    NhdEmail = "d.pham@example.com",
                    NhdPhone = "0934567890",
                    NhdSalary = 16000000,
                    NhdStatus = true
                },
                new NhdEmployee
                {
                    NhdId = 5,
                    NhdName = "Hoàng Văn E",
                    NhdBirthDay = new DateTime(1988, 9, 25),
                    NhdEmail = "e.hoang@example.com",
                    NhdPhone = "0945678901",
                    NhdSalary = 15500000,
                    NhdStatus = false
                }
        };
        // GET: NhdEmployeeController
        public ActionResult NhdIndex()
        {
            return View(nhdListEmployee);
        }

        // GET: NhdEmployeeController/Details/5
        public ActionResult NhdDetails(int id)
        {
            var nhdEmployee = nhdListEmployee.FirstOrDefault(e => e.NhdId == id);
            return View(nhdEmployee);
        }

        // GET: NhdEmployeeController/NhdCreate
        public ActionResult NhdCreate()
        {
            var nhdEmployee = new NhdEmployee();
            return View();
        }

        // POST: NhdEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhdCreate(NhdEmployee nhdModel)
        {
            try
            {
                // thêm mới nhân viên vào List
                nhdModel.NhdId = nhdListEmployee.Max(x => x.NhdId) + 1;
                nhdListEmployee.Add(nhdModel);
                return RedirectToAction(nameof(NhdIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhdEmployeeController/NhdEdit/5
        public ActionResult NhdEdit(int id)
        {
            var nhdEmployee = nhdListEmployee.FirstOrDefault(e => e.NhdId==id);
            return View(nhdEmployee);
        }

        // POST: NhdEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhdEdit(int id, NhdEmployee nhdModel)
        {
            try
            {
                for (int i = 0; i < nhdListEmployee.Count(); i++)
                {
                    if (nhdListEmployee[i].NhdId == id)
                    {
                        nhdListEmployee[i] = nhdModel;
                        break;
                    }    
                }    
                return RedirectToAction(nameof(NhdIndex));
            }
            catch
            {
                return View(nhdModel);
            }
        }

        // GET: NhdEmployeeController/Delete/5
        public ActionResult NhdDelete(int id)
        {
            var nhdEmployee = nhdListEmployee.FirstOrDefault(e => e.NhdId == id);
            return View(nhdEmployee);
        }

        // POST: NhdEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhdDelete(int id, NhdEmployee nhdModel)
        {
            try
            {
                var emp = nhdListEmployee.FirstOrDefault(e => e.NhdId == id);
                if (emp != null)
                {
                    nhdListEmployee.Remove(emp);
                }
                return RedirectToAction("NhdIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
