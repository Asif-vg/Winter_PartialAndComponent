using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.ViewModel;

namespace Winter.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
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
