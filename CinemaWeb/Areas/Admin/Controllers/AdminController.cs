using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace CinemaWeb.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        // GET: AdminController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                tk.HoTen = us.SelectToken("HoTen").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
