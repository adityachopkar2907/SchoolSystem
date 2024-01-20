using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class scapfoldingController : Controller
    {
        // GET: scapfolding
        public ActionResult Getemployeedetails()
        {
            var manager = EmpDetails();
            return View(manager);
        }
        

        private List<manager> EmpDetails()
        {
            return new List<manager>()
            {new manager(){id=101,name="Aditya",email="Aditya@gmail.com"},
            new manager(){id=102,name="khapekar",email="khapekar@gmail.com"},
            new manager(){id=101,name="pratham",email="prataham@gmail.com"},
            new manager(){id=101,name="rodge",email="rodge@gmail.com"},
            };
        }
       
    }
}