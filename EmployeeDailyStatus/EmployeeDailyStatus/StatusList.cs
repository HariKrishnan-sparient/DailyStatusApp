using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using BusinessLayer;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Drawing.Text;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace EmployeeDailyStatus
{

	public partial class StatusList : Form
	{
		public string _UserID;
		public string _EmailId;
		public DataTable dtTask = new DataTable();
		//public StatusEdit _frmStatusEdit;
		public StatusList()
		{
			BAL balobj = new BAL();
			this.WindowState = FormWindowState.Maximized;
			string userid;
			try
			{
				string accountName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                
                if (accountName.ToLower().Contains("spchlap") && accountName.Split('\\').Length > 0)
				{
					userid = accountName.Substring(accountName.LastIndexOf('\\') + 1);		  
					DataTable dt = balobj.ValidateUsers(userid);
					if (dt.Rows.Count > 0)
					{
						string emailid = dt.Rows[0]["EmailId"].ToString();
						_UserID = dt.Rows[0]["Name"].ToString();
						_EmailId = emailid;
						InitializeComponent();
					}
					else
					{
						MessageBox.Show("User does not have permission to login.");
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("Non domain user to loggin in" + accountName);
					this.Close();
				}
			}
			catch
			{
				throw;
			}
		}

		private void StatusList_Load(object sender, EventArgs e)
		{
			txtUserId.Text = _UserID;
			dtDate.Value = DateTime.Now;	  
			LoadStatus();
			dtDate.Cursor = Cursors.Default;

		}

		public void LoadInProgressStatus(string UserId, DateTime dtStatusDate)
		{
			BAL balobj = new BAL();
			try
			{
				DataSet ds = balobj.SelectInProgressStatus(UserId, dtStatusDate);
				if (ds != null && ds.Tables.Count > 0)
				{
					DataTable dtStatus = ds.Tables[0];
					DataTable dtTask = ds.Tables[1];
					for (int i = 0; i < dtStatus.Rows.Count; i++)
					{
						DataRow dr = dtStatus.Rows[i];
						int statusid = Convert.ToInt32(dr["Id"].ToString());
						DateTime dtstartdate = DateTime.Parse(dr["StartDate"].ToString());
						DateTime dtPlannedCompletion = DateTime.Parse(dr["PlannedCompletionDate"].ToString());
						DataTable _dtTask = dtTask.AsEnumerable().Where(x => x["StatusId"].ToString() == statusid.ToString()).CopyToDataTable();
						string ActualCompletionDate = dr["ActualCompletionDate"].ToString() == "" ? null : DateTime.Parse(dr["ActualCompletionDate"].ToString()).ToString();
						balobj.InsertStatus(UserId, dr["CR"].ToString(), dr["Component"].ToString(), dtstartdate, dtPlannedCompletion, ActualCompletionDate, dr["CRStatus"].ToString(), DateTime.Today, _dtTask);
					}
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public void LoadStatus()
		{
			BAL balobj = new BAL();
			string UserId = txtUserId.Text;
			DateTime dtStatusDate = dtDate.Value;
			// load Previous InProgress Status
			LoadInProgressStatus(UserId, dtStatusDate);

			//
            DataTable dt = balobj.SelectStatus(UserId,dtStatusDate);
			dgv1.AutoGenerateColumns = false;
			dgv1.DataSource = dt;
			dgv1.Refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var myForm = new StatusEdit(this, _UserID);
			myForm.Show();
		}

		//private void dtDate_ValueChanged(object sender, EventArgs e)
		//{
		//    if (dtDate.Value.Date == DateTime.Now.Date)
		//    {
		//        LoadCR();


		//        btnAdd.Show();
		//    }
		//    else
		//        btnAdd.Hide();
		//}

		private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv1.Columns[e.ColumnIndex].HeaderText.ToUpper() == "EDIT")
			{
				int rowIndex = e.RowIndex;
				int ID = Convert.ToInt32(dgv1.Rows[rowIndex].Cells["ID"].Value.ToString());
				var myForm = new StatusEdit(ID, this, _UserID);
				myForm.Show();
			}
			if (dgv1.Columns[e.ColumnIndex].HeaderText.ToUpper() == "DELETE")
			{
				BAL balobj = new BAL();
				int rowIndex = e.RowIndex;
				int ID = Convert.ToInt32(dgv1.Rows[rowIndex].Cells["ID"].Value.ToString());
				bool result;
				DialogResult res = MessageBox.Show("Are you sure you want to permanently remove from Employee Daily Status?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

				if (res == DialogResult.OK)
					result = balobj.DeleteStatus(ID);

				LoadStatus();
			
			}

		}
		private void btnShow_Click(object sender, EventArgs e)
		{
		
			LoadStatus();
			if (dtDate.Value.Date != DateTime.Now.Date)
				btnAdd.Hide();
			else
				btnAdd.Show();
		  
		}

		private void btnReview_Click(object sender, EventArgs e)
		{
			var form = new StatusReview(_EmailId);
			form.ShowDialog();
		}

		private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (dtDate.Value.Date != DateTime.Now.Date)
			{
				this.dgv1.Columns["EDIT"].Visible = false;
				this.dgv1.Columns["DELETE"].Visible = false;

			}
			else
			{
				this.dgv1.Columns["EDIT"].Visible = true;
				this.dgv1.Columns["DELETE"].Visible = true;
			}
		}

		private void StatusList_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void btnLeave_Click(object sender, EventArgs e)
        {
            var myForm = new StatusLeave(_UserID);
            myForm.Show();
		
        }
    }
}
	




