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
    
    public partial class T_Suppliers
    {
              [System.ComponentModel.DataAnnotations.Key]
                [System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> SupplierType { get; set; }
        public string Contact { get; set; }
        public string HasHotel { get; set; }
        public string HasService { get; set; }
    }
}
