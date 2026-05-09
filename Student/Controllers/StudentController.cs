using Microsoft.AspNetCore.Mvc;
using Student.Models;
namespace Student.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowKQ(StudentModel sv)
        {
            // Giả lập số lượng sinh viên cùng ngành
            ViewBag.SoLuong = new Random().Next(1, 100);
            return View(sv);
        }
    }
}
