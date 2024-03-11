using PAUP_Vj2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAUP_Vj2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Primjer1()
        {
            ViewBag.Message = "Primjer korištenja HTML.ActionLink elementa.";

            return View();
        }

        public ActionResult Primjer2()
        {
            ViewBag.Message = "Primjer 2.";

            return View();
        }

        [HttpPost]
        public ActionResult Primjer2(Student _student)
        {
            ViewBag.Message = "Primjer 2 - TextBox.";

            return View("Student", _student);
        }

        public ActionResult Student() {
            ViewBag.Message = "Upisani podaci o studentu";

            return View();
        }

        public ActionResult Primjer3()
        {
            ViewBag.Message = "Primjer 3.";

            return View();
        }

        [HttpPost]
        public ActionResult Primjer3(Student _student)
        {
            ViewBag.Message = "Primjer 3 - TextBox.";

            return View("Student2", _student);
        }
    }
}