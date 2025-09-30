namespace EmployeeDailyStatus
{
    partial class StatusEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.lblComponent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlannedCompletionDate = new System.Windows.Forms.Label();
            this.lblActualCompletionDate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.DtStartDate = new System.Windows.Forms.DateTimePicker();
            this.DtActualCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.dtPlannedCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.CmbComponent = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.CmbTask = new System.Windows.Forms.ComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAddtask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCRStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD/EDIT STATUS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(37, 71);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(62, 17);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "USERID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(326, 71);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DATE";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(37, 147);
            this.lblCR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(28, 17);
            this.lblCR.TabIndex = 3;
            this.lblCR.Text = "CR";
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Location = new System.Drawing.Point(37, 185);
            this.lblComponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(102, 17);
            this.lblComponent.TabIndex = 4;
            this.lblComponent.Text = "COMPONENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "START DATE";
            // 
            // lblPlannedCompletionDate
            // 
            this.lblPlannedCompletionDate.AutoSize = true;
            this.lblPlannedCompletionDate.Location = new System.Drawing.Point(37, 262);
            this.lblPlannedCompletionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlannedCompletionDate.Name = "lblPlannedCompletionDate";
            this.lblPlannedCompletionDate.Size = new System.Drawing.Size(226, 17);
            this.lblPlannedCompletionDate.TabIndex = 6;
            this.lblPlannedCompletionDate.Text = "PLANNED  COMPLETION DATE";
            // 
            // lblActualCompletionDate
            // 
            this.lblActualCompletionDate.AutoSize = true;
            this.lblActualCompletionDate.Location = new System.Drawing.Point(37, 301);
            this.lblActualCompletionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualCompletionDate.Name = "lblActualCompletionDate";
            this.lblActualCompletionDate.Size = new System.Drawing.Size(211, 17);
            this.lblActualCompletionDate.TabIndex = 7;
            this.lblActualCompletionDate.Text = "ACTUAL COMPLETION DATE";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(652, 185);
            this.lblHoursWorked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(129, 17);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "HOURS WORKED";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(139, 66);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(159, 25);
            this.txtUserId.TabIndex = 10;
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(307, 144);
            this.txtCR.Margin = new System.Windows.Forms.Padding(2);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(254, 25);
            this.txtCR.TabIndex = 11;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(856, 182);
            this.txtHoursWorked.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(254, 25);
            this.txtHoursWorked.TabIndex = 12;
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "MM/dd/yyyy";
            this.dtdate.Enabled = false;
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(400, 66);
            this.dtdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(160, 25);
            this.dtdate.TabIndex = 14;
            this.dtdate.Value = new System.DateTime(2024, 1, 5, 12, 39, 27, 0);
            // 
            // DtStartDate
            // 
            this.DtStartDate.CustomFormat = "MM/dd/yyyy";
            this.DtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStartDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DtStartDate.Location = new System.Drawing.Point(307, 221);
            this.DtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtStartDate.Name = "DtStartDate";
            this.DtStartDate.Size = new System.Drawing.Size(254, 25);
            this.DtStartDate.TabIndex = 15;
            this.DtStartDate.Value = new System.DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // DtActualCompletionDate
            // 
            this.DtActualCompletionDate.CustomFormat = " ";
            this.DtActualCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtActualCompletionDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DtActualCompletionDate.Location = new System.Drawing.Point(307, 298);
            this.DtActualCompletionDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtActualCompletionDate.Name = "DtActualCompletionDate";
            this.DtActualCompletionDate.Size = new System.Drawing.Size(254, 25);
            this.DtActualCompletionDate.TabIndex = 16;
            this.DtActualCompletionDate.Tag = "0";
            this.DtActualCompletionDate.ValueChanged += new System.EventHandler(this.DtActualCompletionDate_ValueChanged);
            // 
            // dtPlannedCompletionDate
            // 
            this.dtPlannedCompletionDate.CustomFormat = "MM/dd/yyyy";
            this.dtPlannedCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPlannedCompletionDate.Location = new System.Drawing.Point(307, 259);
            this.dtPlannedCompletionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPlannedCompletionDate.Name = "dtPlannedCompletionDate";
            this.dtPlannedCompletionDate.Size = new System.Drawing.Size(254, 25);
            this.dtPlannedCompletionDate.TabIndex = 17;
            this.dtPlannedCompletionDate.Value = new System.DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // CmbComponent
            // 
            this.CmbComponent.FormattingEnabled = true;
            this.CmbComponent.Location = new System.Drawing.Point(307, 181);
            this.CmbComponent.Margin = new System.Windows.Forms.Padding(2);
            this.CmbComponent.Name = "CmbComponent";
            this.CmbComponent.Size = new System.Drawing.Size(254, 25);
            this.CmbComponent.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(483, 495);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(572, 495);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 34);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(652, 561);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 21;
            // 
            // CmbTask
            // 
            this.CmbTask.FormattingEnabled = true;
            this.CmbTask.Items.AddRange(new object[] {
            "Load"});
            this.CmbTask.Location = new System.Drawing.Point(856, 142);
            this.CmbTask.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmbTask.Name = "CmbTask";
            this.CmbTask.Size = new System.Drawing.Size(254, 25);
            this.CmbTask.TabIndex = 25;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(652, 147);
            this.lblTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(46, 17);
            this.lblTask.TabIndex = 24;
            this.lblTask.Text = "TASK";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(656, 259);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(531, 95);
            this.txtStatus.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(652, 224);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 17);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "STATUS DETAILS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.HoursWorked,
            this.Status,
            this.DELETE});
            this.dataGridView1.Location = new System.Drawing.Point(656, 392);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(530, 104);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Task
            // 
            this.Task.DataPropertyName = "Task";
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // HoursWorked
            // 
            this.HoursWorked.DataPropertyName = "HoursWorked";
            this.HoursWorked.HeaderText = "HoursWorked";
            this.HoursWorked.MinimumWidth = 6;
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DELETE.Text = "Delete";
            this.DELETE.UseColumnTextForLinkValue = true;
            // 
            // btnAddtask
            // 
            this.btnAddtask.Location = new System.Drawing.Point(1094, 360);
            this.btnAddtask.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddtask.Name = "btnAddtask";
            this.btnAddtask.Size = new System.Drawing.Size(94, 25);
            this.btnAddtask.TabIndex = 32;
            this.btnAddtask.Text = "ADD TASK";
            this.btnAddtask.UseVisualStyleBackColor = true;
            this.btnAddtask.Click += new System.EventHandler(this.btnAddtask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "TASK DETAILS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(894, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back To StatusList";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCRStatus
            // 
            this.lblCRStatus.AutoSize = true;
            this.lblCRStatus.Location = new System.Drawing.Point(37, 346);
            this.lblCRStatus.Name = "lblCRStatus";
            this.lblCRStatus.Size = new System.Drawing.Size(85, 17);
            this.lblCRStatus.TabIndex = 35;
            this.lblCRStatus.Text = "CR STATUS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.comboBox1.Location = new System.Drawing.Point(307, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 25);
            this.comboBox1.TabIndex = 36;
            // 
            // StatusEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 537);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCRStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddtask);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.CmbTask);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CmbComponent);
            this.Controls.Add(this.dtPlannedCompletionDate);
            this.Controls.Add(this.DtActualCompletionDate);
            this.Controls.Add(this.DtStartDate);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblActualCompletionDate);
            this.Controls.Add(this.lblPlannedCompletionDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblComponent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCR);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatusEdit";
            this.Text = "StatusEdit";
            this.Load += new System.EventHandler(this.StatusEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlannedCompletionDate;
        private System.Windows.Forms.Label lblActualCompletionDate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.DateTimePicker DtStartDate;
        private System.Windows.Forms.DateTimePicker DtActualCompletionDate;
        private System.Windows.Forms.DateTimePicker dtPlannedCompletionDate;
        private System.Windows.Forms.ComboBox CmbComponent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox CmbTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddtask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewLinkColumn DELETE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCRStatus;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}