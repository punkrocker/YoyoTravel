using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class AllServiceViewModel
    {
        public IList<BaseServiceModel> AllServices
        {
            get; set;
        }

        public IList<T_TravelProjectTypes> AllTypes
        {
            get; set;
        }

        public int? TypeID
        {
            get;set;
        }
    }
}