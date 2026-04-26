namespace Calendar.View
{
    partial class AppointmentDetailForm
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
            this.labelAppDetail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lableLocation = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEndHour = new System.Windows.Forms.Label();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelReminder = new System.Windows.Forms.Label();
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelAppLocation = new System.Windows.Forms.Label();
            this.labelAppDate = new System.Windows.Forms.Label();
            this.labelAppEndhour = new System.Windows.Forms.Label();
            this.labelAppStartHour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppDetail
            // 
            this.labelAppDetail.AutoSize = true;
            this.labelAppDetail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppDetail.Location = new System.Drawing.Point(262, 16);
            this.labelAppDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppDetail.Name = "labelAppDetail";
            this.labelAppDetail.Size = new System.Drawing.Size(253, 37);
            this.labelAppDetail.TabIndex = 0;
            this.labelAppDetail.Text = "Thông tin cuộc hẹn";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 72);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(148, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên cuộc hẹn:";
            // 
            // lableLocation
            // 
            this.lableLocation.AutoSize = true;
            this.lableLocation.Location = new System.Drawing.Point(55, 119);
            this.lableLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableLocation.Name = "lableLocation";
            this.lableLocation.Size = new System.Drawing.Size(66, 29);
            this.lableLocation.TabIndex = 0;
            this.lableLocation.Text = "Vị trí:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(55, 163);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(143, 29);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Ngày diễn ra:";
            // 
            // labelEndHour
            // 
            this.labelEndHour.AutoSize = true;
            this.labelEndHour.Location = new System.Drawing.Point(55, 254);
            this.labelEndHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndHour.Name = "labelEndHour";
            this.labelEndHour.Size = new System.Drawing.Size(138, 29);
            this.labelEndHour.TabIndex = 0;
            this.labelEndHour.Text = "Giờ kết thúc:";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(55, 209);
            this.labelStartHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(135, 29);
            this.labelStartHour.TabIndex = 0;
            this.labelStartHour.Text = "Giờ bắt đầu:";
            // 
            // labelReminder
            // 
            this.labelReminder.AutoSize = true;
            this.labelReminder.Location = new System.Drawing.Point(431, 156);
            this.labelReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(98, 29);
            this.labelReminder.TabIndex = 0;
            this.labelReminder.Text = "Bộ nhắc:";
            // 
            // listViewReminder
            // 
            this.listViewReminder.HideSelection = false;
            this.listViewReminder.Location = new System.Drawing.Point(436, 188);
            this.listViewReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(261, 96);
            this.listViewReminder.TabIndex = 1;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            this.listViewReminder.View = System.Windows.Forms.View.Details;
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Location = new System.Drawing.Point(55, 307);
            this.labelParticipants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(266, 29);
            this.labelParticipants.TabIndex = 0;
            this.labelParticipants.Text = "Thông tin người tham gia:";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Location = new System.Drawing.Point(60, 338);
            this.dgvParticipants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersWidth = 72;
            this.dgvParticipants.RowTemplate.Height = 31;
            this.dgvParticipants.Size = new System.Drawing.Size(653, 150);
            this.dgvParticipants.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 513);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Location = new System.Drawing.Point(213, 72);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(74, 29);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "label1";
            // 
            // labelAppLocation
            // 
            this.labelAppLocation.AutoSize = true;
            this.labelAppLocation.Location = new System.Drawing.Point(213, 119);
            this.labelAppLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLocation.Name = "labelAppLocation";
            this.labelAppLocation.Size = new System.Drawing.Size(74, 29);
            this.labelAppLocation.TabIndex = 0;
            this.labelAppLocation.Text = "label1";
            // 
            // labelAppDate
            // 
            this.labelAppDate.AutoSize = true;
            this.labelAppDate.Location = new System.Drawing.Point(213, 163);
            this.labelAppDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppDate.Name = "labelAppDate";
            this.labelAppDate.Size = new System.Drawing.Size(74, 29);
            this.labelAppDate.TabIndex = 0;
            this.labelAppDate.Text = "label1";
            // 
            // labelAppEndhour
            // 
            this.labelAppEndhour.AutoSize = true;
            this.labelAppEndhour.Location = new System.Drawing.Point(213, 254);
            this.labelAppEndhour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppEndhour.Name = "labelAppEndhour";
            this.labelAppEndhour.Size = new System.Drawing.Size(74, 29);
            this.labelAppEndhour.TabIndex = 0;
            this.labelAppEndhour.Text = "label1";
            // 
            // labelAppStartHour
            // 
            this.labelAppStartHour.AutoSize = true;
            this.labelAppStartHour.Location = new System.Drawing.Point(213, 209);
            this.labelAppStartHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppStartHour.Name = "labelAppStartHour";
            this.labelAppStartHour.Size = new System.Drawing.Size(74, 29);
            this.labelAppStartHour.TabIndex = 0;
            this.labelAppStartHour.Text = "label1";
            // 
            // AppointmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(776, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvParticipants);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.labelReminder);
            this.Controls.Add(this.labelAppStartHour);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.labelAppEndhour);
            this.Controls.Add(this.labelParticipants);
            this.Controls.Add(this.labelAppDate);
            this.Controls.Add(this.labelEndHour);
            this.Controls.Add(this.labelAppLocation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.lableLocation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAppDetail);
            this.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppointmentDetailForm";
            this.Text = "AppointmentDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppDetail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lableLocation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEndHour;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelReminder;
        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelAppLocation;
        private System.Windows.Forms.Label labelAppDate;
        private System.Windows.Forms.Label labelAppEndhour;
        private System.Windows.Forms.Label labelAppStartHour;
    }
}