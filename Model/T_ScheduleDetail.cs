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
    
    public partial class T_ScheduleDetail
    {
              [System.ComponentModel.DataAnnotations.Key]
                [System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
        public int ScheduleID { get; set; }
              [System.ComponentModel.DataAnnotations.Key]
                [System.ComponentModel.DataAnnotations.Schema.Column(Order = 1)]
        public int Seq { get; set; }
        public string Description { get; set; }
        public string ProjectList { get; set; }
    }
}
