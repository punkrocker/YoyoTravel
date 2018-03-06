using Common;
using Model;
using Model.CallResult;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.BaseData
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(HotelDto hotel)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = SystemConst.MSG_ERR_UNKNOWN
            };

            using (var db = new TravelEntities())
            {
                T_LiveProjects selectedHotel = new T_LiveProjects
                {
                    HouseName = hotel.HouseName,
                    Fee = hotel.Fee,
                    SupplierID = hotel.SupplierID,
                    AgentFee = hotel.AgentFee,
                    Pics = hotel.Pics,
                    CoverPic = hotel.CoverPic,
                    Description = hotel.Description,
                    Remark = hotel.Remark
                };
                db.T_LiveProjects.Add(selectedHotel);
                db.SaveChanges();
            }

            return Content(AppUtils.JsonSerializer(result));
        }

        [HttpPost]
        public ActionResult Modify(HotelDto hotel)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = SystemConst.MSG_ERR_UNKNOWN
            };

            using (var db = new TravelEntities())
            {
                T_LiveProjects selectedHotel = db.T_LiveProjects.FirstOrDefault(a => a.HouseID == hotel.HouseID);
                selectedHotel.HouseName = hotel.HouseName;
                selectedHotel.Fee = hotel.Fee;
                selectedHotel.AgentFee = hotel.AgentFee;
                selectedHotel.CoverPic = hotel.CoverPic;
                selectedHotel.Description = hotel.Description;
                selectedHotel.Remark = hotel.Remark;
                selectedHotel.Pics = hotel.Pics;
                db.T_LiveProjects.Attach(selectedHotel);
                db.Entry(selectedHotel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Content(AppUtils.JsonSerializer(result));
        }
    }
}