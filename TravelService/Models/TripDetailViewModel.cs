using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class TripDetailViewModel
    {
        public int Seq
        {
            get; set;
        }
        
        public string Description
        {
            get; set;
        }

        public List<ServiceDetailViewModel> Services
        {
            get; set;
        }
    }
}