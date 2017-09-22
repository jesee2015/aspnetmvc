using Mvc4Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Repository
{
    public class XEngineContext : DbContext
    {
        public XEngineContext()
            : base("XEngineContext")
        {

        }

        public DbSet<Auction> Auctions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}