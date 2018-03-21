using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelService.Models;
using TravelService.Utils;

namespace TravelService.Services
{
    public class TripService
    {
        public static IList<TripViewModel> GetSchedule()
        {
            using (var db = new TravelEntities())
            {
                int userID = Convert.ToInt16(HttpContext.Current.Session["UserId"]);
                return (from schedule in db.T_Schedule.Where(a => a.AgentID == userID)
                        select new TripViewModel
                        {
                            ScheduleID = schedule.ScheduleID,
                            ScheduleName = schedule.ScheduleName,
                            Fee = schedule.Fee,
                            AgentID = schedule.AgentID,
                            Remark = schedule.Remark,
                            CustomerCount = schedule.CustomerCount,
                            CustomerName = schedule.CustomerName,
                            CustomRequire = schedule.CustomRequire,
                            VisitDate = schedule.VisitDate,
                            Status = schedule.Status.Equals(SystemConst.TRIP_STATUS_PUBLISHED) ? SystemConst.TRIP_STATUS_PUBLISHED_NAME : SystemConst.TRIP_STATUS_NEW_NAME
                        }).ToList();
            }
        }


        public static void AddTrip(string trip_name, int trip_price,
            string customer_name, int trip_days,
            string trip_date, string custom_require,
            string remark, int customer_count)
        {
            using (var db = new TravelEntities())
            {
                T_Schedule schedule = new T_Schedule
                {
                    ScheduleName = trip_name,
                    Fee = trip_price,
                    CustomerName = customer_name,
                    CustomRequire = custom_require,
                    CustomerCount = customer_count,
                    Days = trip_days,
                    VisitDate = (trip_date==null||trip_date.Equals(string.Empty))?DateTime.Today: Convert.ToDateTime(trip_date),
                    Remark = remark,
                    AgentID = Convert.ToInt16(HttpContext.Current.Session["UserId"]),
                    Status = SystemConst.TRIP_STATUS_NEW
                };
                db.T_Schedule.Add(schedule);
                db.SaveChanges();
                int tripID = schedule.ScheduleID;
                for (int i = 1; i <= trip_days; i++)
                {
                    AddEmptyDay(db, tripID, i);
                    db.SaveChanges();
                }
            }
        }

