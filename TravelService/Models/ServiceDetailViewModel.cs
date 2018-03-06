using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelService.Models
{
    public class ServiceDetailViewModel
    {
        public int ServiceID
        {
            get; set;
        }

        public string ServiceName
        {
            get; set;
        }

        public string SupplierName
        {
            get; set;
        }

        public Nullable<double> AgentAdultFee
        {
            get; set;
        }

        public Nullable<double> AgentChildFee
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public string CoverPic
        {
            get; set;
        }

        public string Pics
        {
            get; set;
        }

        public string Remark
        {
            get; set;
        }

        public string ProjectTypeName
        {
            get; set;
        }

        public string Start
        {
            get;set;
        }

        public string End
        {
            get; set;
        }
    }
}