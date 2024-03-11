using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAUP_Vj2.Models
{
    public class Student
    {
        [Display(Name ="Ime studenta")]
        public string Ime { get; set; }

        [Display(Name = "Prezime studenta")]
        public string Prezime { get; set; }

        [Display(Name = "Godina rođenja")]
        public int godina { get; set; }

        [Display(Name = "Spol")]
        public string spol { get; set; }

        [Display(Name = "Godina studija")]
        public int godina_studija { get; set; }
    }
}