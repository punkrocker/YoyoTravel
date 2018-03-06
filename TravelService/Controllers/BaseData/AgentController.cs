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
    public class AgentController : Controller
    {
        public ActionResult GetAll()
        {
            var db = new TravelEntities();
            var agents = (from agent in db.T_Agents
                         join user in db.T_Users on agent.ParentID equals user.UserID into temp
                         from i in temp.DefaultIfEmpty()
                         select new AgentDto
                         {
                             AgentID = agent.AgentID,
                             AgentName = agent.AgentName,
                             LoginName = agent.LoginName,
                             Tel = agent.Tel,
                             ParentID = agent.ParentID,
                             ParentName = i.UserName,
                             Remark = agent.Remark,
                             Status = agent.Status,
                             isEnable = agent.Status.Equals(SystemConst.ENABLE),
                         }).ToList();
            return Content(AppUtils.JsonSerializer(agents));
        }

        [HttpPost]
        public ActionResult AddNewAgent(AgentDto agent)
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
                    if (db.T_Agents.Where(a => a.LoginName == agent.LoginName).ToList().Count > 0)
                    {
                        result.Message = "SAME_LOGIN_NAME";
                        return Content(AppUtils.JsonSerializer(result));
                    }
                    Guid guid = Guid.NewGuid();
                    string password = guid.ToString().Replace("-", "").Substring(0, 6);
                    T_Agents newAgent = new T_Agents
                    {
                        AgentName = agent.AgentName,
                        LoginName = agent.LoginName,
                        Tel = agent.Tel,
                        Remark = agent.Remark,
                        ParentID = agent.ParentID,
                        Password = AppUtils.SHA1Hash(password),
                        Status = SystemConst.ENABLE,
                    };
                    db.T_Agents.Add(newAgent);
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Message = password;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ModifyAgent(AgentDto agent)
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
                    T_Agents theAgent = db.T_Agents.FirstOrDefault(a => a.AgentID == agent.AgentID);
                    theAgent.AgentName = agent.AgentName;
                    theAgent.LoginName = agent.LoginName;
                    theAgent.ParentID = agent.ParentID;
                    theAgent.Status = agent.isEnable ? SystemConst.ENABLE : SystemConst.DISABLE;
                    theAgent.Tel = agent.Tel;
                    theAgent.Remark = agent.Remark;
                    db.T_Agents.Attach(theAgent);
                    db.Entry(theAgent).State = System.Data.Entity.EntityState.Modified;
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