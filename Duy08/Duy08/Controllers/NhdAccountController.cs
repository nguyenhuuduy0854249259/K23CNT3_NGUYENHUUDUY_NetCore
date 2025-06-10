using Duy08.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Duy08.Controllers
{
    public class NhdAccountController : Controller
    {
        private static List<Account> accounts = new List<Account>
        {
            new Account
                {
                    NhdMaSinhVien = "NHD001",
                    NhdHoVaTen = "Nguyễn Hữu Duy",
                    NhdEmail = "duy.nhd@example.com",
                    NhdDienThoai = "0912345678",
                    NhdDiaChi = "Hà Nội",
                    NhdAnhDaiDien = "/images/nhd001.jpg",
                    NhdNgaySinh = new DateTime(2003, 6, 9),
                    NhdGioiTinh = "Nam",
                    NhdMatKhau = "123456",
                    NhdFacebook = "https://facebook.com/duynhd"
                },
                new Account
                {
                    NhdMaSinhVien = "NHD002",
                    NhdHoVaTen = "Trần Thị Mai",
                    NhdEmail = "mai.tran@example.com",
                    NhdDienThoai = "0934567890",
                    NhdDiaChi = "TP.HCM",
                    NhdAnhDaiDien = "/images/nhd002.jpg",
                    NhdNgaySinh = new DateTime(2002, 11, 21),
                    NhdGioiTinh = "Nữ",
                    NhdMatKhau = "abc123",
                    NhdFacebook = "https://facebook.com/maitran"
                },
                new Account
                {
                    NhdMaSinhVien = "NHD003",
                    NhdHoVaTen = "Lê Văn An",
                    NhdEmail = "an.le@example.com",
                    NhdDienThoai = "0923456789",
                    NhdDiaChi = "Đà Nẵng",
                    NhdAnhDaiDien = "/images/nhd003.jpg",
                    NhdNgaySinh = new DateTime(2001, 3, 15),
                    NhdGioiTinh = "Nam",
                    NhdMatKhau = "pass123",
                    NhdFacebook = "https://facebook.com/lean"
                },
                new Account
                {
                    NhdMaSinhVien = "NHD003",
                    NhdHoVaTen = "Lê Văn An",
                    NhdEmail = "an.le@example.com",
                    NhdDienThoai = "0923456789",
                    NhdDiaChi = "Đà Nẵng",
                    NhdAnhDaiDien = "/images/nhd003.jpg",
                    NhdNgaySinh = new DateTime(2001, 3, 15),
                    NhdGioiTinh = "Nam",
                    NhdMatKhau = "pass123",
                    NhdFacebook = "https://facebook.com/lean"
                },
                new Account
                {
                    NhdMaSinhVien = "NHD005",
                    NhdHoVaTen = "Đỗ Minh Quân",
                    NhdEmail = "quan.do@example.com",
                    NhdDienThoai = "0956789012",
                    NhdDiaChi = "Huế",
                    NhdAnhDaiDien = "/images/nhd005.jpg",
                    NhdNgaySinh = new DateTime(2004, 9, 12),
                    NhdGioiTinh = "Nam",
                    NhdMatKhau = "quan789",
                    NhdFacebook = "https://facebook.com/minhquan"
                }
        };

        // GET: Account
        public ActionResult NhdIndex()
        {
            return View(accounts);
        }

        // GET: Account/Details/5
        public ActionResult NhdDetails(int id)
        {
            var acc = accounts.FirstOrDefault(a => a.NhdId == id);
            return View(acc);
        }

        // GET: Account/Create
        public ActionResult NhdCreate()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhdCreate(Account model)
        {
            if (ModelState.IsValid)
            {
                model.NhdId = accounts.Any() ? accounts.Max(a => a.NhdId) + 1 : 1;
                accounts.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Account/Edit/5
        public ActionResult NhdEdit(int id)
        {
            var acc = accounts.FirstOrDefault(a => a.NhdId == id);
            return View(acc);
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhdEdit(int id, Account model)
        {
            if (ModelState.IsValid)
            {
                var acc = accounts.FirstOrDefault(a => a.NhdId == id);
                if (acc != null)
                {
                    acc.NhdHoVaTen = model.NhdHoVaTen;
                    acc.NhdEmail = model.NhdEmail;
                    acc.NhdDienThoai = model.NhdDienThoai;
                    acc.NhdDiaChi = model.NhdDiaChi;
                    acc.NhdAnhDaiDien = model.NhdAnhDaiDien;
                    acc.NhdNgaySinh = model.NhdNgaySinh;
                    acc.NhdGioiTinh = model.NhdGioiTinh;
                    acc.NhdMatKhau = model.NhdMatKhau;
                    acc.NhdFacebook = model.NhdFacebook;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Account/Delete/5
        public ActionResult NhdDelete(int id)
        {
            var acc = accounts.FirstOrDefault(a => a.NhdId == id);
            return View(acc);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var acc = accounts.FirstOrDefault(a => a.NhdId == id);
            if (acc != null)
            {
                accounts.Remove(acc);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
