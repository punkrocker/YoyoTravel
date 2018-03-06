using Common;
using Model;
using Model.CallResult;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelService.Controllers.User
{
    public class UserController : Controller
    {
        private string SYS_ADMIN_NAME = "admin";
        private string SYS_PASSWORD = "123123";

        // GET: User
        public ActionResult Index()
        {
            var db = new TravelEntities();
            return Content(AppUtils.JsonSerializer(db.T_Users.ToList()));
        }

        [HttpPost]
        public ActionResult Login(LoginPara para)
        {
            LoginResult result = new LoginResult()
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };

            using (var db = new TravelEntities())
            {
                var users = db.T_Users.Count();
                if (users==0 && para.Username.Equals(SYS_ADMIN_NAME) && para.Password.Equals(AppUtils.SHA1Hash(SYS_PASSWORD)))
                {
                    result.Code = SystemConst.MSG_SUCCESS;
                    LoginDto loginResult = new LoginDto
                    {
                        UserID = SystemConst.SYS_ADMIN,
                        UserName = String.Empty,
                        Functions = new List<string>(),
                    };
                    result.Data = loginResult;
                    return Content(AppUtils.JsonSerializer(result));
                }

                var user =
                    db.T_Users.Where(a => a.LoginName == para.Username && a.Status.Equals(SystemConst.ENABLE))
                        .FirstOrDefault();
                if (user != null && para.Password.Equals(user.Password))
                {
                    var fx = (from roleFunction in db.T_RoleFunction
                              join function in db.T_Functions on roleFunction.FunctionID equals function.ID
                              where roleFunction.RoleID == user.RoleID
                              select function).ToList();

                    List<String> selectfunction = new List<string>();
                    foreach (var function in fx)
                    {
                        selectfunction.Add(function.Code.ToString());
                    }

                    LoginDto loginResult = new LoginDto
                    {
                        UserID = user.UserID,
                        UserName = user.UserName,
                        Functions = selectfunction,
                    };
                    result.Data = loginResult;
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                else
                {
                    result.Message = "ERROR_PASSWORD";
                }
            }
            return Content(AppUtils.JsonSerializer(result));
        }

        [HttpPost]
        public ActionResult AddNewUser(UserDto newUser)
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
                    if (db.T_Users.Where(a => a.LoginName == newUser.LoginName).ToList().Count > 0)
                    {
                        result.Message = "SAME_LOGIN_NAME";
                        return Content(AppUtils.JsonSerializer(result));
                    }
                    Guid guid = Guid.NewGuid();
                    string password = guid.ToString().Replace("-", "").Substring(0, 6);
                    T_Users user = new T_Users
                    {
                        UserName = newUser.UserName,
                        LoginName = newUser.LoginName,
                        Password = AppUtils.SHA1Hash(password),
                        Status = SystemConst.ENABLE,
                        RoleID = newUser.RoleID
                    };
                    db.T_Users.Add(user);
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
        public ActionResult ModifyUser(UserDto user)
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
                    T_Users theUser = db.T_Users.FirstOrDefault(a => a.UserID == user.UserID);
                    theUser.UserName = user.UserName;
                    theUser.LoginName = user.LoginName;
                    theUser.RoleID = user.RoleID;
                    theUser.Status = user.isEnable ? SystemConst.ENABLE : SystemConst.DISABLE;
                    db.T_Users.Attach(theUser);
                    db.Entry(theUser).State = System.Data.Entity.EntityState.Modified;
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

        public ActionResult GetAllRoles()
        {
            RolesResult result = new RolesResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new TravelEntities())
            {
                try
                {
                    List<T_Roles> roles = db.T_Roles.ToList();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Data = roles;
                }
                catch (Exception ex)
                {
                    result.Message = ex.Message;
                }
            }
            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult GetAllUsers()
        {
            var db = new TravelEntities();
            var users = (from user in db.T_Users
                             join role in db.T_Roles on user.RoleID equals role.RoleID into temp
                             from i in temp.DefaultIfEmpty()
                             select new UserDto
                             {
                                 UserID = user.UserID,
                                 UserName = user.UserName,
                                 LoginName = user.LoginName,
                                 Password = string.Empty,
                                 RoleID = user.RoleID,
                                 RoleName = i.RoleName,
                                 Status = user.Status,
                                 isEnable = user.Status.Equals(SystemConst.ENABLE),
                             }).ToList();

            return Content(AppUtils.JsonSerializer(users));
        }
    }
}