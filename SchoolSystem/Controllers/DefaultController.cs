using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Introduction()
        {
            return View();
        }
        public ActionResult ModelStudy()
        {
            Student S1 = Getstudent();

            return View(S1);
        }
        private Student Getstudent()
        {
            return new Student()
            {
                id = 101,
                Name = "Aditya",
                Address = "Ambe Nagar"
            };
        }

    }
}