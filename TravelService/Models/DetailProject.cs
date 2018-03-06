using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class DetailProject
    {
        public string Start
        {
            get; set;
        }

        public string End
        {
            get; set;
        }

        public int TypeID
        {
            get; set;
        }

        public int ProjectID
        {
            get; set;
        }
    }
}