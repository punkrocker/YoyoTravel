using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace Travel.Client.Utils
{
    public class WebCall
    {
        //public static string BaseUrl = "http://localhost:56090/";
        public static string BaseUrl = "http://localhost:8730/";

        public static string GetAllSupplier = "supplier/Get";
        public static string AddSupplier = "supplier/Add";
        public static string ModifySupplier = "supplier/Modify";
        public static string GetSupplierDetail = "supplier/GetSupplierInfo";
        public static string AddHotel = "hotel/Add";
        public static string ModifyHotel = "hotel/Modify";
        public static string AddTravelService = "travelService/Add";
        public static string ModifyTravelService = "travelService/Modify";
        public static string GetTravelProjectTypes = "travelService/GetAllProjectTypes";

        public static string Login = "User/Login";
        public static string GetRoles = "User/GetAllRoles";
        public static string AddUser = "User/AddNewUser";
        public static string ModifyUser = "User/ModifyUser";
        public static string GetUsers = "User/GetAllUsers";

        public static string GetAgents = "Agent/GetAll";
        public static string AddAgent = "Agent/AddNewAgent";
        public static string ModifyAgent = "Agent/ModifyAgent";

        public static string GetVips = "VIP/GetAll";
        public static string AddVips = "VIP/AddNewVipService";
        public static string ModifyVips = "VIP/ModifyVipService";

        public static string GetGuides = "Guide/GetAll";
        public static string AddGuides = "Guide/AddNewGuide";
        public static string ModifyGuides = "Guide/ModifyGuide";

        public static string GetDrivers = "Driver/GetAll";
        public static string AddDrivers = "Driver/AddNewDriver";
        public static string ModifyDrivers = "Driver/ModifyDriver";

        public static T GetMethod<T>(string methodName, List<KeyValuePair<string, string>> paramlist)
        {
            var param = new StringBuilder();
            if (null != paramlist)
            {
                for (var index = 0; index < paramlist.Count; index++)
                {
                    if (index == 0)
                    {
                        param.Append("?");
                    }
                    else
                    {
                        param.Append("&");
                    }
                    param.Append(paramlist[index].Key);
                    param.Append("=");
                    param.Append(paramlist[index].Value);
                }
            }
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri(
                    BaseUrl + methodName + param,
                    UriKind.Absolute))
                    .Result.Content.ReadAsStringAsync()
                    .Result;
                var resultInfo = AppUtils.JsonDeserialize<T>(result);
                return resultInfo;
            }
        }

        public static string PostMethod<T>(string methodName, T param)
        {
            var requestJson = AppUtils.JsonSerializer(param);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                HttpContent httpContent =
                    new StringContent(requestJson);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result =
                    client.PostAsync(methodName, httpContent).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
        }

        public static string UploadFile(string fileName)
        {
            WebClient myWebClient = new WebClient();
            byte[] buffer = myWebClient.UploadFile(WebCall.BaseUrl + "Picture/Upload", "POST", fileName);
            var msg = Encoding.UTF8.GetString(buffer);
            return msg;
        }

        public static Stream GetPic(string url)
        {
            Stream mStream;
            try
            {
                Uri mUri = new Uri(WebCall.BaseUrl + SystemConst.PIC_PATH + url);
                HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUri);
                mRequest.Method = "GET";
                mRequest.Timeout = 200;
                mRequest.ContentType = "text/html;charset=utf-8";
                HttpWebResponse mResponse = (HttpWebResponse)mRequest.GetResponse();
                mStream = mResponse.GetResponseStream();
            }
            catch
            {
                return null;
            }
            return mStream;
        }

        public static void LoadUrl()
        {
            using (var client = new HttpClient())
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ip = config.AppSettings.Settings["url"].Value;
                try
                {
                    var result = client.GetAsync(new Uri(
                        "http://www.thaiyuda.com:114/ip/get",
                        UriKind.Absolute))
                        .Result.Content.ReadAsStringAsync()
                        .Result;
                    ip = result;
                    config.AppSettings.Settings["url"].Value = ip;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                catch (Exception e)
                {

                }
                BaseUrl = string.Format("http://{0}:8730/", ip);
            }
            //BaseUrl = "http://localhost:8730/";
        }
    }

    internal class IP
    {
        public string IPAddr
        {
            get;
            set;
        }
    }
}