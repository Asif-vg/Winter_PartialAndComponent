using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Models;

namespace Winter.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {

        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialImage> SocialImages { get; set; }

    }
}
