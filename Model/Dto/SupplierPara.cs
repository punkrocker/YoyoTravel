using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class SupplierPara
    {
        public Supplier supplier
        {
            get; set;
        }
        public List<TravelProjectDto> travelProjects
        {
            get; set;
        }
        public List<HotelDto> hotels
        {
            get; set;
        }
    }
}
