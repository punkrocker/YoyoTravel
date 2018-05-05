using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class HotelDto
    {
        [DisplayName("别墅编号")]
        public int HouseID
        {
            get; set;
        }
        [DisplayName("别墅名称")]
        public string HouseName
        {
            get; set;
        }
        [DisplayName("每日单价")]
        public Nullable<double> Fee
        {
            get; set;
        }
        [DisplayName("供应商编号")]
        public Nullable<int> SupplierID
        {
            get; set;
        }
        [DisplayName("代理价格")]
        public Nullable<double> AgentFee
        {
            get;set;
        }
        [DisplayName("别墅说明")]
        public string Description { get; set; }
        [DisplayName("封面图片")]
        public string CoverPic { get; set; }
        [DisplayName("其他图片")]
        public string Pics { get; set; }
        [DisplayName("代理商说明")]
        public string Remark { get; set; }

        [DisplayName("别墅位置")]
        public string Location
        {
            get;set;
        }

        [DisplayName("房间数")]
        public int? RoomCount
        {
            get;set;
        }
    }
}
