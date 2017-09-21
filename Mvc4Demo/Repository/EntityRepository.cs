using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Repository
{
    public class EntityRepository
    {

        private DbContext _dbContext;
        public EntityRepository()
        {
            _dbContext = new DbContext("");
        }

        //public List<T> GetAll<T>()
        //{
        //    _dbContext.Set<
        //}
    }
}