using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name= "Blog";
            return View();
        }
    }
}
