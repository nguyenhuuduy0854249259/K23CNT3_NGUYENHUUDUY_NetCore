using Microsoft.AspNetCore.Mvc;

namespace Session02.Controllers
{
    public class ProductController : Controller
    {
        // trả về view cùng với tên Action trong thư mục /View/product
        public IActionResult Index()
        {
            ViewData["messageVD"] = "Dữ liệu lưu trữ trong ViewData";
            ViewBag.messageVB = "Dữ liệu lưu trữ trong ViewBag";
            TempData["messageTD"] = "Dữ liệu lưu trữ trong TemData";
            return View();
        }
        public IActionResult GetAllProducts() 
        {
            return View("Products");
        }
        public IActionResult GetProducts()
        {
            Product p = new Product
            {

            }
        }
    }

}
