using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CRUD_using_EF.Models
{
    public class ABCCompanyDbContext : DbContext
    {
        public ABCCompanyDbContext() : base("ABC_DB_CS")
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}