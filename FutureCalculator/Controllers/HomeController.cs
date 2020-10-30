using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutureCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel fv)
        {
            if (ModelState.IsValid)
            {
            ViewBag.FutureValue = fv.Calculate().ToString("c2");
           
            }
            else
            {
                ViewBag.Futurevalue = null;
            }

            return View();
        }
    }
}
