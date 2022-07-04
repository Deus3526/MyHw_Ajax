using Microsoft.AspNetCore.Mvc;
using MyHw_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHw_Ajax.Controllers
{
    public class HWController : Controller
    {
        private DemoContext db;
        public HWController(DemoContext con)
        {
            db=con;
        }
        public IActionResult HW1()
        {
            return View();
        }
        public IActionResult HW2()
        {
            return View();
        }
    }
}
