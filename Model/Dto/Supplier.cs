using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class Supplier
    {
        [DisplayName("供应商编号")]
        public int SupplierID
        {
            get; set;
        }
        [DisplayName("供应商名称")]
        public string SupplierName
        {
            get; set;
        }
        [DisplayName("联系方式")]
        public string Contact
        {
            get;set;
        }
        //[DisplayName("提供旅游项目服务")]
        //public bool HasService
        //{
        //    get;
        //    set;
        //}
        //[DisplayName("提供旅店服务")]
        //public bool HasHotel
        //{
        //    get; set;
        //}
    }
}
