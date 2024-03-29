﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MainDomain.Repositories;
namespace ClassWork2.Controllers
{
    public class HomeController : Controller
    {
        SystemContext _db = new SystemContext();

        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Emp = _db.Employees.Take(1).ToList();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}