﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication
{
   public interface IActionInvoker
    {
       void InvokeAction(ControllerContext context, string actionName);
    }
}
