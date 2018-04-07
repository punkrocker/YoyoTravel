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
    public class DriverController : Controller
    {
        public ActionResult GetAll(int? supplierID)
        {
            var db = new TravelEntities();
            List<DriverDto> drivers;
            if (supplierID != null)
                drivers = (from driver in db.T_Drivers
                           select new DriverDto
                           {
                               DriverID = driver.DriverID,
                               DriverName = driver.DriverName,
                               Tel = driver.Tel,
                               Contact = driver.Contact,
                               BigCarFee = driver.BigCarFee,
                               SmallCarFee = driver.SmallCarFee,
                               BigCarPickAirportFee = driver.BigCarPickAirportFee,
                               SmallCarPickAirportFee = driver.SmallCarPickAirportFee,
                               BigCarSendAirportFee = driver.BigCarSendAirportFee,
                               SmallCarSendAirportFee = driver.SmallCarSendAirportFee,
                               AgentBigCarFee = driver.AgentBigCarFee,
                               AgentSmallCarFee = driver.AgentSmallCarFee,
                               AgentBigCarPickAirportFee = driver.AgentBigCarPickAirportFee,
                               AgentSmallCarPickAirportFee = driver.AgentSmallCarPickAirportFee,
                               AgentBigCarSendAirportFee = driver.AgentBigCarSendAirportFee,
                               AgentSmallCarSendAirportFee = driver.AgentSmallCarSendAirportFee,
                               Remark = driver.Remark,
                               SupplierID = driver.SupplierID
                           }).Where(a => a.SupplierID == supplierID).ToList();
            else
                drivers = (from driver in db.T_Drivers
                           select new DriverDto
                           {
                               DriverID = driver.DriverID,
                               DriverName = driver.DriverName,
                               Tel = driver.Tel,
                               Contact = driver.Contact,
                               BigCarFee = driver.BigCarFee,
                               SmallCarFee = driver.SmallCarFee,
                               BigCarPickAirportFee = driver.BigCarPickAirportFee,
                               SmallCarPickAirportFee = driver.SmallCarPickAirportFee,
                               BigCarSendAirportFee = driver.BigCarSendAirportFee,
                               SmallCarSendAirportFee = driver.SmallCarSendAirportFee,
                               AgentBigCarFee = driver.AgentBigCarFee,
                               AgentSmallCarFee = driver.AgentSmallCarFee,
                               AgentBigCarPickAirportFee = driver.AgentBigCarPickAirportFee,
                               AgentSmallCarPickAirportFee = driver.AgentSmallCarPickAirportFee,
                               AgentBigCarSendAirportFee = driver.AgentBigCarSendAirportFee,
                               AgentSmallCarSendAirportFee = driver.AgentSmallCarSendAirportFee,
                               Remark = driver.Remark,
                               SupplierID = driver.SupplierID
                           }).ToList();
            return Content(AppUtils.JsonSerializer(drivers));
        }

        [HttpPost]
        public ActionResult AddNewDriver(DriverDto newDriver)
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
                    T_Drivers driver = new T_Drivers
                    {
                        DriverName = newDriver.DriverName,
                        Tel = newDriver.Tel,
                        Contact = newDriver.Contact,
                        BigCarFee = newDriver.BigCarFee,
                        SmallCarFee = newDriver.SmallCarFee,
                        BigCarPickAirportFee = newDriver.BigCarPickAirportFee,
                        SmallCarPickAirportFee = newDriver.SmallCarPickAirportFee,
                        BigCarSendAirportFee = newDriver.BigCarSendAirportFee,
                        SmallCarSendAirportFee = newDriver.SmallCarSendAirportFee,
                        AgentBigCarFee = newDriver.AgentBigCarFee,
                        AgentSmallCarFee = newDriver.AgentSmallCarFee,
                        AgentBigCarPickAirportFee = newDriver.AgentBigCarPickAirportFee,
                        AgentSmallCarPickAirportFee = newDriver.AgentSmallCarPickAirportFee,
                        AgentBigCarSendAirportFee = newDriver.AgentBigCarSendAirportFee,
                        AgentSmallCarSendAirportFee = newDriver.AgentSmallCarSendAirportFee,
                        Remark = newDriver.Remark,
                        SupplierID = newDriver.SupplierID
                    };
                    db.T_Drivers.Add(driver);
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
        public ActionResult ModifyDriver(DriverDto driver)
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
                    T_Drivers theDriver = db.T_Drivers.FirstOrDefault(a => a.DriverID == driver.DriverID);
                    theDriver.DriverName = driver.DriverName;
                    theDriver.Tel = driver.Tel;
                    theDriver.Contact = driver.Contact;
                    theDriver.BigCarFee = driver.BigCarFee;
                    theDriver.SmallCarFee = driver.SmallCarFee;
                    theDriver.BigCarPickAirportFee = driver.BigCarPickAirportFee;
                    theDriver.SmallCarPickAirportFee = driver.SmallCarPickAirportFee;
                    theDriver.BigCarSendAirportFee = driver.BigCarSendAirportFee;
                    theDriver.SmallCarSendAirportFee = driver.SmallCarSendAirportFee;
                    theDriver.AgentBigCarFee = driver.AgentBigCarFee;
                    theDriver.AgentSmallCarFee = driver.AgentSmallCarFee;
                    theDriver.AgentBigCarPickAirportFee = driver.AgentBigCarPickAirportFee;
                    theDriver.AgentSmallCarPickAirportFee = driver.AgentSmallCarPickAirportFee;
                    theDriver.AgentBigCarSendAirportFee = driver.AgentBigCarSendAirportFee;
                    theDriver.AgentSmallCarSendAirportFee = driver.AgentSmallCarSendAirportFee;
                    theDriver.Remark = driver.Remark;
                    theDriver.SupplierID = driver.SupplierID;
                    db.T_Drivers.Attach(theDriver);
                    db.Entry(theDriver).State = System.Data.Entity.EntityState.Modified;
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