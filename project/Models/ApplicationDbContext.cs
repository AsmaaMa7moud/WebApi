using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext():base("WebApi2")
        {

        }
        public DbSet<Product> Products { get; set; }

       
    }
}