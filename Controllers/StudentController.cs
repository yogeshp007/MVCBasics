using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    //[RoutePrefix("yogesh")]
    public class StudentController : Controller
    {
        [Route("200")]
        public string MyName()
        {
            return "mv example";
        }

        // GET: Student
        public ActionResult ViewStudents()
        {
            return View();
        }

        public ActionResult Test(string name)
        {
            object obj = name;
            if (name != null)
                return View("ViewStudents", obj);
            else
                return View();
        }
    }
}