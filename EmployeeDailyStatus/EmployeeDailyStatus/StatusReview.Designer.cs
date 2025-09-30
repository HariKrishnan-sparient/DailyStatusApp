namespace EmployeeDailyStatus
{
    partial class StatusReview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvLeavePlan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSparientHoliday = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leavedays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEANDDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occassion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoofDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLANNEDCOMPLETIONDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTUALCOMPLETIONDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stattus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavePlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparientHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(54, 34);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "DATE";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "MM/dd/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(124, 31);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(176, 25);
            this.dtDate.TabIndex = 1;
            // 
            // dgvReview
            // 
            this.dgvReview.AllowUserToAddRows = false;
            this.dgvReview.AllowUserToDeleteRows = false;
            this.dgvReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Owner,
            this.CR,
            this.Component,
            this.STARTDATE,
            this.PLANNEDCOMPLETIONDATE,
            this.ACTUALCOMPLETIONDATE,
            this.HoursWorked,
            this.Task,
            this.Stattus});
            this.dgvReview.Location = new System.Drawing.Point(-2, 100);
            this.dgvReview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.ReadOnly = true;
            this.dgvReview.RowHeadersVisible = false;
            this.dgvReview.RowHeadersWidth = 51;
            this.dgvReview.RowTemplate.Height = 24;
            this.dgvReview.Size = new System.Drawing.Size(1707, 361);
            this.dgvReview.TabIndex = 2;
            this.dgvReview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReview_CellFormatting);
            this.dgvReview.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReview_CellPainting);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSendEmail.Location = new System.Drawing.Point(489, 25);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(146, 36);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "SEND EMAIL";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.dtDate);
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1801, 94);
            this.panel1.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnback.Location = new System.Drawing.Point(930, 25);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(146, 36);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back To StatusList";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(356, 27);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 32);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvLeavePlan
            // 
            this.dgvLeavePlan.AllowUserToAddRows = false;
            this.dgvLeavePlan.AllowUserToDeleteRows = false;
            this.dgvLeavePlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeavePlan.ColumnHeadersHeight = 29;
            this.dgvLeavePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLeavePlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.Leavedays,
            this.DATEANDDAY});
            this.dgvLeavePlan.Location = new System.Drawing.Point(14, 501);
            this.dgvLeavePlan.Name = "dgvLeavePlan";
            this.dgvLeavePlan.ReadOnly = true;
            this.dgvLeavePlan.RowHeadersVisible = false;
            this.dgvLeavePlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLeavePlan.RowTemplate.Height = 24;
            this.dgvLeavePlan.Size = new System.Drawing.Size(787, 97);
            this.dgvLeavePlan.TabIndex = 5;
            this.dgvLeavePlan.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Leave Plan";
            this.label1.Visible = false;
            // 
            // dgvSparientHoliday
            // 
            this.dgvSparientHoliday.AllowUserToAddRows = false;
            this.dgvSparientHoliday.AllowUserToDeleteRows = false;
            this.dgvSparientHoliday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSparientHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparientHoliday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Occassion,
            this.NoofDays,
            this.Date});
            this.dgvSparientHoliday.Location = new System.Drawing.Point(12, 648);
            this.dgvSparientHoliday.Name = "dgvSparientHoliday";
            this.dgvSparientHoliday.ReadOnly = true;
            this.dgvSparientHoliday.RowHeadersVisible = false;
            this.dgvSparientHoliday.RowHeadersWidth = 51;
            this.dgvSparientHoliday.RowTemplate.Height = 24;
            this.dgvSparientHoliday.Size = new System.Drawing.Size(789, 75);
            this.dgvSparientHoliday.TabIndex = 7;
            this.dgvSparientHoliday.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sparient Holiday";
            this.label2.Visible = false;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "Employee Name";
            this.NAME.FillWeight = 60F;
            this.NAME.HeaderText = "EmployeeName";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // Leavedays
            // 
            this.Leavedays.DataPropertyName = "No.of Days";
            this.Leavedays.FillWeight = 50F;
            this.Leavedays.HeaderText = "No.of Days";
            this.Leavedays.MinimumWidth = 3;
            this.Leavedays.Name = "Leavedays";
            this.Leavedays.ReadOnly = true;
            // 
            // DATEANDDAY
            // 
            this.DATEANDDAY.DataPropertyName = "Date and Day";
            this.DATEANDDAY.HeaderText = "Date And Day";
            this.DATEANDDAY.MinimumWidth = 6;
            this.DATEANDDAY.Name = "DATEANDDAY";
            this.DATEANDDAY.ReadOnly = true;
            // 
            // Occassion
            // 
            this.Occassion.DataPropertyName = "Occassion";
            this.Occassion.FillWeight = 60F;
            this.Occassion.HeaderText = "Occassion";
            this.Occassion.MinimumWidth = 6;
            this.Occassion.Name = "Occassion";
            this.Occassion.ReadOnly = true;
            // 
            // NoofDays
            // 
            this.NoofDays.DataPropertyName = "NoofDays";
            this.NoofDays.FillWeight = 50F;
            this.NoofDays.HeaderText = "No.Of Days";
            this.NoofDays.MinimumWidth = 6;
            this.NoofDays.Name = "NoofDays";
            this.NoofDays.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "DateDay";
            this.Date.HeaderText = "Date And Day";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Owner
            // 
            this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Owner.DataPropertyName = "Owner";
            this.Owner.HeaderText = "OWNER";
            this.Owner.MinimumWidth = 6;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // CR
            // 
            this.CR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CR.DataPropertyName = "CR";
            this.CR.FillWeight = 80F;
            this.CR.HeaderText = "CR";
            this.CR.MinimumWidth = 6;
            this.CR.Name = "CR";
            this.CR.ReadOnly = true;
            // 
            // Component
            // 
            this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Component.DataPropertyName = "Component";
            this.Component.FillWeight = 120F;
            this.Component.HeaderText = "COMPONENT";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            // 
            // STARTDATE
            // 
            this.STARTDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STARTDATE.DataPropertyName = "StartDate";
            this.STARTDATE.FillWeight = 130F;
            this.STARTDATE.HeaderText = "START DATE";
            this.STARTDATE.MinimumWidth = 6;
            this.STARTDATE.Name = "STARTDATE";
            this.STARTDATE.ReadOnly = true;
            // 
            // PLANNEDCOMPLETIONDATE
            // 
            this.PLANNEDCOMPLETIONDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLANNEDCOMPLETIONDATE.DataPropertyName = "PlannedCompletionDate";
            this.PLANNEDCOMPLETIONDATE.FillWeight = 160F;
            this.PLANNEDCOMPLETIONDATE.HeaderText = "PLANNED COMPLETION DATE";
            this.PLANNEDCOMPLETIONDATE.MinimumWidth = 6;
            this.PLANNEDCOMPLETIONDATE.Name = "PLANNEDCOMPLETIONDATE";
            this.PLANNEDCOMPLETIONDATE.ReadOnly = true;
            // 
            // ACTUALCOMPLETIONDATE
            // 
            this.ACTUALCOMPLETIONDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ACTUALCOMPLETIONDATE.DataPropertyName = "ActualCompletionDate";
            this.ACTUALCOMPLETIONDATE.FillWeight = 160F;
            this.ACTUALCOMPLETIONDATE.HeaderText = "ACTUAL COMPLETION DATE";
            this.ACTUALCOMPLETIONDATE.MinimumWidth = 6;
            this.ACTUALCOMPLETIONDATE.Name = "ACTUALCOMPLETIONDATE";
            this.ACTUALCOMPLETIONDATE.ReadOnly = true;
            // 
            // HoursWorked
            // 
            this.HoursWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoursWorked.DataPropertyName = "HoursWorked";
            this.HoursWorked.FillWeight = 90F;
            this.HoursWorked.HeaderText = "HOURSWORKED";
            this.HoursWorked.MinimumWidth = 6;
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.ReadOnly = true;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "Task";
            this.Task.HeaderText = "TASK";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // Stattus
            // 
            this.Stattus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stattus.DataPropertyName = "Status";
            this.Stattus.FillWeight = 200F;
            this.Stattus.HeaderText = "STATUS";
            this.Stattus.MinimumWidth = 6;
            this.Stattus.Name = "Stattus";
            this.Stattus.ReadOnly = true;
            // 
            // StatusReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSparientHoliday);
            this.Controls.Add(this.dgvLeavePlan);
            this.Controls.Add(this.dgvReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatusReview";
            this.Text = "StatusReview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatusReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavePlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparientHoliday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvLeavePlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSparientHoliday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leavedays;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEANDDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occassion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoofDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLANNEDCOMPLETIONDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTUALCOMPLETIONDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stattus;
    }
}