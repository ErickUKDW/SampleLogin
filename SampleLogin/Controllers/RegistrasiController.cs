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

        public ActionResult Index(Pengguna pengguna)
        {
            
        }
    }
}