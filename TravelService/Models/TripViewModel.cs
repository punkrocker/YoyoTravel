using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class TripViewModel: T_Schedule
    {
        public IList<TripDetailViewModel> ScheduleDetail
        {
            get;set;
        }
    }
}