using Mvc4Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc4Demo.DataModel
{
    public class DataContext : System.Data.Entity.DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
    }
}