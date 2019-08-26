using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiDemoProject.Models {
    public class WebServiceDb : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public WebServiceDb(DbContextOptions options) : base(options) { }

    }
    
}
