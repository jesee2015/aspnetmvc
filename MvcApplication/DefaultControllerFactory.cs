using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;

namespace MvcApplication
{
    public class DefaultControllerFactory : IControllerFactory
    {
        private static List<Type> controllerTypes = new List<Type>();

        static DefaultControllerFactory()
        {
            foreach (Assembly assembly in BuildManager.GetReferencedAssemblies())
            {
                foreach (Type t in assembly.GetTypes().Where(type => typeof(IController).IsAssignableFrom(type)))
                {
                    controllerTypes.Add(t);
                }
            }

        }

        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            string typeName = controllerName + "Controller";
            Type controllerType = controllerTypes.FirstOrDefault(c => string.Compare(typeName, c.Name, true) == 0);
            if (controllerType == null)
            {
                return null;
            }
            return (IController)Activator.CreateInstance(controllerType);
        }
    }
}