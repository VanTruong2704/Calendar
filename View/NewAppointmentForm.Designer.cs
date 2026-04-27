namespace Calendar
{
    partial class NewAppointmentForm
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
            this.labelAppointmentDetail = new System.Windows.Forms.Label();
            this.labelAppointmentName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelEndHour = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNameApp = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.nudStartHour = new System.Windows.Forms.NumericUpDown();
            this.nudEndHour = new System.Windows.Forms.NumericUpDown();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbGroup = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointmentDetail
            // 
            this.labelAppointmentDetail.AutoSize = true;
            this.labelAppointmentDetail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentDetail.Location = new System.Drawing.Point(269, 21);
            this.labelAppointmentDetail.Name = "labelAppointmentDetail";
            this.labelAppointmentDetail.Size = new System.Drawing.Size(224, 37);
            this.labelAppointmentDetail.TabIndex = 0;
            this.labelAppointmentDetail.Text = "Chi tiết cuộc hẹn";
            this.labelAppointmentDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAppointmentName
            // 
            this.labelAppointmentName.AutoSize = true;
            this.labelAppointmentName.Location = new System.Drawing.Point(65, 76);
            this.labelAppointmentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppointmentName.Name = "labelAppointmentName";
            this.labelAppointmentName.Size = new System.Drawing.Size(148, 29);
            this.labelAppointmentName.TabIndex = 1;
            this.labelAppointmentName.Text = "Tên cuộc hẹn:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(65, 128);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 29);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Vị trí:";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(62, 194);
            this.labelStartHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(135, 29);
            this.labelStartHour.TabIndex = 1;
            this.labelStartHour.Text = "Giờ bắt đầu:";
            // 
            // labelEndHour
            // 
            this.labelEndHour.AutoSize = true;
            this.labelEndHour.Location = new System.Drawing.Point(425, 196);
            this.labelEndHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndHour.Name = "labelEndHour";
            this.labelEndHour.Size = new System.Drawing.Size(138, 29);
            this.labelEndHour.TabIndex = 1;
            this.labelEndHour.Text = "Giờ kết thúc:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(63, 246);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(150, 29);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Kiểu cuộc hẹn";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(176, 297);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(162, 42);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNameApp
            // 
            this.tbNameApp.Location = new System.Drawing.Point(251, 76);
            this.tbNameApp.Margin = new System.Windows.Forms.Padding(2);
            this.tbNameApp.Name = "tbNameApp";
            this.tbNameApp.Size = new System.Drawing.Size(447, 36);
            this.tbNameApp.TabIndex = 0;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(251, 128);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(447, 36);
            this.tbLocation.TabIndex = 1;
            // 
            // nudStartHour
            // 
            this.nudStartHour.Location = new System.Drawing.Point(251, 192);
            this.nudStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudStartHour.Name = "nudStartHour";
            this.nudStartHour.Size = new System.Drawing.Size(120, 36);
            this.nudStartHour.TabIndex = 2;
            // 
            // nudEndHour
            // 
            this.nudEndHour.Location = new System.Drawing.Point(578, 196);
            this.nudEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudEndHour.Name = "nudEndHour";
            this.nudEndHour.Size = new System.Drawing.Size(120, 36);
            this.nudEndHour.TabIndex = 3;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Font = new System.Drawing.Font("Calibri", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.Location = new System.Drawing.Point(251, 244);
            this.rbSingle.Margin = new System.Windows.Forms.Padding(2);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(72, 31);
            this.rbSingle.TabIndex = 3;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Đơn";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbGroup
            // 
            this.rbGroup.AutoSize = true;
            this.rbGroup.Font = new System.Drawing.Font("Calibri", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGroup.Location = new System.Drawing.Point(420, 244);
            this.rbGroup.Margin = new System.Windows.Forms.Padding(2);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(89, 31);
            this.rbGroup.TabIndex = 4;
            this.rbGroup.TabStop = true;
            this.rbGroup.Text = "Nhóm";
            this.rbGroup.UseVisualStyleBackColor = true;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(769, 359);
            this.Controls.Add(this.rbSingle);
            this.Controls.Add(this.rbGroup);
            this.Controls.Add(this.nudEndHour);
            this.Controls.Add(this.nudStartHour);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbNameApp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelEndHour);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelAppointmentName);
            this.Controls.Add(this.labelAppointmentDetail);
            this.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewAppointmentForm";
            this.Text = "AppointmentDetail";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentDetail;
        private System.Windows.Forms.Label labelAppointmentName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelEndHour;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNameApp;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.NumericUpDown nudStartHour;
        private System.Windows.Forms.NumericUpDown nudEndHour;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbGroup;
    }
}