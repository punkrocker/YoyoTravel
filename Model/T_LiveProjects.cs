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
    
    public partial class T_LiveProjects
    {
              [System.ComponentModel.DataAnnotations.Key]
                [System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
        public int HouseID { get; set; }
        public string HouseName { get; set; }
        public Nullable<double> Fee { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string Description { get; set; }
        public string CoverPic { get; set; }
        public Nullable<double> AgentFee { get; set; }
        public string Pics { get; set; }
        public string Remark { get; set; }
        public string Location { get; set; }
        public Nullable<int> RoomCount { get; set; }
    }
}
