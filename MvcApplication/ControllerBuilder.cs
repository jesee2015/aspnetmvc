using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication
{
    public class ControllerBuilder
    {
        private Func<IControllerFactory> factoryThunk;
        public static ControllerBuilder Current { get; private set; }
        public ControllerBuilder()
        {
            Current = new ControllerBuilder();
        }

        public IControllerFactory GetControllerFactory() 
        {
            return factoryThunk();
        }

        public void setControllerFactory(IControllerFactory controllerFactory) 
        {
            factoryThunk = () => controllerFactory;
        }
    }
}