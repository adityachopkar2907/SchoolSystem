using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Showemployee()
        {
           List<employee>emplist= EmployeDetails();
            return View(emplist);
        }
        private List<employee> EmployeDetails()
        {
            employee E1 = new employee()
            {
                id = 1,
                name = "john cena",
                designation = "Wrestler",
                companyname = "Raw",
                salary = 50000

            };
            employee E2 = new employee()
            {
                id = 1,
                name = "kane",
                designation = "Wrestler",
                companyname = "kusti",
                salary = 60000

            };
            employee E3 = new employee()
            {
                id = 1,
                name = "khali",
                designation = "Wrestler",
                companyname = "Pahelvan",
                salary = 70000

            };
            List<employee> employeelist = new List<employee>();
            {
                employeelist.Add(E1);
                employeelist.Add(E2);
                employeelist.Add(E3);
                return employeelist;
            }
        }
    }
}