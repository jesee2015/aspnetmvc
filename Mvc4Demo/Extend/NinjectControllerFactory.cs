using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Mvc4Demo.Repository;

namespace Mvc4Demo.Extend
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            this.ninjectKernel = new StandardKernel();
            AddBinders();
        }

        private void AddBinders()
        {
            //增加服务绑定
            ninjectKernel.Bind<IAuctionRepository>().To<AuctionRepository>();
        }
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}