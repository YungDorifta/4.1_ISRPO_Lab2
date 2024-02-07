using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Лаб2.Models;

namespace Лаб2.Controllers
{
    public class TestController : Controller
    {
        
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Title = "MyCafe";
            return View();
        }
        

        public ActionResult TestPage(TestModel testModel)
        {
            ViewBag.Author = testModel.Author;
            ViewBag.Books = testModel.Books;
            ViewBag.Year = testModel.Year;

            return View();
        }
    }
}