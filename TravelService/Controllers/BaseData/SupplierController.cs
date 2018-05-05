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
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Get()
        {
            using (var db = new TravelEntities())
            {
                var result = (from supplier in db.T_Suppliers
                              select new Supplier
                              {
                                  SupplierID = supplier.SupplierID,
                                  SupplierName = supplier.SupplierName,
                                  Contact = supplier.Contact
                              }).ToList();
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult Add(SupplierPara param)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };
            try
            {
                using (var db = new TravelEntities())
                {
                    var supplier = new T_Suppliers
                    {
                        SupplierName = param.supplier.SupplierName,
                        Contact = param.supplier.Contact,
                        HasHotel = SystemConst.TRUE,
                        HasService = SystemConst.TRUE
                    };
                    db.T_Suppliers.Add(supplier);
                    db.SaveChanges();

                    bool needSave = false;
                    if (param.travelProjects != null)
                        for (var i = 0; i < param.travelProjects.Count; i++)
                        {
                            TravelProjectDto travelProjectDto = param.travelProjects[i];
                            var travelProject = new T_TravelProjects
                            {
                                ProjectName = travelProjectDto.ProjectName,
                                AdultFee = travelProjectDto.AdultFee,
                                ChildFee = travelProjectDto.ChildFee,
                                SupplierID = supplier.SupplierID,
                                AgentAdultFee = travelProjectDto.AgentAdultFee,
                                AgentChildFee = travelProjectDto.AgentChildFee,
                                CoverPic = travelProjectDto.CoverPic,
                                Remark = travelProjectDto.Remark,
                                Description = travelProjectDto.Description,
                                ProjectTypeID = travelProjectDto.ProjectTypeID
                            };
                            db.T_TravelProjects.Add(travelProject);
                            needSave = true;
                        }

                    if (param.hotels != null)
                        for (var i = 0; i < param.hotels.Count; i++)
                        {
                            HotelDto hotelDto = param.hotels[i];
                            var hotel = new T_LiveProjects
                            {
                                HouseName = hotelDto.HouseName,
                                Fee = hotelDto.Fee,
                                SupplierID = supplier.SupplierID,
                                AgentFee = hotelDto.AgentFee,
                                CoverPic = hotelDto.CoverPic,
                                Description = hotelDto.Description,
                                Remark = hotelDto.Remark,
                                Pics = hotelDto.Pics,
                                Location = hotelDto.Location,
                                RoomCount = hotelDto.RoomCount
                            };
                            db.T_LiveProjects.Add(hotel);
                            needSave = true;
                        }

                    if (needSave)
                        db.SaveChanges();

                    result.Code = SystemConst.MSG_SUCCESS;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult Modify(Supplier param)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = SystemConst.MSG_ERR_UNKNOWN
            };

            using (var db = new TravelEntities())
            {
                T_Suppliers selectSupplier = db.T_Suppliers.FirstOrDefault(a => a.SupplierID == param.SupplierID);
                selectSupplier.SupplierName = param.SupplierName;
                selectSupplier.Contact = param.Contact;
                db.T_Suppliers.Attach(selectSupplier);
                db.Entry(selectSupplier).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult GetSupplierInfo(int supplierID)
        {
            SupplierResult result = new SupplierResult()
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };
            try
            {
                SupplierPara supplierInfo = new SupplierPara();
                using (var db = new TravelEntities())
                {
                    supplierInfo.travelProjects = (from travelProject in db.T_TravelProjects
                                                   join projectType in db.T_TravelProjectTypes on travelProject.ProjectTypeID equals projectType.ProjectTypeID into temp
                                                   from i in temp.DefaultIfEmpty()
                                                   where travelProject.SupplierID == supplierID
                                                   select new TravelProjectDto
                                                   {
                                                       ProjectID = travelProject.ProjectID,
                                                       ProjectName = travelProject.ProjectName,
                                                       AdultFee = travelProject.AdultFee,
                                                       ChildFee = travelProject.ChildFee,
                                                       AgentAdultFee = travelProject.AgentAdultFee,
                                                       AgentChildFee = travelProject.AgentChildFee,
                                                       ProjectTypeID = travelProject.ProjectTypeID,
                                                       ProjectTypeName = i.ProjectTypeName,
                                                       Remark = travelProject.Remark,
                                                       Description = travelProject.Description,
                                                       CoverPic = travelProject.CoverPic,
                                                       SupplierID = travelProject.SupplierID
                                                   }).ToList();
                    supplierInfo.hotels = (from hotel in db.T_LiveProjects.Where(a => a.SupplierID == supplierID)
                                           select new HotelDto
                                           {
                                               HouseID = hotel.HouseID,
                                               HouseName = hotel.HouseName,
                                               Fee = hotel.Fee,
                                               SupplierID = hotel.SupplierID,
                                               AgentFee = hotel.AgentFee,
                                               CoverPic = hotel.CoverPic,
                                               Description = hotel.Description,
                                               Remark = hotel.Remark,
                                               Pics = hotel.Pics,
                                               Location = hotel.Location,
                                               RoomCount = hotel.RoomCount
                                           }).ToList();
                }
                result.Code = SystemConst.MSG_SUCCESS;
                result.Data = supplierInfo;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Content(AppUtils.JsonSerializer(result));
        }
    }
}