        internal static void EditDayDesc(int tripID, int seq, string desc)
        {
            using (var db = new TravelEntities())
            {
                T_ScheduleDetail detail = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID && a.Seq == seq).First();
                detail.Description = desc;
                detail.ProjectList = detail.ProjectList;
                db.T_ScheduleDetail.Attach(detail);
                db.Entry(detail).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal static void AddProject(int tripID, int seq, string start, string end, string projectID)
        {
            using (var db = new TravelEntities())
            {
                T_ScheduleDetail detail = db.T_ScheduleDetail.Where(a => a.ScheduleID==tripID && a.Seq == seq).First();
                if (detail == null)
                    return;
                string[] id_type = projectID.Split(':');
                DetailProject detailProject = new DetailProject
                {
                    Start = start,
                    End = end,
                    ProjectID = Convert.ToInt16(id_type[0]),
                    TypeID = Convert.ToInt16(id_type[1]),
                };
                List<DetailProject> detailProjects;
                if (detail.ProjectList == null || detail.ProjectList.Equals(string.Empty))
                    detailProjects = new List<DetailProject>();
                else
                    detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                detailProjects.Add(detailProject);
                detail.ProjectList = Common.AppUtils.JsonSerializer(detailProjects);
                detail.Description = detail.Description;
                db.T_ScheduleDetail.Attach(detail);
                db.Entry(detail).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal static void DeleteProject(int tripID, int seq, int projectSeq)
        {
            using (var db = new TravelEntities())
            {
                T_ScheduleDetail detail = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID && a.Seq == seq).First();
                if (detail == null)
                    return;
                List<DetailProject> detailProjects;
                if (detail.ProjectList == null || detail.ProjectList.Equals(string.Empty))
                    return;
                else
                    detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                if (detailProjects.Count < projectSeq)
                    return;
                detailProjects.RemoveAt(projectSeq);
                detail.ProjectList = Common.AppUtils.JsonSerializer(detailProjects);
                detail.Description = detail.Description;
                db.T_ScheduleDetail.Attach(detail);
                db.Entry(detail).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal static void DeleteDay(int tripID, int seq)
        {
            using (var db = new TravelEntities())
            {
                T_ScheduleDetail detail = new T_ScheduleDetail() { ScheduleID = tripID, Seq = seq };
                db.T_ScheduleDetail.Attach(detail);
                db.T_ScheduleDetail.Remove(detail);
                db.SaveChanges();
            }
        }

        public static void AddNewDay(int tripID)
        {
            using (var db = new TravelEntities())
            {
                var seq = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID).Select(q => q.Seq).DefaultIfEmpty();
                AddEmptyDay(db, tripID, seq.Max() + 1);
                db.SaveChanges();
            }
        }

        private static void AddEmptyDay(TravelEntities db, int tripID, int i)
        {
            T_ScheduleDetail detail = new T_ScheduleDetail();
            detail.ScheduleID = tripID;
            detail.Seq = i;
            detail.ProjectList = string.Empty;
            detail.Description = string.Empty;
            db.T_ScheduleDetail.Add(detail);
        }

        public static void AddNewDay(int tripID, string services, string desc)
        {
            if (services.Equals(string.Empty))
                return;
            using (var db = new TravelEntities())
            {
                var seq = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID).Select(q => q.Seq).DefaultIfEmpty();
                T_ScheduleDetail detail = new T_ScheduleDetail();
                detail.ScheduleID = tripID;
                detail.Seq = seq.Max() + 1;
                detail.ProjectList = services.Remove(services.Length - 1);
                detail.Description = desc;
                db.T_ScheduleDetail.Add(detail);
                db.SaveChanges();
            }
        }

        public static IList<TripDetailViewModel> GetScheduleDetail(int? tripID)
        {
            using (var db = new TravelEntities())
            {
                List<T_ScheduleDetail> details = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID).ToList();
                List<string> projectIDs = new List<string>();
                List<string> hotelIDs = new List<string>();
                foreach (T_ScheduleDetail detail in details)
                {
                    if (detail.ProjectList == null || Convert.ToString(detail.ProjectList).Equals(string.Empty))
                        continue;
                    List<DetailProject> detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                    foreach (DetailProject detailProject in detailProjects)
                    {
                        if (detailProject.TypeID == WebConst.HOTEL_TYPE)
                        {
                            if (!hotelIDs.Contains(detailProject.ProjectID.ToString()))
                            {
                                hotelIDs.Add(detailProject.ProjectID.ToString());
                            }
                        }
                        else
                        {
                            if (!projectIDs.Contains(detailProject.ProjectID.ToString()))
                            {
                                projectIDs.Add(detailProject.ProjectID.ToString());
                            }
                        }
                    }
                }
                //筛选所有在列表中的项目
                List<ServiceDetailViewModel> projectDetail = (from service in db.T_TravelProjects
                                                              where projectIDs.Contains(service.ProjectID.ToString())
                                                              select new ServiceDetailViewModel
                                                              {
                                                                  ServiceID = service.ProjectID,
                                                                  ServiceName = service.ProjectName,
                                                                  ProjectTypeName = service.ProjectTypeID.ToString()
                                                              }).ToList();
                List<ServiceDetailViewModel> hotelDetail = (from hotel in db.T_LiveProjects
                                                            where hotelIDs.Contains(hotel.HouseID.ToString())
                                                            select new ServiceDetailViewModel
                                                            {
                                                                ServiceID = hotel.HouseID,
                                                                ServiceName = hotel.HouseName,
                                                                ProjectTypeName = WebConst.HOTEL_TYPE.ToString() 
                                                            }).ToList();
                List<ServiceDetailViewModel> serviceDetail = new List<ServiceDetailViewModel>();
                serviceDetail.AddRange(projectDetail);
                serviceDetail.AddRange(hotelDetail);
                //组织一个列表seq、desc、List<Project>
                List<TripDetailViewModel> tripDetails = new List<TripDetailViewModel>();
                foreach (T_ScheduleDetail detail in details)
                {
                    TripDetailViewModel tripDetail = new TripDetailViewModel
                    {
                        Seq = detail.Seq,
                        Description = detail.Description
                    };
                    if (detail.ProjectList!=null && !detail.ProjectList.Equals(string.Empty))
                    {
                        List<DetailProject> detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                        List<ServiceDetailViewModel> services = new List<ServiceDetailViewModel>();
                        foreach (DetailProject detailProject in detailProjects)
                        {
                            ServiceDetailViewModel service = serviceDetail.Where(a => a.ServiceID == detailProject.ProjectID).FirstOrDefault();
                            ServiceDetailViewModel display_service = new ServiceDetailViewModel
                            {
                                Start = detailProject.Start,
                                End = detailProject.End,
                                ServiceName = service.ServiceName,
                                ProjectTypeName = service.ProjectTypeName
                            };
                            services.Add(display_service);
                        }
                        tripDetail.Services = services;
                    }
                    else
                    {
                        tripDetail.Services = new List<ServiceDetailViewModel>();
                    }
                    tripDetails.Add(tripDetail);
                }

                return tripDetails;
            }
        }

        public static TripViewModel GetShareSchedule(int? tripID)
        {
            using (var db = new TravelEntities())
            {
                TripViewModel trip = new TripViewModel();
                T_Schedule schedule = db.T_Schedule.Where(a => a.ScheduleID == tripID).FirstOrDefault();
                trip.CustomerName = schedule.CustomerName;
                trip.VisitDate = schedule.VisitDate;
                trip.ScheduleName = schedule.ScheduleName;
                trip.CustomRequire = schedule.CustomRequire;
                trip.Fee = schedule.Fee;
                trip.CustomerCount = schedule.CustomerCount;
                trip.Remark = schedule.Remark;

                List<T_ScheduleDetail> details = db.T_ScheduleDetail.Where(a => a.ScheduleID == tripID).ToList();
                List<int> projectIDs = new List<int>();
                List<int> hotelIDs = new List<int>();
                foreach (T_ScheduleDetail detail in details)
                {
                    if (detail.ProjectList == null || detail.ProjectList.Equals(string.Empty))
                        continue;
                    List<DetailProject> detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                    foreach (DetailProject detailProject in detailProjects)
                    {
                        if (detailProject.TypeID == WebConst.HOTEL_TYPE)
                        {
                            if (!hotelIDs.Contains(detailProject.ProjectID))
                            {
                                hotelIDs.Add(detailProject.ProjectID);
                            }
                        }
                        else
                        {
                            if (!projectIDs.Contains(detailProject.ProjectID))
                            {
                                projectIDs.Add(detailProject.ProjectID);
                            }
                        }
                    }
                }
                //筛选所有在列表中的项目
                List<ServiceDetailViewModel> projectDetail = (from service in db.T_TravelProjects
                                                              where projectIDs.Contains(service.ProjectID)
                                                              select new ServiceDetailViewModel
                                                              {
                                                                  ServiceID = service.ProjectID,
                                                                  ServiceName = service.ProjectName,
                                                                  CoverPic = service.CoverPic,
                                                                  Description = service.Description,
                                                              }).ToList();
                List<ServiceDetailViewModel> hotelDetail = (from hotel in db.T_LiveProjects
                                                              where hotelIDs.Contains(hotel.HouseID)
                                                              select new ServiceDetailViewModel
                                                              {
                                                                  ServiceID = hotel.HouseID,
                                                                  ServiceName = hotel.HouseName,
                                                                  CoverPic = hotel.CoverPic,
                                                                  Description = hotel.Description,
                                                                  Pics = hotel.Pics,
                                                              }).ToList();
                List<ServiceDetailViewModel> serviceDetail = new List<ServiceDetailViewModel>();
                serviceDetail.AddRange(projectDetail);
                serviceDetail.AddRange(hotelDetail);
                //组织一个列表seq、desc、List<Project>
                List<TripDetailViewModel> tripDetails = new List<TripDetailViewModel>();
                foreach (T_ScheduleDetail detail in details)
                {
                    TripDetailViewModel tripDetail = new TripDetailViewModel
                    {
                        Seq = detail.Seq,
                        Description = detail.Description
                    };
                    if (detail.ProjectList != null && !detail.ProjectList.Equals(string.Empty))
                    {
                        List<DetailProject> detailProjects = Common.AppUtils.JsonDeserialize<List<DetailProject>>(detail.ProjectList);
                        List<ServiceDetailViewModel> dayServices = new List<ServiceDetailViewModel>();
                        foreach (DetailProject detailProject in detailProjects)
                        {
                            ServiceDetailViewModel service = serviceDetail.Where(a => a.ServiceID == detailProject.ProjectID).FirstOrDefault();
                            ServiceDetailViewModel display_service = new ServiceDetailViewModel
                            {
                                Start = detailProject.Start,
                                End = detailProject.End,
                                ServiceName = service.ServiceName,
                                Description = service.Description,
                                CoverPic = service.CoverPic,
                                Pics = service.Pics
                            };
                            dayServices.Add(display_service);
                        }
                        tripDetail.Services = dayServices;
                    }
                    else
                    {
                        tripDetail.Services = new List<ServiceDetailViewModel>();
                    }
                    tripDetails.Add(tripDetail);
                }

                trip.ScheduleDetail = tripDetails;
                return trip;
            }
        }
    }
}