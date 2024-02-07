using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Лаб2.Models;

namespace Лаб2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "MyCafe";
            return View();
        }

        [HttpGet]
        public ViewResult DrinkForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }

        //через тег формы + 2-3 параметра
        [HttpGet]
        public ViewResult ShowAuthor(string Author, int Books, int Year)
        {
            ViewBag.Author = Author;
            ViewBag.Books = Books;
            ViewBag.Year = Year;
            return View();
        }

        [HttpPost]
        public ViewResult DrinkForm(DrinkData drinkData)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Bill";
                switch (drinkData.DrinkType) {
                    case DrinkType.Tea: {
                            ViewBag.Cost = 30;
                            break;
                        }
                    case DrinkType.Juice:
                        {
                            ViewBag.Cost = 40;
                            break;
                        }
                    case DrinkType.Coffee:
                        {
                            ViewBag.Cost = 130;
                            break;
                        }
                    case DrinkType.Alcohol:
                        {
                            ViewBag.Cost = 300;
                            break;
                        }
                    default:
                        {
                            ViewBag.Cost = 150;
                            break;
                        }
                }
                ViewBag.Cost += drinkData.Milk * 10;
                ViewBag.Cost += drinkData.Sugar * 5;
                return View("Bill", drinkData);
            }
            else
            {
                return View();
            }
        }
    }
}