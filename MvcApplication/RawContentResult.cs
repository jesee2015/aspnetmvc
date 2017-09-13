using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication
{
    class RawContentResult : ActionResult
    {
        private string content;

        public RawContentResult(string content)
        {
            // TODO: Complete member initialization
            this.content = content;
        }
    }
}
