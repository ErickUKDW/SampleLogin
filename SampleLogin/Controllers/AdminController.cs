using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleLogin.Models;
using SampleLogin.DAL;

namespace SampleLogin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["pengguna"] == null)
            {
                return RedirectToAction("Login", "Pengguna");
            }
            else
            {
                var objPengguna = (Pengguna)Session["pengguna"];
                if (objPengguna.Aturan != "Admin")
                {
                    TempData["pesan"] =
                    @"<div class='alert alert-info'>Anda harus melakukan Login 
                      sebagai admin terlebih dahulu</div>";
                    return RedirectToAction("Login", "Pengguna");
                }
                else
                {
                    return View(objPengguna);
                }
            }

        }
    }
}