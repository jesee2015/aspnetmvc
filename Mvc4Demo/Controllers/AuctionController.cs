using Mvc4Demo.DataModel;
using Mvc4Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Demo.Controllers
{
    public class AuctionController : Controller
    {
        //
        // GET: /Auction/

        DataContext dbContext;

        public ActionResult Index()
        {
            return View();
        }
        public AuctionController()
        {
            if (dbContext == null)
                dbContext = new DataContext();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            if (ModelState.IsValid)
            {
                auction.Id = Guid.NewGuid();
                auction.EndTime = DateTime.Now;
                dbContext.Auctions.Add(auction);
                return RedirectToAction("Index");
            }
            return View(auction);
        }

    }
}
