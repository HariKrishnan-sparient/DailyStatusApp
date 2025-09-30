namespace EmployeeDailyStatus
{
    partial class StatusLeave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblLeaveFrom = new System.Windows.Forms.Label();
            this.lblLeaveTo = new System.Windows.Forms.Label();
            this.dtLeaveFrom = new System.Windows.Forms.DateTimePicker();
            this.dtLeaveTo = new System.Windows.Forms.DateTimePicker();
            this.btnAddLeave = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.dgvLeaveDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLeaveDays = new System.Windows.Forms.Label();
            this.txtLeaveDays = new System.Windows.Forms.TextBox();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveApplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(67, 88);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "USERID";
            // 
            // lblLeaveFrom
            // 
            this.lblLeaveFrom.AutoSize = true;
            this.lblLeaveFrom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveFrom.Location = new System.Drawing.Point(67, 186);
            this.lblLeaveFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveFrom.Name = "lblLeaveFrom";
            this.lblLeaveFrom.Size = new System.Drawing.Size(110, 19);
            this.lblLeaveFrom.TabIndex = 2;
            this.lblLeaveFrom.Text = "LEAVE FROM";
            // 
            // lblLeaveTo
            // 
            this.lblLeaveTo.AutoSize = true;
            this.lblLeaveTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveTo.Location = new System.Drawing.Point(480, 186);
            this.lblLeaveTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveTo.Name = "lblLeaveTo";
            this.lblLeaveTo.Size = new System.Drawing.Size(84, 19);
            this.lblLeaveTo.TabIndex = 3;
            this.lblLeaveTo.Text = "LEAVE TO";
            // 
            // dtLeaveFrom
            // 
            this.dtLeaveFrom.CustomFormat = "MM/dd/yyyy";
            this.dtLeaveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLeaveFrom.Location = new System.Drawing.Point(200, 182);
            this.dtLeaveFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtLeaveFrom.Name = "dtLeaveFrom";
            this.dtLeaveFrom.Size = new System.Drawing.Size(223, 27);
            this.dtLeaveFrom.TabIndex = 4;
            this.dtLeaveFrom.ValueChanged += new System.EventHandler(this.dtLeaveFrom_ValueChanged);
            // 
            // dtLeaveTo
            // 
            this.dtLeaveTo.CustomFormat = "MM/dd/yyyy";
            this.dtLeaveTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLeaveTo.Location = new System.Drawing.Point(613, 182);
            this.dtLeaveTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtLeaveTo.Name = "dtLeaveTo";
            this.dtLeaveTo.Size = new System.Drawing.Size(223, 27);
            this.dtLeaveTo.TabIndex = 5;
            this.dtLeaveTo.ValueChanged += new System.EventHandler(this.dtLeaveFrom_ValueChanged);
            // 
            // btnAddLeave
            // 
            this.btnAddLeave.Location = new System.Drawing.Point(160, 279);
            this.btnAddLeave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddLeave.Name = "btnAddLeave";
            this.btnAddLeave.Size = new System.Drawing.Size(143, 29);
            this.btnAddLeave.TabIndex = 6;
            this.btnAddLeave.Text = "SAVE";
            this.btnAddLeave.UseVisualStyleBackColor = true;
            this.btnAddLeave.Click += new System.EventHandler(this.btnAddLeave_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(171, 84);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(187, 27);
            this.txtUserId.TabIndex = 7;
            // 
            // dgvLeaveDetails
            // 
            this.dgvLeaveDetails.AllowUserToAddRows = false;
            this.dgvLeaveDetails.AllowUserToDeleteRows = false;
            this.dgvLeaveDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.colLeaveFrom,
            this.colLeaveTo,
            this.colLeaveDays,
            this.colLeaveApplied,
            this.colEdit,
            this.colDelete});
            this.dgvLeaveDetails.Location = new System.Drawing.Point(64, 372);
            this.dgvLeaveDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvLeaveDetails.Name = "dgvLeaveDetails";
            this.dgvLeaveDetails.ReadOnly = true;
            this.dgvLeaveDetails.RowHeadersVisible = false;
            this.dgvLeaveDetails.RowHeadersWidth = 51;
            this.dgvLeaveDetails.RowTemplate.Height = 24;
            this.dgvLeaveDetails.Size = new System.Drawing.Size(1065, 231);
            this.dgvLeaveDetails.TabIndex = 10;
            this.dgvLeaveDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveDetails_CellContentClick);
            this.dgvLeaveDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLeaveDetails_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "DATE";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 279);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Location = new System.Drawing.Point(858, 81);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 32);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back To StatusList";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLeaveDays
            // 
            this.lblLeaveDays.AutoSize = true;
            this.lblLeaveDays.Location = new System.Drawing.Point(67, 235);
            this.lblLeaveDays.Name = "lblLeaveDays";
            this.lblLeaveDays.Size = new System.Drawing.Size(104, 19);
            this.lblLeaveDays.TabIndex = 15;
            this.lblLeaveDays.Text = "LEAVE DAYS";
            // 
            // txtLeaveDays
            // 
            this.txtLeaveDays.Enabled = false;
            this.txtLeaveDays.Location = new System.Drawing.Point(200, 232);
            this.txtLeaveDays.Name = "txtLeaveDays";
            this.txtLeaveDays.Size = new System.Drawing.Size(223, 27);
            this.txtLeaveDays.TabIndex = 16;
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "MM/dd/yyyy";
            this.dtdate.Enabled = false;
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(461, 84);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(207, 27);
            this.dtdate.TabIndex = 17;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(450, 284);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 19);
            this.lblMessage.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "ADD/EDIT LEAVE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "LEAVE DETAILS";
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            // 
            // colLeaveFrom
            // 
            this.colLeaveFrom.DataPropertyName = "LeaveFrom";
            this.colLeaveFrom.HeaderText = "LEAVE FROM";
            this.colLeaveFrom.MinimumWidth = 6;
            this.colLeaveFrom.Name = "colLeaveFrom";
            this.colLeaveFrom.ReadOnly = true;
            // 
            // colLeaveTo
            // 
            this.colLeaveTo.DataPropertyName = "LeaveTo";
            this.colLeaveTo.HeaderText = "LEAVE TO";
            this.colLeaveTo.MinimumWidth = 6;
            this.colLeaveTo.Name = "colLeaveTo";
            this.colLeaveTo.ReadOnly = true;
            // 
            // colLeaveDays
            // 
            this.colLeaveDays.DataPropertyName = "LeaveDays";
            this.colLeaveDays.HeaderText = "LEAVE DAYS";
            this.colLeaveDays.MinimumWidth = 6;
            this.colLeaveDays.Name = "colLeaveDays";
            this.colLeaveDays.ReadOnly = true;
            // 
            // colLeaveApplied
            // 
            this.colLeaveApplied.DataPropertyName = "AppliedDate";
            this.colLeaveApplied.HeaderText = "LEAVE APPLIED";
            this.colLeaveApplied.MinimumWidth = 6;
            this.colLeaveApplied.Name = "colLeaveApplied";
            this.colLeaveApplied.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "EDIT";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "DELETE";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // StatusLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.txtLeaveDays);
            this.Controls.Add(this.lblLeaveDays);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLeaveDetails);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnAddLeave);
            this.Controls.Add(this.dtLeaveTo);
            this.Controls.Add(this.dtLeaveFrom);
            this.Controls.Add(this.lblLeaveTo);
            this.Controls.Add(this.lblLeaveFrom);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StatusLeave";
            this.Text = "StatusLeave";
            this.Load += new System.EventHandler(this.StatusLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLeaveFrom;
        private System.Windows.Forms.Label lblLeaveTo;
        private System.Windows.Forms.DateTimePicker dtLeaveFrom;
        private System.Windows.Forms.DateTimePicker dtLeaveTo;
        private System.Windows.Forms.Button btnAddLeave;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.DataGridView dgvLeaveDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLeaveDays;
        private System.Windows.Forms.TextBox txtLeaveDays;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveApplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelete;
    }
}