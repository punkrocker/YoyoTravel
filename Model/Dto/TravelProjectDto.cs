using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model.Dto
{
    public class TravelProjectDto
    {
        [DisplayName("项目编号")]
        public int ProjectID
        {
            get; set;
        }
        [DisplayName("项目名称")]
        public string ProjectName
        {
            get; set;
        }
        [DisplayName("成人收费")]
        public Nullable<double> AdultFee
        {
            get; set;
        }
        [DisplayName("儿童收费")]
        public Nullable<double> ChildFee
        {
            get; set;
        }
        [DisplayName("供应商编号")]
        public Nullable<int> SupplierID
        {
            get; set;
        }
        [DisplayName("类型编号")]
        public Nullable<int> ProjectTypeID { get; set; }
        [DisplayName("类型名称")]
        public string ProjectTypeName{ get; set; }
        [DisplayName("代理成人收费")]
        public Nullable<double> AgentAdultFee { get; set; }
        [DisplayName("代理儿童收费")]
        public Nullable<double> AgentChildFee { get; set; }
        [DisplayName("封面图片路径")]
        public string CoverPic { get; set; }
        [DisplayName("详细说明")]
        public string Description { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
