using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleLogin.DAL;
using SampleLogin.Models;

namespace SampleLogin.Controllers
{
    public class RegistrasiController : Controller
    {
        // GET: Registrasi
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pengguna pengguna)
        {
            PenggunaDAL penggunaDAL = new PenggunaDAL();
            try
            {
                if(ModelState.IsValid)
                {
                    penggunaDAL.Registrasi(pengguna);
                    ViewBag.Pesan = "Data Pengguna berhasil ditambah !";
                }
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}