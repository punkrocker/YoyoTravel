using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelService.Models;
using TravelService.Utils;

namespace TravelService.Services
{
    public class BusinessService
    {
        private const int MAX_DESC_LENGTH = 20;
        public static IList<BaseServiceModel> GetAllServices(int? typeID)
        {
            using (var db = new TravelEntities())
            {
                var projects = (from service in db.T_TravelProjects
                                join projectType in db.T_TravelProjectTypes on service.ProjectTypeID equals projectType.ProjectTypeID into temp
                                from i in temp.DefaultIfEmpty()
                                select new BaseServiceModel
                                {
                                    ID = service.ProjectID,
                                    Name = service.ProjectName,
                                    TypeName = i.ProjectTypeName,
                                    Description = service.Description.Length > MAX_DESC_LENGTH ?
                                    service.Description.Substring(0, 20) + "..." :
                                    service.Description,
                                    Type = service.ProjectTypeID
                                }).ToList();
                var hotels = (from service in db.T_LiveProjects
                              select new BaseServiceModel
                              {
                                  ID = service.HouseID,
                                  Name = service.HouseName,
                                  TypeName = WebConst.HOTEL_TYPE_NAME,
                                  Description = service.Description.Length > MAX_DESC_LENGTH ?
                                  service.Description.Substring(0, 20) + "..." :
                                  service.Description,
                                  Type = 0
                              }).ToList();
                var allServices = projects.Concat(hotels).ToList();
                if (typeID == null || typeID == WebConst.ALL_TYPE)
                    return allServices;
                else
                {
                    return allServices.Where(a => a.Type == typeID).ToList();
                }
            }
        }

        public static ServiceDetailViewModel  GetServiceDetail(int? serviceID, int? typeID)
        {
            using (var db = new TravelEntities())
            {
                if (typeID == WebConst.HOTEL_TYPE)
                {
                    var hotel = (from service in db.T_LiveProjects
                                 join supplier in db.T_Suppliers on service.SupplierID equals supplier.SupplierID into temp
                                 from i in temp.DefaultIfEmpty()
                                 where service.HouseID == serviceID
                                select new ServiceDetailViewModel
                                {
                                    ServiceID = service.HouseID,
                                    ServiceName = service.HouseName,
                                    ProjectTypeName = WebConst.HOTEL_TYPE_NAME,
                                    AgentAdultFee = service.AgentFee,
                                    CoverPic = service.CoverPic,
                                    Pics = service.Pics,
                                    SupplierName = i.SupplierName,
                                    Description = service.Description,
                                    Remark = service.Remark,
                                }).FirstOrDefault();
                    return hotel;
                }
                else
                {
                    var project = (from service in db.T_TravelProjects
                                   join supplier in db.T_Suppliers on service.SupplierID equals supplier.SupplierID into temp
                                   from i in temp.DefaultIfEmpty()
                                   join travelType in db.T_TravelProjectTypes on service.ProjectTypeID equals travelType.ProjectTypeID into projectTypes
                                   from projectType in projectTypes.DefaultIfEmpty()
                                   where service.ProjectID == serviceID && service.ProjectTypeID == typeID
                                 select new ServiceDetailViewModel
                                 {
                                     ServiceID = service.ProjectID,
                                     ServiceName = service.ProjectName,
                                     ProjectTypeName = projectType.ProjectTypeName,
                                     AgentAdultFee = service.AgentAdultFee,
                                     AgentChildFee = service.AgentChildFee,
                                     SupplierName = i.SupplierName,
                                     CoverPic = service.CoverPic,
                                     Description = service.Description,
                                     Remark = service.Remark
                                 }).FirstOrDefault();
                    return project;
                }
            }
        }

        public static IList<T_TravelProjectTypes> GetAllServiceTypes()
        {
            using (var db = new TravelEntities())
            {
                var types = db.T_TravelProjectTypes.ToList();
                T_TravelProjectTypes allType = new T_TravelProjectTypes();
                allType.ProjectTypeID = WebConst.ALL_TYPE;
                allType.ProjectTypeName = WebConst.ALL_TYPE_NAME;
                types.Insert(0, allType);
                T_TravelProjectTypes hotelType = new T_TravelProjectTypes();
                hotelType.ProjectTypeID = WebConst.HOTEL_TYPE;
                hotelType.ProjectTypeName = WebConst.HOTEL_TYPE_NAME;
                types.Add(hotelType);
                return types;
            }
        }
    }
}