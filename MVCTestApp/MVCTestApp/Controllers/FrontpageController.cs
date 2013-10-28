using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Web.Models;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers
{
    public class FrontpageController : RenderMvcController
    {
        public ActionResult Frontpage(RenderModel renderModel)
        {
            FrontpageRenderModel model = new FrontpageRenderModel();

            model.Header = "TESTHEADER!!!";

            model.Form = new TestForm() {};

            return View(model);
        }
    }
}