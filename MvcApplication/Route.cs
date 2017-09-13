using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcApplication
{
    public class Routeddd : RouteBase
    {
        public IRouteHandler RouteHandler;
        public string Url;

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            IDictionary<string, object> variables;
            IDictionary<string, object> dataTokens;
            if (this.Match(httpContext.Request.AppRelativeCurrentExecutionFilePath.Substring(2), out variables))
            {
                RouteData routeData = new RouteData();
                foreach (var item in variables)
                {
                    routeData.Values.Add(item.Key, item.Value);
                }
                //foreach (var item in dataTokens)
                //{
                //    routeData.DataTokens.Add(item.Key, item.Value);
                //}
                routeData.RouteHandler = this.RouteHandler;
                return routeData;
            }
            return null;
        }

        private bool Match(string requestUrl, out IDictionary<string, object> variables)
        {
            //variables = new Dictionary<string, object>();
            //string strArray1 = requestUrl.Split('/');
            variables = new Dictionary<string, object>();
            return false;
        }
    }
}