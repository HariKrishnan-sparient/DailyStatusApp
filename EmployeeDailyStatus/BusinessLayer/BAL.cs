using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
using System.Configuration;
using System.IO;
using System.Xml;
using EmployeeDailyStatus;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using DataAccessLayer;
using System.Security.Cryptography.X509Certificates;

namespace BusinessLayer
{
    public class BAL
    {
        DAL dalobj = new DAL();
        
        public bool UpdateLeaveDetails(int Id,DateTime LeaveFrom,DateTime LeaveTo,int LeaveDays)
        {
            try
            {
                bool result = dalobj.Update_LeaveDetails(Id, LeaveFrom, LeaveTo, LeaveDays);
                return result;

            }
            catch { return false; }
        }

        public bool UpdateStatus(int Id, string CR,string Component,
                              DateTime StartDate,
                              DateTime PlannedCompletionDate,
                              string ActualCompletionDate,
                              string CRStatus,
                              DataTable dtTask)


        {
            try
            {
                bool result = dalobj.Update_Status(Id,
                                      CR,
                                      Component,
                                      StartDate,
                                      PlannedCompletionDate,
                                      ActualCompletionDate,
                                      CRStatus,
                                      dtTask);


                return result;
            }
            catch { return false; }
        }

        public bool InsertStatus(string UserId,
                              string CR,
                              string Component,
                              DateTime StartDate,
                              DateTime PlannedCompletionDate,
                              string ActualCompletionDate,
                              string CRStatus,
                              DateTime StatusDate,
                              DataTable dtTask)
        {
            try
            {
                bool result = dalobj.Insert_Status(UserId,
                                      CR,
                                      Component,
                                      StartDate,
                                      PlannedCompletionDate,
                                      ActualCompletionDate,
                                      CRStatus,
                                      StatusDate, dtTask);
                return result;
            }
            catch { return false; }
        }

        public bool InsertLeaveDetails(string UserId,
                              DateTime LeaveFrom,
                              DateTime LeaveTo,
                              int LeaveDays
                             )
                             

                                                 
        { 
            try
            {
                bool result = dalobj.Insert_LeaveDetails(UserId,
                                      LeaveFrom,
                                      LeaveTo,
                                      LeaveDays);
                                      
                                      
                return result;
            }
            catch { return false; }
        }


        public bool InsertStatusCR(string UserId,
                              string CR,
                              string Component,
                              DateTime StartDate,
                              DateTime PlannedCompletionDate,
                              string ActualCompletionDate,
                              string CRStatus,
                              DateTime StatusDate,
                              DataTable dtTask)
        {
            try
            {
                bool result = dalobj.Insert_StatusCR(UserId,
                                      CR,
                                      Component,
                                      StartDate,
                                      PlannedCompletionDate,
                                      ActualCompletionDate,
                                      CRStatus,
                                      StatusDate, dtTask);
                return result;
            }
            catch { return false; }
        }
        public bool DeleteStatus(int Id)
        {
            try
            {
                bool result = dalobj.Delete_Status(Id);
                return result;
            }
            catch { return false; }
        }

        public bool DeleteLeaveDetails(int Id)
        {
            try
            {
                bool result = dalobj.Delete_LeaveDetails(Id);
                return result;
            }
            catch { return false; }
        }
        public DataTable SelectTask(int Id)
        {
           
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_Task(Id);
                return dtList.Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public DataTable SelectLeaveDetails(string UserId)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_LeaveDetails(UserId);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SelectStatus(string UserId, DateTime StatusDate)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_Status(UserId, StatusDate);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet SelectInProgressStatus(string UserId, DateTime StatusDate)
        {
            DataSet dsList;
            try
            {
                dsList = dalobj.Select_InProgressStatus(UserId, StatusDate);
                return dsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getPossibleValues(string Attribute_Name)
        {
            DataSet dtlist;
            try
            {
                dtlist = dalobj.getPossibleValues(Attribute_Name);
                return dtlist.Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectStatusById(int Id)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_StatusByID(Id);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable SelectUser( DateTime Statusdate)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_User(Statusdate);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectLeaveDetailsForAllUsers(DateTime Statusdate)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_LeaveDetailsForAllUsers(Statusdate);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable SelectSparientHoliday(DateTime Statusdate)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Select_SparientHoliday(Statusdate);
                return dtList.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ValidateUsers(string UserId)
        {
            DataSet dtList;
            try
            {
                dtList = dalobj.Validate_Users(UserId);
                return dtList.Tables[0];
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
    

    
