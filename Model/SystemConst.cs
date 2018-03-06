using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SystemConst
    {
        public static int BASE_YEAR = 2015;
        public static int BASE_MONTH = 8;
        public static int BASE_DAY = 1;

        public static string MSG_SUCCESS = "S000";
        public static string MSG_ERR_UNKNOWN = "E000";

        public static string LOG_DELETE = "DELETE";

        public static string ENABLE = "0";
        public static string DISABLE = "1";
        public static string FALSE = "0";
        public static string TRUE = "1";

        public static int SYS_ADMIN = -1;

        public static string PIC_PATH = "/Site/Pics/";

        public static string TRIP_STATUS_NEW = "0";
        public static string TRIP_STATUS_PUBLISHED = "1";
        public static string TRIP_STATUS_NEW_NAME = "新建";
        public static string TRIP_STATUS_PUBLISHED_NAME = "已发布";
    }
}
