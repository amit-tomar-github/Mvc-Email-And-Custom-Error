using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxiWebApp.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(Exception errorMsg)
        {
            ViewBag.ErrorObj = errorMsg;
            return View("ErroFromGlobal");
        }
    }
}