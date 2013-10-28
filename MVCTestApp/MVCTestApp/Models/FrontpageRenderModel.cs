using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;

namespace MVCTestApp.Models
{
    public class FrontpageRenderModel : BaseRenderModel
    {
        public string Header { get; set; }

        public TestForm Form { get; set; }
    }
}