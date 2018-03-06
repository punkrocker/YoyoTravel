using Common;
using Model;
using Model.CallResult;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.BaseData
{
    public class TravelServiceController : Controller
    {
        // GET: TravelService
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TravelProjectDto travelProject)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = SystemConst.MSG_ERR_UNKNOWN
            };

            using (var db = new TravelEntities())
            {
                T_TravelProjects selectTravelProject = new T_TravelProjects
                {
                    ProjectName = travelProject.ProjectName,
                    AdultFee = travelProject.AdultFee,
                    ChildFee = travelProject.ChildFee,
                    SupplierID = travelProject.SupplierID,
                    AgentAdultFee = travelProject.AgentAdultFee,
                    AgentChildFee = travelProject.AgentChildFee,
                    Description = travelProject.Description,
                    ProjectTypeID = travelProject.ProjectTypeID,
                    Remark = travelProject.Remark,
                    CoverPic = travelProject.CoverPic
                };
                db.T_TravelProjects.Add(selectTravelProject);
                db.SaveChanges();
            }

            return Content(AppUtils.JsonSerializer(result));
        }

        [HttpPost]
        public ActionResult Modify(TravelProjectDto travelProject)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = SystemConst.MSG_ERR_UNKNOWN
            };

            using (var db = new TravelEntities())
            {
                T_TravelProjects selectTravelProject = db.T_TravelProjects.FirstOrDefault(a => a.ProjectID == travelProject.ProjectID);
                selectTravelProject.ProjectName = travelProject.ProjectName;
                selectTravelProject.AdultFee = travelProject.AdultFee;
                selectTravelProject.ChildFee = travelProject.ChildFee;
                selectTravelProject.AgentAdultFee = travelProject.AgentAdultFee;
                selectTravelProject.AgentChildFee = travelProject.AgentChildFee;
                selectTravelProject.Description = travelProject.Description;
                selectTravelProject.ProjectTypeID = travelProject.ProjectTypeID;
                selectTravelProject.Remark = travelProject.Remark;
                selectTravelProject.CoverPic = travelProject.CoverPic;
                db.T_TravelProjects.Attach(selectTravelProject);
                db.Entry(selectTravelProject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult GetAllProjectTypes()
        {
            using (var db = new TravelEntities())
            {
                var projectTypes = db.T_TravelProjectTypes.ToList();
                return Content(AppUtils.JsonSerializer(projectTypes));
            }
        }
    }
}