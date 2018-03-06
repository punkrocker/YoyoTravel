﻿using Common;
using Model;
using Model.CallResult;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.BaseData
{
    public class PictureController : Controller
    {
        // GET: Picture
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPic(string fileName)
        {
            return Content("");
        }

        [HttpPost]
        public ActionResult Upload()
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_SUCCESS,
                Message = string.Empty
            };
            try
            {
                DateTime now = DateTime.Now;
                string vpath = SystemConst.PIC_PATH + now.ToString("yyyyMMdd") + "/";
                string realpath = Server.MapPath(vpath);
                if (!Directory.Exists(realpath))
                    Directory.CreateDirectory(realpath);
                string fileExt = Path.GetExtension(Request.Files[0].FileName);
                if (string.IsNullOrEmpty(fileExt) || !fileExt.StartsWith("."))
                    fileExt = ".png";
                string filename = Guid.NewGuid().ToString() + fileExt;
                Request.Files[0].SaveAs(realpath + filename);
                result.Message = now.ToString("yyyyMMdd") + "/" + filename;
            }
            catch 
            {
                result.Message = "ERR_SAVE_PIC";
            }
            return Content(AppUtils.JsonSerializer(result));
        }
    }
}