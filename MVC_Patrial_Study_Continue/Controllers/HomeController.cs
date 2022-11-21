using MVC_Patrial_Study_Continue.DesignPatterns.SingletonPattern;
using MVC_Patrial_Study_Continue.Models;
using MVC_Patrial_Study_Continue.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Patrial_Study_Continue.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities _db;
        public HomeController()
        {
            _db = DBTool.DBInstance;
        }

        public ActionResult Index()
        {
            HomeVM hvm = new HomeVM
            {
                Employees = _db.Employees.ToList()
            };
            return View(hvm);
        }

        public PartialViewResult GetAllCategories()
        {
            HomeVM hvm = new HomeVM
            {
                Categories = _db.Categories.ToList()
            };
            return PartialView("_CategoryPartial",hvm);
        }

       
    }
}