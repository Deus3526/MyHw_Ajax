using Microsoft.AspNetCore.Mvc;
using MyHw_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public ContentResult Check(string name)
        {
            var q = from m in db.Members where m.Name == name select m;
            if (q.Count() > 0) return Content($"已有名字為{name}的會員", "text/plain", System.Text.Encoding.UTF8);
            else
            {
                return Content($"{name}可使用", "text/plain", System.Text.Encoding.UTF8);
            }

        }
    }
}
