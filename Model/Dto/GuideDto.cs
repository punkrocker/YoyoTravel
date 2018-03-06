using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class GuideDto
    {
        [DisplayName("导游编号")]
        public int GuideID { get; set; }
        [DisplayName("导游姓名")]
        public string GuideName { get; set; }
        [DisplayName("联系电话")]
        public string Tel { get; set; }
        [DisplayName("其他联系方式")]
        public string Contact { get; set; }
        [DisplayName("不出海费用")]
        public Nullable<double> LandFee { get; set; }
        [DisplayName("不出海代理费用")]
        public Nullable<double> AgentLandFee { get; set; }
        [DisplayName("出海费用")]
        public Nullable<double> SeaFee { get; set; }
        [DisplayName("出海代理费用")]
        public Nullable<double> AgentSeaFee { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
