using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Лаб2.Models
{
    public class DrinkData
    {
        public DrinkType DrinkType { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите молоко")]
        public int Milk { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите молоко")]
        public int Sugar { get; set; }
    }

    public enum DrinkType
    {
        Tea,
        Coffee,
        Juice,
        Alcohol
    }
}