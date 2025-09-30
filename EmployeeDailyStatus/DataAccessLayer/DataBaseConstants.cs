using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DataBaseConstants
    {

        #region Employee Daily Status Database name
        public static string Employee_Daily_Status = ConfigurationManager.AppSettings["DATABASE_NAME"].ToString();
       // public static string task= ConfigurationManager.AppSettings["Task"].ToString();
        #endregion

        #region Stored Procedure Employee Daily Status

        public const string UPDATESTATUS = "sp_UpdateStatus";
        public const string DELETESTATUS = "sp_DeleteStatus";
        public const string INSERTSTATUS = "sp_InsertStatus";
        public const string SELECTSTATUS = "sp_SelectStatus";
        public const string SELECTSTATUSBYID = "sp_SelectStatusByID";
        public const string SELECTUSER = "sp_SelectStatusforAllUser";
        public const string VALIDATEUSERS = "sp_ValidateUsers";
        public const string GETPOSSIBLEVALUES = "sp_getPossibleValues";
        public const string INSERTTASK = "sp_InsertTask";
        public const string SELECTTASK = "sp_SelectTask";
        public const string DELETETASK = "sp_DeleteTask";
        public const string SELECTINPROGRESSSTATUS = "sp_SelectInProgressStatus";
        public const string INSERTSTATUSCR = "sp_InsertStatusCR";
        public const string INSERTLEAVEDETAILS = "sp_InsertLeaveDetails";
        public const string UPDATELEAVEDETAILS = "sp_UpdateLeaveDetails";
        public const string SELECTLEAVEDETAILS = "sp_SelectLeaveDetails";
        public const string DELETELEAVEDETAILS = "sp_DeleteLeaveDetails";
        public const string SELECTLEAVEDETAILSFORALLUSERS = "sp_SelectLeaveDetailsForAllUsers";
        public const string SELECTSPARIENTHOLIDAY = "sp_SelectSparientHoliday";
        #endregion

    }
}
