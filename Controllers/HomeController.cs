using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        EmployeeEntity ee = new EmployeeEntity();
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult im()
        {
            return View();
        }
        
        public ActionResult Create([Bind] EmployeeDb employeeDb)
        {
            string resp = ee.InsertRecord(employeeDb);
            TempData["msg"] = resp;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}