using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace Mvc4Demo.Extend
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Struct | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class JsonModelBinderAttribute : CustomModelBinderAttribute
    {

        public override IModelBinder GetBinder()
        {
            return new JsonModelBinder() as IModelBinder;
        }
    }
}