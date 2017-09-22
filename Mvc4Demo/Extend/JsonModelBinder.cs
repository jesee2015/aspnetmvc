using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Mvc4Demo.Extend
{

    public class JsonModelBinder : DefaultModelBinder 
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            string json = string.Empty;
            var provider = bindingContext.ValueProvider;
            var providerValue = provider.GetValue(bindingContext.ModelName);

            if (providerValue != null)
                json = providerValue.AttemptedValue;

            if (Regex.IsMatch(json, @"^(\[.*\]|{.*})$"))
                return new JavaScriptSerializer().Deserialize(json, bindingContext.ModelType);

            return base.BindModel(controllerContext, bindingContext);
        }
    }
    #region
    //public class JsonModelBinder<T> : IModelBinder
    //{
    //    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    //    {
    //        string json = string.Empty;
    //        json = controllerContext.HttpContext.Request.Form[bindingContext.ModelName] as string;
    //        if (json.StartsWith("{") && json.EndsWith("}"))
    //        {
    //            JObject jsonBody = JObject.Parse(json);
    //            JsonSerializer js = new JsonSerializer();
    //            object obj = js.Deserialize(jsonBody.CreateReader(), typeof(T));
    //            return obj;
    //        }
    //        //提交参数是数组
    //        if (json.StartsWith("[") && json.EndsWith("]"))
    //        {
    //            IList<T> list = new List<T>();
    //            JArray jsonRsp = JArray.Parse(json);

    //            if (jsonRsp != null)
    //            {
    //                for (int i = 0; i < jsonRsp.Count; i++)
    //                {
    //                    JsonSerializer js = new JsonSerializer();
    //                    object obj = js.Deserialize(jsonRsp[i].CreateReader(), typeof(T));
    //                    list.Add((T)obj);
    //                }
    //            }
    //            return list;
    //        }
    //        return null;
    //    }

    //}

    #endregion
}