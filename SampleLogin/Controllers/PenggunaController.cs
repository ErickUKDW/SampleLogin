using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleLogin.DAL;
using SampleLogin.Models;

namespace SampleLogin.Controllers
{
    public class PenggunaController : Controller
    {
        // GET: Pengguna
        public ActionResult Index()
        {
            //cek apakah user sudah login
            //jika user belum login
            if(Session["pengguna"]==null)
            {
                TempData["pesan"] = 
                    "<div class='alert alert-info'>Anda harus melakukan Login terlebih dahulu</div>";
                return RedirectToAction("Login");
            }
            else
            {
                Pengguna objPengguna = (Pengguna)Session["pengguna"];
                return View(objPengguna);
            }
            
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Pengguna pengguna)
        {
            PenggunaDAL penggunaDAL = new PenggunaDAL();
            var objPengguna = penggunaDAL.LoginPengguna(pengguna);

            if(objPengguna!=null)
            {
                //jika login berhasil bautkan session baru
                Session["pengguna"] = objPengguna;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "<div class='alert alert-danger'>Login Gagal !</div>";
                return View();
            }
        }
    }
}