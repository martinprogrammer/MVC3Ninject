using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;


namespace MVC3Ninject.Models
{
   // public class CarsContext: DbContext
    public class CarsContext : DbContext
    {
        public DbSet<Cars> theCars { get; set; }

        public ObjectContext ObjectContext()
        {
            return ((IObjectContextAdapter)this).ObjectContext;
        }

    }
}