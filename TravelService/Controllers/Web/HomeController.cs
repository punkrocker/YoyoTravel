using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelService.Models;
using TravelService.Services;
using TravelService.Utils;

namespace TravelService.Controllers
{
    [LoginAttribute]
    public class HomeController : Controller
    {

        [LoginAttribute]
        public ActionResult Index()
        {
            return View();
        }

    }
}