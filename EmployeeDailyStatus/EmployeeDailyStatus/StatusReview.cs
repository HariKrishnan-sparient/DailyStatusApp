using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Http;
using System.Security.Policy;
using Microsoft.Exchange.WebServices.Data;
using System.Windows.Forms.VisualStyles;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace EmployeeDailyStatus
{
    public partial class StatusReview : Form
    {
        private static object htmlString;
        public string _EmailID = string.Empty;

        public StatusReview(string emailID)
        {
            _EmailID = emailID;
            InitializeComponent();
            Loadgrid();
        }

        private void Loadgrid()
        {
            BAL balobj = new BAL();
            DateTime dtStatus = dtDate.Value;
            DataTable dt = balobj.SelectUser(dtStatus);
            dgvReview.DataSource = dt;
            dgvReview.AutoGenerateColumns = false;
            dgvReview.Refresh();
            dgvLeavePlan.Visible = false;
            label1.Visible = false;
            dgvSparientHoliday.Visible = false;
            label2.Visible = false;
            DataTable dt1 = balobj.SelectLeaveDetailsForAllUsers(dtStatus);
            dgvLeavePlan.AutoGenerateColumns = false;
            dgvLeavePlan.DataSource = dt1;
            dgvLeavePlan.Refresh();
            if (dt1.Rows.Count > 0)
            {
                dgvLeavePlan.Visible = true;
                label1.Visible = true;
            }

            DataTable dt2 = balobj.SelectSparientHoliday(dtStatus);
            dgvSparientHoliday.AutoGenerateColumns = false;
            dgvSparientHoliday.DataSource = dt2;
            dgvSparientHoliday.Refresh();


            if (dt2.Rows.Count > 0)
            {
                dgvSparientHoliday.Visible = true;
                label2.Visible = true;
            }


            else
            {

                dgvSparientHoliday.Visible = false;
                label2.Visible = false;
            }



        }

        bool IsTheSameCellValue(int column, int row)
        {
            if (column == 0) // Owner
            {
                DataGridViewCell cell1 = dgvReview[column, row];
                DataGridViewCell cell2 = dgvReview[column, row - 1];
                if (cell1.Value == null || cell2.Value == null)
                {
                    return false;
                }
                return cell1.Value.ToString() == cell2.Value.ToString();
            }
            else
            //if (column == 1 || column == 2) // CR, Component
            {
                DataGridViewCell cell1 = dgvReview[column, row];
                DataGridViewCell cell2 = dgvReview[column, row - 1];
                DataGridViewCell cell1_1 = dgvReview[0, row];
                DataGridViewCell cell2_1 = dgvReview[0, row - 1];
                if (cell1.Value == null || cell2.Value == null)
                {
                    return false;
                }
                return (cell1.Value.ToString() == cell2.Value.ToString() && cell1_1.Value.ToString() == cell2_1.Value.ToString());
            }
            //return false;
        }

        private void dgvReview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = dgvReview.AdvancedCellBorderStyle.Top;
                }
            }
        }



        private void dgvReview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (e.Value.ToString() == "LEAVE")
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.Padding = new Padding(5);
            }
            if (e.RowIndex == 0)
                return;
            if ((e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5) && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
                e.CellStyle.Padding = new Padding(Padding.Bottom);
            }
        }


        private void StatusReview_Load(object sender, EventArgs e)
        {
            dgvReview.AutoGenerateColumns = false;

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            string htmlString = gethtml(dgvReview, currentDate)+getleave(dgvLeavePlan,currentDate)+getSparientleave(dgvSparientHoliday,currentDate);
            string emailid = _EmailID;
            email(htmlString, "Status - " + currentDate, emailid);
            MessageBox.Show("Email sent successfully.");
            this.Close();
        }

        public static string gethtml(DataGridView grid, string date)
        {
            try
            {
                string messagebody = "<font > Team,<br><br> Following are the task done for " + date + "</font><br><br>";
                if (grid.RowCount == 0)
                {
                    return messagebody;
                }
                string htmlTableStart = "<table style=\"border-collapse:collapse;text-align:left;width:100%;\">";
                string htmlTableEnd = "</table>";

                string htmlHeaderRowStart = "<tr style=\"background-color:#aaaaaa;color:black;font-weight:bold;\">";
                string htmlHeaderRowEnd = "</tr>";

                string htmlTrStart = "<tr style=\"color:black;\">";
                string htmlTrEnd = "</tr>";

                string htmlTdStart = "<td @rows style=\"border-color:black;border-style:solid;border-width:thin;padding-left:5px;\">";
                string htmlTdEnd = "</td>";

                messagebody += htmlTableStart;

                messagebody += "<colgroup>";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 11%;\">";
                messagebody += "<col style = \"width: 12%;\">";
                messagebody += "</colgroup>";

                messagebody += htmlHeaderRowStart;
                messagebody += htmlTdStart + "Owner" + htmlTdEnd;
                messagebody += htmlTdStart + "CR" + htmlTdEnd;
                messagebody += htmlTdStart + "Component" + htmlTdEnd;
                messagebody += htmlTdStart + "Start Date" + htmlTdEnd;
                messagebody += htmlTdStart + "Planned Completion Date" + htmlTdEnd;
                messagebody += htmlTdStart + "Actual Completion Date" + htmlTdEnd;
                messagebody += htmlTdStart + "Hours Worked" + htmlTdEnd;
                messagebody += htmlTdStart + "Task" + htmlTdEnd;
                messagebody += htmlTdStart + "Status" + htmlTdEnd;
                messagebody += htmlHeaderRowEnd;
                int Owner_Count = 1, CR_Count = 1, Component_Count = 1,StartDate_Count=1,ActualCompletionDate_Count=1,PlannedCompletionDate_Count=1;

                for (int i = 0; i <= grid.Rows.Count - 1; i++)
                {
                    messagebody = messagebody + htmlTrStart;
                    string owner = grid.Rows[i].Cells[0].Value.ToString();
                    string CR = grid.Rows[i].Cells[1].Value.ToString();
                    string Component = grid.Rows[i].Cells[2].Value.ToString();
                    string StartDate = grid.Rows[i].Cells[3].Value.ToString();
                    string PlannedCompletionDate = grid.Rows[i].Cells[4].Value.ToString();
                    string ActualCompletionDate = grid.Rows[i].Cells[5].Value.ToString();
                    string Hoursworked = grid.Rows[i].Cells[6].Value.ToString();

                    int taskCount_Owner = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[0].Value.Equals(owner));
                    int taskCount_CR = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[1].Value.Equals(CR) && r.Cells[0].Value.Equals(owner));
                    int taskCount_Component = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[2].Value.Equals(Component) && r.Cells[0].Value.Equals(owner));
                    int taskCount_StartDate = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[3].Value.Equals(StartDate) && r.Cells[0].Value.Equals(owner));
                    int taskCount_PlannedCompletionDate= grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[4].Value.Equals(PlannedCompletionDate) && r.Cells[0].Value.Equals(owner));
                    int taskCount_ActualCompletionDate = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[5].Value.Equals(ActualCompletionDate) && r.Cells[0].Value.Equals(owner));
                    int taskCount_Hoursworked = grid.Rows.Cast<DataGridViewRow>().Count(r => r.Cells[5].Value.Equals(Hoursworked) && r.Cells[0].Value.Equals(owner));


                    if (i <= grid.Rows.Count - 2 && grid.Rows[i].Cells[0].Value.ToString() == grid.Rows[i + 1].Cells[0].Value.ToString())
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_Owner + "\"");
                        if (Owner_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[0].Value + htmlTdEnd;

                        Owner_Count++;
                    }
                    else if (Owner_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd;
                    }
                    else if (Owner_Count == taskCount_Owner)
                        Owner_Count = 1;


                    if (i <= grid.Rows.Count - 2 && CR_Count!=taskCount_CR && grid.Rows[i].Cells[1].Value.ToString() == grid.Rows[i + 1].Cells[1].Value.ToString() && grid.Rows[i].Cells[1].Value.ToString() != String.Empty)
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_CR + "\"");
                        if (CR_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[1].Value + htmlTdEnd;
                        CR_Count++;
                    }
                    else if (CR_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd;
                    }
                    else if (CR_Count == taskCount_CR)
                        CR_Count = 1;


                    if (i <= grid.Rows.Count - 2 && Component_Count!=taskCount_Component && grid.Rows[i].Cells[2].Value.ToString() == grid.Rows[i + 1].Cells[2].Value.ToString() && grid.Rows[i].Cells[2].Value.ToString() != String.Empty)
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_Component + "\"");
                        if (Component_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                        Component_Count++;
                    }
                    else if (Component_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                    }
                    else if (Component_Count == taskCount_Component)
                        Component_Count = 1;



                    if (i <= grid.Rows.Count - 2 && StartDate_Count != taskCount_StartDate && grid.Rows[i].Cells[3].Value.ToString() == grid.Rows[i + 1].Cells[3].Value.ToString() && grid.Rows[i].Cells[3].Value.ToString() != String.Empty)
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_StartDate + "\"");
                        if (StartDate_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[3].Value + htmlTdEnd;
                        StartDate_Count++;
                    }
                    else if (StartDate_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd;
                    }
                    else if (StartDate_Count == taskCount_StartDate)
                        StartDate_Count = 1;


                    if (i <= grid.Rows.Count - 2 && PlannedCompletionDate_Count != taskCount_PlannedCompletionDate && grid.Rows[i].Cells[4].Value.ToString() == grid.Rows[i + 1].Cells[4].Value.ToString() && grid.Rows[i].Cells[4].Value.ToString() != String.Empty)
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_PlannedCompletionDate + "\"");
                        if (PlannedCompletionDate_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[4].Value + htmlTdEnd;
                        PlannedCompletionDate_Count++;
                    }
                    else if (PlannedCompletionDate_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[4].Value + htmlTdEnd;
                    }
                    else if (PlannedCompletionDate_Count == taskCount_PlannedCompletionDate)
                        PlannedCompletionDate_Count = 1;


                    if (i <= grid.Rows.Count - 2 && ActualCompletionDate_Count != taskCount_ActualCompletionDate && grid.Rows[i].Cells[5].Value.ToString() == grid.Rows[i + 1].Cells[5].Value.ToString() && grid.Rows[i].Cells[5].Value.ToString() != String.Empty)
                    {
                        string td = htmlTdStart.Replace("@rows", "rowspan = \"" + taskCount_ActualCompletionDate + "\"");
                        if (ActualCompletionDate_Count == 1)
                            messagebody = messagebody + td + grid.Rows[i].Cells[5].Value + htmlTdEnd;
                        ActualCompletionDate_Count++;
                    }
                    else if (ActualCompletionDate_Count == 1)
                    {
                        messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[5].Value + htmlTdEnd;
                    }
                    else if (ActualCompletionDate_Count == taskCount_ActualCompletionDate)
                        ActualCompletionDate_Count = 1;


                    //messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                    //messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd;
                    //messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[4].Value + htmlTdEnd;
                    //messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[5].Value + htmlTdEnd;
                    //messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[6].Value + htmlTdEnd;


                    if (grid.Rows[i].Cells[6].Value.ToString() == "Hours Worked")
                    {
                        messagebody = messagebody + htmlTdStart + "<span style =\"color:black;font-weight:bold;\">" + grid.Rows[i].Cells[6].Value + "</span>" + htmlTdEnd;
                    }
                    else
                    {
                        string status = grid.Rows[i].Cells[6].Value.ToString().Replace("\r\n", "<br>").Replace(",", " <br>");
                        messagebody = messagebody + htmlTdStart + status + htmlTdEnd;
                    }


                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[7].Value + htmlTdEnd;
                    if (grid.Rows[i].Cells[8].Value.ToString() == "LEAVE")
                    {
                        messagebody = messagebody + htmlTdStart + "<span style =\"color:black;font-weight:bold;\">" + grid.Rows[i].Cells[8].Value + "</span>" + htmlTdEnd;
                    }
                    else
                    {
                        string status = grid.Rows[i].Cells[8].Value.ToString().Replace("\r\n", "<br>").Replace(",", " <br>");
                        messagebody = messagebody + htmlTdStart + status + htmlTdEnd;
                    }
                    messagebody = messagebody + htmlTrEnd;
                }
                messagebody = messagebody + htmlTableEnd;
                messagebody = messagebody.Replace("@rows", "");
                return messagebody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string getleave(DataGridView grid,string date)
        {
            try
            {


                if (grid.RowCount == 0)
                {
                    return "";
                }
                string messagebody = "<font ><br><br><b> Leave Plan </b></font>";



                string htmlTableStart = "<table style=\"border-collapse:collapse;text-align:left;width:60%;\">";
                string htmlTableEnd = "</table>";

                string htmlHeaderRowStart = "<tr style=\"background-color:#aaaaaa;color:black;font-weight:bold;\">";
                string htmlHeaderRowEnd = "</tr>";

                string htmlTrStart = "<tr style=\"color:black;\">";
                string htmlTrEnd = "</tr>";

                string htmlTdStart = "<td @rows style=\"border-color:black;border-style:solid;border-width:thin;padding-left:5px;\">";
                string htmlTdEnd = "</td>";

                messagebody += htmlTableStart;

                messagebody += "<colgroup>";
                messagebody += "<col style = \"width: 34%;\">";
                messagebody += "<col style = \"width: 14%;\">";
                messagebody += "<col style = \"width: 52%;\">";
                messagebody += "</colgroup>";

                messagebody += htmlHeaderRowStart;
                messagebody += htmlTdStart + "Employee Name" + htmlTdEnd;
                messagebody += htmlTdStart + "No.of Days" + htmlTdEnd;
                messagebody += htmlTdStart + "Date and Day" + htmlTdEnd;
                messagebody += htmlHeaderRowEnd;

                for (int i = 0; i <= grid.Rows.Count - 1; i++)
                {
                    messagebody = messagebody + htmlTrStart;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTrEnd;
                }
                messagebody = messagebody + htmlTableEnd;
                return messagebody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string getSparientleave(DataGridView grid, string date)
        {
            try
            {

                if (grid.RowCount == 0)
                {
                    return "";
                }
                string messagebody = "<font ><br><br><b> Sparient Holiday </b></font>";


                string htmlTableStart = "<table style=\"border-collapse:collapse;text-align:left;width:60%;\">";
                string htmlTableEnd = "</table>";

                string htmlHeaderRowStart = "<tr style=\"background-color:#aaaaaa;color:black;font-weight:bold;\">";
                string htmlHeaderRowEnd = "</tr>";

                string htmlTrStart = "<tr style=\"color:black;\">";
                string htmlTrEnd = "</tr>";

                string htmlTdStart = "<td @rows style=\"border-color:black;border-style:solid;border-width:thin;padding-left:5px;\">";
                string htmlTdEnd = "</td>";

                messagebody += htmlTableStart;

                messagebody += "<colgroup>";
                messagebody += "<col style = \"width: 34%;\">";
                messagebody += "<col style = \"width: 14%;\">";
                messagebody += "<col style = \"width: 52%;\">";
                messagebody += "</colgroup>";

                messagebody += htmlHeaderRowStart;
                messagebody += htmlTdStart + "Occassion" + htmlTdEnd;
                messagebody += htmlTdStart + "No.of Days" + htmlTdEnd;
                messagebody += htmlTdStart + "Date and Day" + htmlTdEnd;
                messagebody += htmlHeaderRowEnd;

                for (int i = 0; i <= grid.Rows.Count - 1; i++)
                {
                    messagebody = messagebody + htmlTrStart;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                    messagebody = messagebody + htmlTrEnd;
                }
                messagebody = messagebody + htmlTableEnd;
                return messagebody;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private static void email(string htmlString, string Subject, string emailID)
        {
            SmtpClient smtpClient;
            try
            {
                string smtpHost = ConfigurationManager.AppSettings["SMTPServer"].ToString();
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());
                string fromAddress = (ConfigurationManager.AppSettings["EmailFrom"].ToString());
                bool enableSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSSL"]);
                string fromAddresspwd = (ConfigurationManager.AppSettings["EmailFromPassword"].ToString());
                string ToMailID = emailID;
                string EmailCC = "";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.Subject = Subject;
                mail.Body = htmlString;
                mail.IsBodyHtml = true;

                if (!string.IsNullOrEmpty(ToMailID.Trim()))
                {
                    mail.To.Add(ToMailID);
                }
                if (!string.IsNullOrEmpty(EmailCC.Trim()))
                {
                    mail.CC.Add(EmailCC);
                }

                if (mail.To.Count == 0)
                {
                    return;
                }

                smtpClient = new System.Net.Mail.SmtpClient(smtpHost, smtpPort);

                smtpClient.EnableSsl = enableSSL;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential(fromAddress, fromAddresspwd);
                smtpClient.Send(mail);
            }
            catch (SmtpException sqlEx)
            {
                throw sqlEx;
            }
            finally
            {
                smtpClient = null;
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Loadgrid();
            if (dtDate.Value.Date == DateTime.Now.Date)

                btnSendEmail.Show();
            // else
            //    btnSendEmail.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            StatusList s1 = new StatusList();
            s1.Show();
            this.Hide();
        }


    }
}


