using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Datacontext:DbContext
    {
        public Datacontext():base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<Parcial1.Models.Product> Products { get; set; }
    }
}