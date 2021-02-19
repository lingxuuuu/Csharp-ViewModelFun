using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Csharp_ViewModelFun.Models;

namespace Csharp_ViewModelFun.Models
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet("")]
        public IActionResult Index()
        {
            Models.Message message = new Models.Message("Lorem ipsum dolor sit amet, nec stet rebum offendit ne, ius te nullam postulant. Mel meliore deserunt ne, mei id nullam impetus, porro iracundia temporibus pro in. Sed an eruditi recusabo euripidis, ad nusquam percipitur eam.");
            return View("index", message);
        }
        [HttpGet("numbers")]
        public IActionResult Numberpage()
        {
            int[] array = { 1,2,3,10,43,5,9,3,400 };
            Models.Number numlist = new Models.Number(array);
            return View("numbers", numlist);
        }
        [HttpGet("users")]
        public IActionResult Userspage()
        {
            string[] array = { "Siouxsie","Steven","Budgie","Robert","Sid","Marco"};
            Models.User peoplelist = new Models.User(array);
            return View("users", peoplelist);
        }
        [HttpGet("user")]
        public IActionResult Userpage()
        {
            string ppl = "Siouxsie";
            Models.User person = new Models.User(ppl);
            return View("user", person);
        }
    }
}

