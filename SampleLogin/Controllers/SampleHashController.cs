using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleLogin.DAL;
using SampleLogin.Models;

namespace SampleLogin.Controllers
{
    public class SampleHashController : Controller
    {
        // GET: SampleHash
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string password)
        {
            PenggunaDAL penggunaDAL = new PenggunaDAL();
            ViewBag.HasilHash = penggunaDAL.GetMD5Hash(password);

            return View();
        }
    }
}