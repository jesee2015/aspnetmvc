using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcApplication
{
    public abstract class RouteBase
    {
        public abstract RouteData GetRouteData(HttpContextBase httpContext);
    }
}
