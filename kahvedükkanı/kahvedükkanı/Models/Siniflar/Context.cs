using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity ;
namespace kahvedükkanı.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Menu> Menus { get; set; } 

    }
}