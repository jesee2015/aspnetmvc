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

        public ActionResult Create()
        {
            return View();
        }

    }
}
