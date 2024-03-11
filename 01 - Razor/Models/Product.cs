using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VjezbaRazor.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public string Kategorija { set; get; }
    }
}