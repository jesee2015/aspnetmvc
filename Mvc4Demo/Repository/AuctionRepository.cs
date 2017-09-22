using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Repository
{
    public class AuctionRepository : IAuctionRepository
    {
        private XEngineContext _dbContext;
        public AuctionRepository(XEngineContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Models.Auction> GetAuction()
        {
            return _dbContext.Auctions.ToList();
        }

        public Models.Auction GetAuctionById(Guid Id)
        {
            return _dbContext.Auctions.Find(Id);
        }

        public void Add(Models.Auction auction)
        {
            _dbContext.Auctions.Add(auction);
        }

        public void Dele(Guid Id)
        {
            var a = GetAuctionById(Id);
            _dbContext.Auctions.Remove(a);
        }

        public void UpdateUser(Models.Auction auction)
        {
            _dbContext.Entry(auction).State = System.Data.EntityState.Modified;

        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        //关闭连接
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing) { _dbContext.Dispose(); }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}