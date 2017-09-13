using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;

namespace MvcApplication
{
    public abstract class ControllerBase : IController
    {
        protected IActionInvoker ActionInvoker { get; set; }
        public ControllerBase()
        {
            this.ActionInvoker = new ControllerActionInvoker();
        }
        public void Execute(RequestContext requestContext)
        {
            ControllerContext context = new ControllerContext
            {
                RequestContext = requestContext,
                Controller = this
            };
            string actionName = "actionName";
            this.ActionInvoker.InvokeAction(context, actionName);
        }
    }
}
