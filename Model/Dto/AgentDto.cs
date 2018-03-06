using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class AgentDto 
    {
        [DisplayName("代理编号")]
        public int AgentID { get; set; }
        [DisplayName("代理名称")]
        public string AgentName { get; set; }
        [DisplayName("登录名")]
        public string LoginName{ get; set; }
        [DisplayName("联系电话")]
        public string Tel { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("相关业务人编号")]
        public Nullable<int> ParentID { get; set; }
        [DisplayName("业务人员名称")]
        public string ParentName{ get; set; }
        [DisplayName("状态编号")]
        public string Status { get; set; }
        [DisplayName("当前状态")]
        public bool isEnable{ get; set; }
    }
}
