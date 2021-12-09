using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.Models;

namespace Winter.ViewComponents
{
    public class VcSocial : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcSocial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
    }
}
