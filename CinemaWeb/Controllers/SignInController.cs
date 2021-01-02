using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CinemaWeb.Data;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Areas.Admin.Data;

namespace CinemaWeb.Controllers
{
    public class SignInController : Controller
    {
        private readonly DPContext _context;
        public SignInController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sign_Up()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Username,Password")] TaiKhoanModel taikhoan)
        {
            var r = _context.TaiKhoan.Where(m => (m.Username == taikhoan.Username && m.Password ==
             StringProcessing.CreateMD5Hash(taikhoan.Password))).ToList();
            if (r.Count == 0)
            {
                string message = "Tài khoản hoặc mật khẩu không đúng.";
                SetAlert(message, 2);
                return View("Index");
            }
            //gắn session
            //var str = JsonConvert.SerializeObject(taikhoan);
            //HttpContext.Session.SetString("user", str);
            if (r[0].LoaiTK == "Admin")
            {
                //var url = Url.RouteUrl("areas", new { controller = "Admin", action = "Index", area = "Admin" });
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register([Bind("Username,Password")] TaiKhoanModel taikhoan)
        {
            var check = _context.TaiKhoan.FirstOrDefault(s => s.Username == taikhoan.Username);
            if (check==null)
            {
                taikhoan.Password = StringProcessing.CreateMD5Hash(taikhoan.Password);
                taikhoan.LoaiTK = "Member";
                _context.TaiKhoan.Add(taikhoan);
                _context.SaveChanges();
                string message = "Đăng ký thành công.";
                SetAlert(message,1);
                return RedirectToAction("Sign_Up", "SignIn");
            }
            else
            {
                string message = "Email đã tồn tại.";
                SetAlert(message, 2);
                return View("Sign_Up");
            }
        }
        protected void SetAlert(string message, int type)
        {
            TempData["AlertMessage"] = message;
            if (type == 1)
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == 2)
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == 3)
            {
                TempData["AlertType"] = "alert-danger";
            }
            else
            {
                TempData["AlertType"] = "alert-info";
            }
        }
    }
}
