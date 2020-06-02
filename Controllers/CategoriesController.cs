using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string category)
       {
            //Store the selected product name in the viewbag container
            //viewbag is automatically passed back to the view that loads 
           ViewBag.category = category;

            return View();
        }
    }
}
