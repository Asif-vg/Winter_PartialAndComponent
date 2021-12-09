using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.Models;
using Winter.ViewModel;

namespace Winter.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome vmHome = new VmHome()
            {
                Socials = _context.Socials.Include(s => s.SocialsImage).ToList(),
                Settings = _context.Setting.FirstOrDefault()
                //SocialImages = _context.SocialImages.ToList()
            };
            return View(vmHome);
        }

       
    }
}
