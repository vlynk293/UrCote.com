using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrCote.com.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("{link?}")]
        public ActionResult Index(string link)
        {


            return View();
        }
    }
}