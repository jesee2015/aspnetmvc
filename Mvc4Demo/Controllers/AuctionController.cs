using Mvc4Demo.Extend;
using Mvc4Demo.Models;
using Mvc4Demo.Repository;
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
        private IAuctionRepository AuctionRepository;
        public AuctionController(IAuctionRepository auctionRepository)
        {
            AuctionRepository = auctionRepository;
        }
        public ActionResult Index()
        {
            List<Auction> auctions = AuctionRepository.GetAuction().ToList();
            return View(auctions);
        }

        public ActionResult GetJsonpAuctions()
        {
            List<Auction> auctions = AuctionRepository.GetAuction().ToList();
            return new JsonpResult { Data = auctions };
        }

        [HttpPost]
        public JsonResult GetAuctions(List<Auction> auctions)
        {
            return Json(auctions);
        }

        public PartialViewResult AuctionView()
        {
            List<Auction> auctions = AuctionRepository.GetAuction().ToList();
            return PartialView(auctions);
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
                AuctionRepository.Add(auction);
                AuctionRepository.Save();
                return RedirectToAction("Index");
            }
            return View(auction);
        }

    }
}
