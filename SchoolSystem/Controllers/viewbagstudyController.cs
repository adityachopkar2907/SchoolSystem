using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class viewbagstudyController : Controller
    {
        // GET: viewbagstudy
        public ActionResult viewbagstudy()
        {
            //  SIMPLE DATA USING VIEWBAG
            ViewBag.Myname = "Aditya";
            

            //COLLECTION SEND USING VIEWBAG
            List<string> citylist= new List<string>() {"Nagpur","pune","Mumbai","Delhi" };
            ViewBag.citylist = citylist;

            //HOW TO SEND VIEWBAG USING MODELS
            List<manager> manager = new List<manager>()
            {
                new manager() { id = 1, name = "Aditya", email = "adity@gmail.com" },
                new manager() { id = 2, name = "khapekar", email = "khaprkar@gmail.com" },
                new manager() { id = 3, name = "Pratham", email = "pratahm@gmail.com" },
                new manager() { id = 4, name = "Rodge", email = "Rodge@gmail.com" }
            };
            ViewBag.manager = manager;
            return View();

        }
        public ActionResult viewdatastudy()
        {
            //Simple data
            ViewData["Name"] = "Today we are learning view data in MVC";
            //By using list
            List<string> Citylist= new List<string>() { "Nagpur", "pune", "Mumbai", "Delhi" };
            ViewData["Citylist"]= Citylist;

            return View();
        }

    }
}