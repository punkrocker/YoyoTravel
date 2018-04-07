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
    public class VipController : Controller
    {
        // GET: Vip
        public ActionResult GetAll(int? supplierID)
        {
            var db = new TravelEntities();
            List<VIPDto> vipServices;
            if (supplierID != null)
                vipServices = vipServices = (from vip in db.T_VIPs
                                             select new VIPDto
                                             {
                                                 ServerID = vip.ServerID,
                                                 ServerName = vip.ServerName,
                                                 Contact = vip.Contact,
                                                 Tel = vip.Tel,
                                                 Remark = vip.Remark,
                                                 SupplierID = vip.SupplierID
                                             }).Where(a => a.SupplierID == supplierID).ToList();
            else
                vipServices = vipServices = (from vip in db.T_VIPs
                                             select new VIPDto
                                             {
                                                 ServerID = vip.ServerID,
                                                 ServerName = vip.ServerName,
                                                 Contact = vip.Contact,
                                                 Tel = vip.Tel,
                                                 Remark = vip.Remark,
                                                 SupplierID = vip.SupplierID
                                             }).ToList();
            return Content(AppUtils.JsonSerializer(vipServices));
        }

        [HttpPost]
        public ActionResult AddNewVipService(VIPDto vip)
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
                    T_VIPs newVip = new T_VIPs
                    {
                        ServerName = vip.ServerName,
                        Tel = vip.Tel,
                        SupplierID = vip.SupplierID,
                        Contact = vip.Contact,
                        Remark = vip.Remark
                    };
                    db.T_VIPs.Add(newVip);
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
        public ActionResult ModifyVipService(VIPDto vip)
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
                    T_VIPs theVIP = db.T_VIPs.FirstOrDefault(a => a.ServerID == vip.ServerID);
                    theVIP.ServerName = vip.ServerName;
                    theVIP.Contact = vip.Contact;
                    theVIP.Tel = vip.Tel;
                    theVIP.Remark = vip.Remark;
                    theVIP.SupplierID = vip.SupplierID;
                    db.T_VIPs.Attach(theVIP);
                    db.Entry(theVIP).State = System.Data.Entity.EntityState.Modified;
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