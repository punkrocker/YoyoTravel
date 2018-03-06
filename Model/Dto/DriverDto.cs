using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class DriverDto
    {
        [DisplayName("司机编号")]
        public int DriverID { get; set; }
        [DisplayName("司机姓名")]
        public string DriverName { get; set; }
        [DisplayName("电话")]
        public string Tel { get; set; }
        [DisplayName("其他联系方式")]
        public string Contact { get; set; }
        [DisplayName("大车包车")]
        public Nullable<double> BigCarFee { get; set; }
        [DisplayName("小车包车")]
        public Nullable<double> SmallCarFee { get; set; }
        [DisplayName("大车接机")]
        public Nullable<double> BigCarPickAirportFee { get; set; }
        [DisplayName("小车接机")]
        public Nullable<double> SmallCarPickAirportFee { get; set; }
        [DisplayName("大车送机")]
        public Nullable<double> BigCarSendAirportFee { get; set; }
        [DisplayName("小车送机")]
        public Nullable<double> SmallCarSendAirportFee { get; set; }
        [DisplayName("代理大车包车")]
        public Nullable<double> AgentBigCarFee { get; set; }
        [DisplayName("代理小车包车")]
        public Nullable<double> AgentSmallCarFee { get; set; }
        [DisplayName("代理大车接机")]
        public Nullable<double> AgentBigCarPickAirportFee { get; set; }
        [DisplayName("代理小车接机")]
        public Nullable<double> AgentSmallCarPickAirportFee { get; set; }
        [DisplayName("代理大车送机")]
        public Nullable<double> AgentBigCarSendAirportFee { get; set; }
        [DisplayName("代理小车送机")]
        public Nullable<double> AgentSmallCarSendAirportFee { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
