using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Лаб2.Models{
    public class TestModel{
        public string Author { get; set; }
        [Required(ErrorMessage = "Введите автора")]

        public int Books { get; set; }
        [Required(ErrorMessage = "Введите кол-во книг")]

        public int Year { get; set; }
        [Required(ErrorMessage = "Введите год")]

        public string a;
    }
}