using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.BaseData
{
    public class CustomerController : Controller
    {
        public ActionResult GetAll()
        {
            var db = new TravelEntities();
            var customers = db.T_Customers.ToList();
            return Content(AppUtils.JsonSerializer(customers));
        }
    }
}