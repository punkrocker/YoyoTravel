//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Drivers
    {
              [System.ComponentModel.DataAnnotations.Key]
                [System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public string Tel { get; set; }
        public Nullable<double> BigCarFee { get; set; }
        public Nullable<double> SmallCarFee { get; set; }
        public Nullable<double> BigCarPickAirportFee { get; set; }
        public Nullable<double> SmallCarPickAirportFee { get; set; }
        public Nullable<double> BigCarSendAirportFee { get; set; }
        public Nullable<double> SmallCarSendAirportFee { get; set; }
        public Nullable<double> AgentBigCarFee { get; set; }
        public Nullable<double> AgentSmallCarFee { get; set; }
        public Nullable<double> AgentBigCarPickAirportFee { get; set; }
        public Nullable<double> AgentSmallCarPickAirportFee { get; set; }
        public Nullable<double> AgentBigCarSendAirportFee { get; set; }
        public Nullable<double> AgentSmallCarSendAirportFee { get; set; }
        public string Remark { get; set; }
        public string Contact { get; set; }
        public Nullable<int> SupplierID { get; set; }
    }
}
