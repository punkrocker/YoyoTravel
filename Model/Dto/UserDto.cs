using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class UserDto
    {
        [DisplayName("用户编号")]
        public int UserID
        {
            get; set;
        }

        [DisplayName("用户姓名")]
        public string UserName
        {
            get; set;
        }

        [DisplayName("登录名")]
        public string LoginName
        {
            get; set;
        }

        [DisplayName("密码")]
        public string Password
        {
            get; set;
        }

        [DisplayName("岗位编号")]
        public int RoleID
        { get; set; }

        [DisplayName("岗位名称")]
        public string RoleName
        { get; set; }

        [DisplayName("状态")]
        public string Status
        {
            get; set;
        }

        [DisplayName("当前可用")]
        public bool isEnable
        { get; set; }
    }
}
