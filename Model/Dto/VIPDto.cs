using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class VIPDto
    {
        [DisplayName("VIP服务编号")]
        public int ServerID { get; set; }
        [DisplayName("服务人员姓名")]
        public string ServerName { get; set; }
        [DisplayName("联系电话")]
        public string Tel { get; set; }
        [DisplayName("其他联系方式")]
        public string Contact { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }

        public int? SupplierID
        {
            get;set;
        }

        public override string ToString()
        {
            return ServerName;
        }
    }
}
