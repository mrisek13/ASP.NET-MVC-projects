using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VjezbaRazor.Models;

namespace VjezbaRazor.Controllers
{
    public class ProductController : Controller
    {
        Product mojProduct = new Product {
            ProductID = 1,
            Naziv = "Reket",
            Opis = "Nogometna lopta",
            Cijena = 852,
            Kategorija = "Sport"
        };

        // GET: Product
        public ActionResult ProductWeb()
        {
            // odredimo trenutno vrijeme na serveru
            int sati = DateTime.Now.Hour;
            ViewBag.Pozdrav = sati < 12 ? "Želim dobro jutro!" : "Ugodno popodne.";
            return View(mojProduct);
        }
    }
}