using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcApplication
{
    public class MvcHandler : IHttpHandler
    {
        public RequestContext RequestContext { get; private set; }

        public MvcHandler(RequestContext requestContext)
        {
            this.RequestContext = requestContext;
        }

        public bool IsReusable
        {
            get { throw new NotImplementedException(); }
        }

        public void ProcessRequest(HttpContext context)
        {
            object controllerObj;
            RequestContext.RouteData.Values.TryGetValue("controller", out controllerObj);
            string controllerName = controllerObj.ToString();//控制器名称
            //工厂模式创建一个控制器
            IControllerFactory ControllerFactory = ControllerBuilder.Current.GetControllerFactory();
            IController controller = ControllerFactory.CreateController(RequestContext, controllerName);

            controller.Execute(RequestContext);
        }
    }
}