using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelService.Models;
using TravelService.Services;
using TravelService.Utils;

namespace TravelService.Controllers.Web
{
    [LoginAttribute]
    public class BusinessController : Controller
    {
        // GET: Business
        public ActionResult Index(int? typeID)
        {
            var allServices = new AllServiceViewModel();
            allServices.AllServices = BusinessService.GetAllServices(typeID);
            allServices.AllTypes = BusinessService.GetAllServiceTypes();
            allServices.TypeID = typeID;
            return View(allServices);
        }

        public ActionResult Detail(int? serviceID, int? typeID)
        {
            var serviceDetail = BusinessService.GetServiceDetail(serviceID, typeID);
            if (typeID == Utils.WebConst.HOTEL_TYPE)
                return View("Detail_Hotel", serviceDetail);
            else
                return View("Detail_Project", serviceDetail);
        }
    }
}