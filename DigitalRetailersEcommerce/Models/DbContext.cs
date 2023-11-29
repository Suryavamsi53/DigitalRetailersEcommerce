using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace DigitalRetailersEcommerce.Models
{
    public class DbContext
    {
    

        // Add DbSet properties for your models (e.g., Laptop)
        public DbSet<Laptop> Laptops { get; set; }
    }
}