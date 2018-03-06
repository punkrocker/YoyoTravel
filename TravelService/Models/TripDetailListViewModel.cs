using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class TripDetailListViewModel
    {
        public IList<TripDetailViewModel> tripDetails;
        public IList<BaseServiceModel> services;
    }
}