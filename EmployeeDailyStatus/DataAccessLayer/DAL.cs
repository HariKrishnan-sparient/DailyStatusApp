//using Microsoft.Practices.EnterpriseLibrary.Logging;
//using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
//using Microsoft.Practices.EnterpriseLibrary.Logging.Database;
//using Microsoft.Practices.ObjectBuilder;
using EmployeeDailyStatus.DataAcessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;

namespace DataAccessLayer
{
    public class DAL
    {
        private DatabaseHelper databaseHelper;

        #region Update_Status
        /// <summary>
        /// Insert new status entry
        /// </summary>
        //// <param name="Id"></param>
        /// <param name="CR"></param>
        /// <param name="Task"></param>
        /// <param name="StartDate"></param>
        /// <param name="ActualCompletionDate"></param>
        /// <param name="PlannedCompletionDate"></param>
        /// 
        /// <param name="Status"></param>
        /// <param name="HoursWorked"></param>
        /// 
        /// 
        /// 
        /// <returns></returns>
        public bool Update_Status(int Id,
                              string CR,
                              string Component,
                              DateTime StartDate,
                              DateTime PlannedCompletionDate,
                              string ActualCompletionDate, 
                              string CRStatus,
                              DataTable dtTask)


        {
            bool isAddSystemStatus = false;
            object[] tempSystemStatusParams = new object[] { Id, CR,Component, StartDate, PlannedCompletionDate, ActualCompletionDate ,CRStatus};
            databaseHelper = new DatabaseHelper();
            try
            {

                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.UPDATESTATUS,
                                                                   tempSystemStatusParams);

                int statusid = Id;
                Delete_Task(statusid);
                if (dtTask.Rows.Count > 0)
                {                
                    for (int i = 0; i < dtTask.Rows.Count; i++)
                    {
                        DataRow dr = dtTask.Rows[i];
                        Insert_Task(statusid, dr["Task"].ToString(), int.Parse(dr["HoursWorked"].ToString()), dr["Status"].ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return isAddSystemStatus;
        }
        #endregion

        #region
        public bool Update_LeaveDetails(int Id,
                              DateTime LeaveFrom,
                              DateTime LeaveTo,
                              int LeaveDays)
        {
            bool isAddSystemStatus = false;
            object[] tempSystemStatusParams = new object[] { Id,LeaveFrom,LeaveTo,LeaveDays };
            databaseHelper = new DatabaseHelper();
            try
            {

                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.UPDATELEAVEDETAILS,
                                                                   tempSystemStatusParams);
            }

            catch (Exception exception)
            {
                throw exception;
            }
            return isAddSystemStatus;
        }

        #endregion

        #region

        public void Insert_Task(int StatusId,string Task, int HoursWorked, string Status)
        {
            bool isAddSystemStatus = false;
            object[] temp = new object[] {StatusId, Task, HoursWorked, Status };
            databaseHelper = new DatabaseHelper();
            try
            {
                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.INSERTTASK, temp);
            }
            catch(SqlException sqlexception)
            {
                throw sqlexception;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //return isAddSystemStatus;
         }
        #endregion

        #region
        public bool Insert_LeaveDetails(string UserId,
                                         DateTime LeaveFrom, DateTime LeaveTo,int LeaveDays)
        {
            object[] tempSystemStatusParams = new object[] { UserId, LeaveFrom, LeaveTo,LeaveDays};
            databaseHelper = new DatabaseHelper();
            try
            {

                var id = databaseHelper.ExecuteScalar(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.INSERTLEAVEDETAILS,
                                                                   tempSystemStatusParams);
            }
            catch (Exception SqlException)
            {
                throw SqlException;
                return false;
            }
           
            return true;
        }
        #endregion
        #region

        public bool Insert_Status(string UserId,
                              string CR,
                              string Component,
                              DateTime StartDate,
                              DateTime PlannedCompletionDate,
                              string ActualCompletionDate,
                              string CRStatus,
                               DateTime StatusDate, DataTable dtTask)
        {
            
            object[] tempSystemStatusParams = new object[] { UserId, CR,Component, StartDate, PlannedCompletionDate, ActualCompletionDate,CRStatus,StatusDate };
            databaseHelper = new DatabaseHelper();
            try
            {

                var id = databaseHelper.ExecuteScalar(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.INSERTSTATUS,
                                                                   tempSystemStatusParams);
                int statusid = int.Parse(id.ToString());
                if (dtTask.Rows.Count > 0)
                {
                    //Delete_Task(statusid);
                    for (int i = 0; i < dtTask.Rows.Count; i++)
                    {
                        DataRow dr = dtTask.Rows[i];
                        Insert_Task(statusid, dr["Task"].ToString(), int.Parse(dr["HoursWorked"].ToString()), dr["Status"].ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
                return false;
            }
            catch (Exception exception)
            {
                throw exception;
                return false;
            }
            return true;
        }
        #endregion


        #region
        public bool Insert_StatusCR(string UserId,
                            string CR,
                            string Component,
                            DateTime StartDate,
                            DateTime PlannedCompletionDate,
                            string ActualCompletionDate,
                            string CRStatus,
                             DateTime StatusDate, DataTable dtTask)
        {

            object[] tempSystemStatusParams = new object[] { UserId, CR, Component, StartDate, PlannedCompletionDate, ActualCompletionDate, CRStatus, StatusDate };
            databaseHelper = new DatabaseHelper();
            try
            {

                var id = databaseHelper.ExecuteScalar(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.INSERTSTATUSCR,
                                                                   tempSystemStatusParams);
                int statusid = int.Parse(id.ToString());
                if (dtTask.Rows.Count > 0)
                {
                    //Delete_Task(statusid);
                    for (int i = 0; i < dtTask.Rows.Count; i++)
                    {
                        DataRow dr = dtTask.Rows[i];
                        Insert_Task(statusid, dr["Task"].ToString(), int.Parse(dr["HoursWorked"].ToString()), dr["Status"].ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
                return false;
            }
            catch (Exception exception)
            {
                throw exception;
                return false;
            }
            return true;
        }
        #endregion

        #region

        public DataSet Validate_Users(string UserId)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { UserId };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status,
                                                                  DataBaseConstants.VALIDATEUSERS,
                                                                  temp);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }


            return dtList;
        }
        #endregion
        #region
        public DataSet Select_LeaveDetails(string UserId)
        {
            DataSet dtList = new DataSet();
            object[] tempSystemStatusParams = new object[] { UserId };
            databaseHelper = new DatabaseHelper();
            try
            {

                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.SELECTLEAVEDETAILS,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion
        #region

        public DataSet Select_Status(string UserId, DateTime StatusDate)
        {
            DataSet dtList = new DataSet();
            object[] tempSystemStatusParams = new object[] { UserId, StatusDate };
            databaseHelper = new DatabaseHelper();
            try
            {

                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.SELECTSTATUS,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion


        #region

        public DataSet Select_InProgressStatus(string UserId, DateTime StatusDate)
        {
            DataSet dtList = new DataSet();
            object[] tempSystemStatusParams = new object[] { UserId, StatusDate };
            databaseHelper = new DatabaseHelper();
            try
            {

                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.SELECTINPROGRESSSTATUS,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion

        #region

        public DataSet Select_Task(int StatusId)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { StatusId };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.SELECTTASK, temp);
            }
            catch(SqlException sqlException)
            {
                throw sqlException;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dtList;
        }

        #endregion

        #region

        public DataSet getPossibleValues(string Attribute_Name)
        {
            DataSet dtList = new DataSet();
            object[] tempSystemStatusParams = new object[] {Attribute_Name };
            databaseHelper = new DatabaseHelper();
            try
            {

                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.GETPOSSIBLEVALUES,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }

        #endregion


        #region

        public DataSet Select_StatusByID(int Id)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { Id };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.SELECTSTATUSBYID, temp);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;

            }
            catch (Exception exception)
            {
                throw exception;

            }
            return dtList;

        }
        #endregion

        #region
        public DataSet Select_User(DateTime Statusdate)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { Statusdate };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.SELECTUSER, temp);
            }
            catch (SqlException sqlexception)
            {
                throw sqlexception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion

        #region
        public DataSet Select_LeaveDetailsForAllUsers(DateTime Statusdate)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { Statusdate };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.SELECTLEAVEDETAILSFORALLUSERS, temp);
            }
            catch (SqlException sqlexception)
            {
                throw sqlexception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion

        #region
        public DataSet Select_SparientHoliday(DateTime Statusdate)
        {
            DataSet dtList = new DataSet();
            object[] temp = new object[] { Statusdate };
            databaseHelper = new DatabaseHelper();
            try
            {
                dtList = databaseHelper.ExecuteDataSet(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.SELECTSPARIENTHOLIDAY, temp);
            }
            catch (SqlException sqlexception)
            {
                throw sqlexception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dtList;
        }
        #endregion


        #region

        public bool Delete_LeaveDetails(int Id)

        {
            bool isAddSystemStatus = false;
            object[] tempSystemStatusParams = new object[] { Id };
            databaseHelper = new DatabaseHelper();
            try
            {

                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.DELETELEAVEDETAILS,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return isAddSystemStatus;
        }

        #endregion

        #region
        public bool Delete_Status(int Id)

        {
            bool isAddSystemStatus = false;
            object[] tempSystemStatusParams = new object[] { Id };
            databaseHelper = new DatabaseHelper();
            try
            {

                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status,
                                                                   DataBaseConstants.DELETESTATUS,
                                                                   tempSystemStatusParams);
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return isAddSystemStatus;
        }


        #endregion

        #region

        public bool Delete_Task(int Id)
        {
            bool isAddSystemStatus = false;
            object[] temp = new object[] { Id };
            databaseHelper = new DatabaseHelper();
            try
            {
                isAddSystemStatus = databaseHelper.ExecuteNonQuery(DataBaseConstants.Employee_Daily_Status, DataBaseConstants.DELETETASK, temp);
            }
            catch(SqlException sqlexception)
            {
                throw sqlexception;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return isAddSystemStatus;
        }

        #endregion
    }
}

   

