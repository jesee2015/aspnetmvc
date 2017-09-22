using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModelBinderDemo.Models
{
    public class Auction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartSpan { get; set; }
        public decimal CurrentPrice { get; set; }
        public List<Bids> Bids { get; set; }
    }

    public class Bids
    {
        public DateTime TimeSpan { get; set; }

        public decimal Amount { get; set; }
    }
}