﻿using System;
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
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}