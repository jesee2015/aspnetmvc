using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcApplication
{
    public class RouteData
    {
        //直接从请求地址解析出来的变量列表
        public IDictionary<string, object> Values { get; private set; }
        //前者代表直接从请求地址解析出来的变量列表
        public IDictionary<string, object> DataTokens { get; private set; }

        public IRouteHandler RouteHandler { get; set; }
        public Route Route { get; set; }
        //MvcHandler
        public RouteData()
        {
            this.DataTokens = new Dictionary<string, object>();
            this.Values = new Dictionary<string, object>();
            this.DataTokens.Add("namespaces", new List<string>());
        }
        public string Controller
        {
            get
            {
                object controllerName = string.Empty;
                this.Values.TryGetValue("controller", out controllerName);
                return controllerName.ToString();
            }
        }

        public string ActionName
        {
            get
            {
                object actionName = string.Empty;
                this.Values.TryGetValue("action", out actionName);
                return actionName.ToString();
            }
        }
    }
}