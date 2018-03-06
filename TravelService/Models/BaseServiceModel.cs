using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class BaseServiceModel
    {
        public int ID
        {
            get;set;
        }

        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int? Type
        {
            get; set;
        }

        public string TypeName
        {
            get; set;
        }
    }
}