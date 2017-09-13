using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcApplication
{
    public interface IController
    {
        void Execute(RequestContext requestContext);
    }
}