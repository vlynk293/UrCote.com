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
        [Route("{cote?}")]
        public ActionResult Index(string cote)
        {


            return View();
        }
    }
}