using Gonzalez_Rodrigo_lppa_parcial1.RG.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Gonzalez_Rodrigo_lppa_parcial1.RG.Data.Services
{
    public class lppaDBContext : DbContext
    {
        public DbSet<Afiliados> Products { get; set; }

        public lppaDBContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}