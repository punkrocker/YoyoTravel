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
    public class TripController : Controller
    {
        // GET: Trip
        public ActionResult Index()
        {
            var trips = TripService.GetSchedule();
            return View(trips);
        }

        [HttpPost]
        [ActionName("Add")]
        public ActionResult AddTrip(string trip_name, int trip_price, 
            string customer_name, int trip_days, 
            string trip_date, string custom_require,
            string remark)
        {
            TripService.AddTrip(trip_name, trip_price,customer_name,trip_days,trip_date,custom_require, remark);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int? tripID)
        {
            var tripDetails = TripService.GetScheduleDetail(tripID);
            var services = BusinessService.GetAllServices(null).ToList();
            TripDetailListViewModel model = new TripDetailListViewModel
            {
                tripDetails = tripDetails,
                services = services
            };
            return View(model);
        }

        public ActionResult NewDay(int? tripID)
        {
            var services = BusinessService.GetAllServices(null).Where(a => a.Type != WebConst.HOTEL_TYPE).ToList();
            return View(services);
        }

        [HttpPost]
        [ActionName("AddNewDay")]
        public ActionResult AddNewDay(int tripID, string services, string desc)
        {
            TripService.AddNewDay(tripID, services, desc);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [HttpPost]
        [ActionName("AddEmptyDay")]
        public ActionResult AddEmptyDay(int tripID)
        {
            TripService.AddNewDay(tripID);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [HttpPost]
        [ActionName("DeleteDay")]
        public ActionResult DeleteDay(int tripID, int seq)
        {
            TripService.DeleteDay(tripID, seq);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [HttpPost]
        [ActionName("EditDayDesc")]
        public ActionResult EditDayDesc(int tripID, int seq, string desc)
        {
            TripService.EditDayDesc(tripID, seq, desc);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [HttpPost]
        [ActionName("AddProject")]
        public ActionResult AddProject(int tripID, int seq, string start, string end, string projectID)
        {
            TripService.AddProject(tripID, seq, start, end, projectID);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [HttpPost]
        [ActionName("DeleteProject")]
        public ActionResult DeleteProject(int tripID, int seq, int projectSeq)
        {
            TripService.DeleteProject(tripID, seq, projectSeq);
            return RedirectToAction("Detail", new
            {
                tripID = tripID
            });
        }

        [AllowAnonymous]
        public ActionResult Share(int? tripID)
        {
            var tripDetails = TripService.GetShareSchedule(tripID);
            return View(tripDetails);
        }
    }
}