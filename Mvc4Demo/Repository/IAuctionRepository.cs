using Mvc4Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Repository
{
    public interface IAuctionRepository : IDisposable
    {
        IEnumerable<Auction> GetAuction();
        Auction GetAuctionById(Guid Id);
        void Add(Auction auction);
        void Dele(Guid Id);
        void UpdateUser(Auction auction);
        void Save();
    }
}