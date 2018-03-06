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
    public class GuideController : Controller
    {
        // GET: Guide
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var db = new TravelEntities();
            var guides = (from guide in db.T_Guides
                               select new GuideDto
                               {
                                   GuideID = guide.GuideID,
                                   GuideName = guide.GuideName,
                                   Tel = guide.Tel,
                                   Contact= guide.Contact,
                                   LandFee = guide.LandFee,
                                   AgentLandFee = guide.AgentLandFee,
                                   SeaFee = guide.SeaFee,
                                   AgentSeaFee = guide.AgentSeaFee,
                                   Remark = guide.Remark,
                               }).ToList();
            return Content(AppUtils.JsonSerializer(guides));
        }

        [HttpPost]
        public ActionResult AddNewGuide(GuideDto newGuide)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new TravelEntities())
            {
                try
                {
                    T_Guides guide = new T_Guides
                    {
                        GuideName = newGuide.GuideName,
                        Tel = newGuide.Tel,
                        Contact = newGuide.Contact,
                        LandFee = newGuide.LandFee,
                        AgentLandFee = newGuide.AgentLandFee,
                        SeaFee = newGuide.SeaFee,
                        AgentSeaFee = newGuide.AgentSeaFee,
                        Remark = newGuide.Remark
                    };
                    db.T_Guides.Add(guide);
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ModifyGuide(GuideDto guide)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new TravelEntities())
            {
                try
                {
                    T_Guides theGuide = db.T_Guides.FirstOrDefault(a => a.GuideID == guide.GuideID);
                    theGuide.Tel = guide.Tel;
                    theGuide.Contact = guide.Contact;
                    theGuide.LandFee = guide.LandFee;
                    theGuide.SeaFee = guide.SeaFee;
                    theGuide.AgentLandFee = guide.AgentLandFee;
                    theGuide.AgentSeaFee = guide.AgentSeaFee;
                    theGuide.Remark = guide.Remark;
                    db.T_Guides.Attach(theGuide);
                    db.Entry(theGuide).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }
    }
}