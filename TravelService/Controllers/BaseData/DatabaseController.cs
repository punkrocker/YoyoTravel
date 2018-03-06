using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.BaseData
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InitProjectTypes()
        {
            using (var db = new TravelEntities())
            {
                String[] types = { "车辆接送", "一日游", "门票", "潜水", "SPA按摩", "包船" };
                var originTypes = db.T_TravelProjectTypes.ToList();
                db.T_TravelProjectTypes.RemoveRange(originTypes);
                foreach (String typeName in types)
                {
                    T_TravelProjectTypes newType = new T_TravelProjectTypes();
                    newType.ProjectTypeName = typeName;
                    db.T_TravelProjectTypes.Add(newType);
                }
                db.SaveChanges();
                return Content("初始化完成");
            }
        }
    }
}