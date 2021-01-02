using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CinemaWeb.Data;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Areas.Admin.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

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
        public IActionResult Login([Bind("Email,Password")] TaiKhoanModel taikhoan)
        {
            if (taikhoan.Email != null && taikhoan.Password != null)
            {
                var r = _context.TaiKhoan.Where(m => (m.Email == taikhoan.Email && m.Password ==
                 StringProcessing.CreateMD5Hash(taikhoan.Password))).ToList();
                if (r.Count == 0)
                {
                    string message = "Tài khoản hoặc mật khẩu không đúng.";
                    SetAlert(message, 2);
                    return RedirectToAction("Index", "SignIn");
                }
                else
                {
                    var session = JsonConvert.SerializeObject(taikhoan);
                    HttpContext.Session.SetString("user", session);
                    if (r[0].LoaiTK == "Admin")
                    {
                        return RedirectToAction("Index", "Admin", new { area = "Admin" });
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                string message = "Tài khoản và mật khẩu không được để trống.";
                SetAlert(message, 3);
                return RedirectToAction("Index", "SignIn");
            }    
        }
        [HttpPost]
        public IActionResult Register([Bind("Email,Password")] TaiKhoanModel taikhoan)
        {
            if (taikhoan.Email != null && taikhoan.Password != null)
            {     
                var check = _context.TaiKhoan.FirstOrDefault(s => s.Email == taikhoan.Email);
                if (check == null)
                {
                    taikhoan.Password = StringProcessing.CreateMD5Hash(taikhoan.Password);
                    taikhoan.LoaiTK = "Member";
                    taikhoan.HoTen = "Mặc định";
                    taikhoan.SDT = "084";
                    taikhoan.TrangThai = true;
                    _context.TaiKhoan.Add(taikhoan);
                    _context.SaveChanges();
                    string message = "Đăng ký thành công.";
                    SetAlert(message, 1);
                    return RedirectToAction("Sign_Up", "SignIn");
                }
                else
                {
                    string message = "Email đã tồn tại.";
                    SetAlert(message, 2);
                    return RedirectToAction("Sign_Up", "SignIn");
                }
            }
            else
            {
                string message = "Tài khoản và mật khẩu không được để trống.";
                SetAlert(message, 3);
                return RedirectToAction("Sign_Up", "SignIn");
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
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "SignIn");
        }

    }
}
