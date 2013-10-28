using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Http;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers.SurfaceControllers
{
    public class TestFormController : SurfaceController
    {
        public string TestFormAction(TestForm form)
        {
            var test = "test!";

            return "test";
        }
    }
}