using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace SchoolSystem.Controllers
{
    public class senddatafromviewController : Controller
    {
        // GET: senddatafromview
        public ActionResult senddatausingparameter(string FirstName,string Lastname)
        {
            string mydetails = "First Name" + FirstName + "|Last Name" + Lastname;
            if(!FirstName.IsEmpty() && ! Lastname.IsEmpty()) 
            ViewBag.mydtails = mydetails;
            return View();
        }
        public string SenddatausingRequest()
        {
            string FN = Request["FirstName"];
            string LN = Request["LastName"];
            string mydetails = "First Name" + FN + "|Last Name" + LN;
            
            return mydetails;
        }
        public ActionResult senddatausingbinding(simple_name SN)
        {
            string FN = SN.firstname;
            string LN = SN.lastname;
            ViewBag.Myproperty = FN;
            ViewData["Myproperty"] = LN;
            return View();
        }

    }
}