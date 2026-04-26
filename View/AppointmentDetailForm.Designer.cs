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
            this.labelAppDetail.Location = new System.Drawing.Point(367, 23);
            this.labelAppDetail.Name = "labelAppDetail";
            this.labelAppDetail.Size = new System.Drawing.Size(316, 51);
            this.labelAppDetail.TabIndex = 0;
            this.labelAppDetail.Text = "Thông tin sự kiện";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(77, 101);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(198, 40);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên cuộc hẹn:";
            // 
            // lableLocation
            // 
            this.lableLocation.AutoSize = true;
            this.lableLocation.Location = new System.Drawing.Point(77, 167);
            this.lableLocation.Name = "lableLocation";
            this.lableLocation.Size = new System.Drawing.Size(91, 40);
            this.lableLocation.TabIndex = 0;
            this.lableLocation.Text = "Vị trí:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(77, 228);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(191, 40);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Ngày diễn ra:";
            // 
            // labelEndHour
            // 
            this.labelEndHour.AutoSize = true;
            this.labelEndHour.Location = new System.Drawing.Point(77, 356);
            this.labelEndHour.Name = "labelEndHour";
            this.labelEndHour.Size = new System.Drawing.Size(188, 40);
            this.labelEndHour.TabIndex = 0;
            this.labelEndHour.Text = "Giờ kết thúc:";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(77, 293);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(183, 40);
            this.labelStartHour.TabIndex = 0;
            this.labelStartHour.Text = "Giờ bắt đầu:";
            // 
            // labelReminder
            // 
            this.labelReminder.AutoSize = true;
            this.labelReminder.Location = new System.Drawing.Point(604, 218);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(132, 40);
            this.labelReminder.TabIndex = 0;
            this.labelReminder.Text = "Bộ nhắc:";
            this.labelReminder.Click += new System.EventHandler(this.labelReminder_Click);
            // 
            // listViewReminder
            // 
            this.listViewReminder.HideSelection = false;
            this.listViewReminder.Location = new System.Drawing.Point(610, 263);
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(364, 133);
            this.listViewReminder.TabIndex = 1;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Location = new System.Drawing.Point(77, 430);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(362, 40);
            this.labelParticipants.TabIndex = 0;
            this.labelParticipants.Text = "Thông tin người tham gia:";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Location = new System.Drawing.Point(84, 473);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersWidth = 72;
            this.dgvParticipants.RowTemplate.Height = 31;
            this.dgvParticipants.Size = new System.Drawing.Size(914, 210);
            this.dgvParticipants.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 718);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Location = new System.Drawing.Point(298, 101);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(99, 40);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "label1";
            // 
            // labelAppLocation
            // 
            this.labelAppLocation.AutoSize = true;
            this.labelAppLocation.Location = new System.Drawing.Point(298, 167);
            this.labelAppLocation.Name = "labelAppLocation";
            this.labelAppLocation.Size = new System.Drawing.Size(99, 40);
            this.labelAppLocation.TabIndex = 0;
            this.labelAppLocation.Text = "label1";
            // 
            // labelAppDate
            // 
            this.labelAppDate.AutoSize = true;
            this.labelAppDate.Location = new System.Drawing.Point(298, 228);
            this.labelAppDate.Name = "labelAppDate";
            this.labelAppDate.Size = new System.Drawing.Size(99, 40);
            this.labelAppDate.TabIndex = 0;
            this.labelAppDate.Text = "label1";
            // 
            // labelAppEndhour
            // 
            this.labelAppEndhour.AutoSize = true;
            this.labelAppEndhour.Location = new System.Drawing.Point(298, 356);
            this.labelAppEndhour.Name = "labelAppEndhour";
            this.labelAppEndhour.Size = new System.Drawing.Size(99, 40);
            this.labelAppEndhour.TabIndex = 0;
            this.labelAppEndhour.Text = "label1";
            // 
            // labelAppStartHour
            // 
            this.labelAppStartHour.AutoSize = true;
            this.labelAppStartHour.Location = new System.Drawing.Point(298, 293);
            this.labelAppStartHour.Name = "labelAppStartHour";
            this.labelAppStartHour.Size = new System.Drawing.Size(99, 40);
            this.labelAppStartHour.TabIndex = 0;
            this.labelAppStartHour.Text = "label1";
            // 
            // AppointmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1087, 794);
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
            this.Name = "AppointmentDetailForm";
            this.Text = "AppointmentDetailForm";
            this.Load += new System.EventHandler(this.AppointmentDetailForm_Load);
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