using Microsoft.AspNetCore.Mvc;
using NhdLesson04.Models;
using System.Collections.Generic;
using System.Linq;

namespace NhdLesson04.Controllers
{
    public class NhdBookController : Controller
    {
        private List<NhdBook> nhdbooks = new List<NhdBook>
        {
            new NhdBook
            {
                NhdId = "1",
                NhdTitle = "Qua vùng nổi bão",
                NhdDescription = "...",
                NhdImage = "/images/Book-1.jpg",
                NhdPrice = "85.000",
                NhdPage = "220"
            },
            new NhdBook
            {
                NhdId = "2",
                NhdTitle = "Mùa Thu Ở Paris",
                NhdDescription = "Những ghi chép nhẹ nhàng và lãng mạn của một người Việt sống ở Paris mùa lá rụng.",
                NhdImage = "/images/Book-2.jpg",
                NhdPrice = "95.000",
                NhdPage = "198"
            },
            new NhdBook
            {
                NhdId = "3",
                NhdTitle = "Chạm nẻo người dưng",
                NhdDescription = "...",
                NhdImage = "/images/Book-3.jpg",
                NhdPrice = "75.000",
                NhdPage = "210"
            },
            new NhdBook
            {
                NhdId = "4",
                NhdTitle = "Dặm nẻo đường thơ",
                NhdDescription = "....",
                NhdImage = "/images/Book-4.jpg",
                NhdPrice = "105.000",
                NhdPage = "245"
            },
            new NhdBook
            {
                NhdId = "5",
                NhdTitle = "Gió đầu lạnh mùa",
                NhdDescription = "....",
                NhdImage = "/images/Book-5.jpg",
                NhdPrice = "89.000",
                NhdPage = "190"
            }
        };

        public IActionResult NhdIndex()
        {
            return View(nhdbooks);
        }

        public IActionResult NhdCreate()
        {
            NhdBook book = new NhdBook();
            return View(book); // Gửi form rỗng
        }

        [HttpPost]
        public IActionResult NhdCreateSubmit(NhdBook book)
        {
            nhdbooks.Add(book); // thêm vào danh sách
            return RedirectToAction("NhdIndex");
        }

        public IActionResult NhdEdit(string id)
        {
            var book = nhdbooks.FirstOrDefault(b => b.NhdId == id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public IActionResult NhdEditSubmit(NhdBook updatedBook)
        {
            var book = nhdbooks.FirstOrDefault(b => b.NhdId == updatedBook.NhdId);
            if (book != null)
            {
                book.NhdTitle = updatedBook.NhdTitle;
                book.NhdDescription = updatedBook.NhdDescription;
                book.NhdImage = updatedBook.NhdImage;
                book.NhdPrice = updatedBook.NhdPrice;
                book.NhdPage = updatedBook.NhdPage;
            }
            return RedirectToAction("NhdIndex");
        }
        public IActionResult NhdDelete(string id)
        {
            var book = nhdbooks.FirstOrDefault(b => b.NhdId == id);
            if (book != null)
            {
                nhdbooks.Remove(book);
            }
            return RedirectToAction("NhdIndex");
        }
    }
}
