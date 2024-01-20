using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public  ActionResult Getdetails()
        {
            return View();
        }
        public string GetName(int id,int cid)
        {
            string[] details=new string[5];
            details[0] = "Aditya";
            details[1] = "Prajwal";
            details[2] = "Pratham";
            details[3] = "Harsh";
            details[4] = "Ankit";

            string[] city = new string[5];
            city[0] = "Nagpur";
            city[1] = "pune";
            city[2] = "mumbai";
            city[3] = "Delhi";
            city[4] = "Pardi";
            return details[id]+" "+city[cid];
        }
    }
}