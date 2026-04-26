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
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbGroup = new System.Windows.Forms.RadioButton();
            this.tbNameApp = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.cbbStartHour = new System.Windows.Forms.ComboBox();
            this.cbbEndHour = new System.Windows.Forms.ComboBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppointmentDetail
            // 
            this.labelAppointmentDetail.AutoSize = true;
            this.labelAppointmentDetail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentDetail.Location = new System.Drawing.Point(376, 29);
            this.labelAppointmentDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentDetail.Name = "labelAppointmentDetail";
            this.labelAppointmentDetail.Size = new System.Drawing.Size(309, 51);
            this.labelAppointmentDetail.TabIndex = 0;
            this.labelAppointmentDetail.Text = "Chi tiết cuộc hẹn";
            this.labelAppointmentDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAppointmentName
            // 
            this.labelAppointmentName.AutoSize = true;
            this.labelAppointmentName.Location = new System.Drawing.Point(91, 106);
            this.labelAppointmentName.Name = "labelAppointmentName";
            this.labelAppointmentName.Size = new System.Drawing.Size(198, 40);
            this.labelAppointmentName.TabIndex = 1;
            this.labelAppointmentName.Text = "Tên cuộc hẹn:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(91, 179);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(91, 40);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Vị trí:";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(87, 271);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(259, 40);
            this.labelStartHour.TabIndex = 1;
            this.labelStartHour.Text = "Thời gian bắt đầu:";
            // 
            // labelEndHour
            // 
            this.labelEndHour.AutoSize = true;
            this.labelEndHour.Location = new System.Drawing.Point(524, 268);
            this.labelEndHour.Name = "labelEndHour";
            this.labelEndHour.Size = new System.Drawing.Size(264, 40);
            this.labelEndHour.TabIndex = 1;
            this.labelEndHour.Text = "Thời gian kết thúc:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(88, 345);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(201, 40);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Kiểu cuộc hẹn";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(247, 416);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(227, 59);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(564, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(227, 59);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Font = new System.Drawing.Font("Calibri", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.Location = new System.Drawing.Point(30, 30);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(94, 41);
            this.rbSingle.TabIndex = 3;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Đơn";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbGroup
            // 
            this.rbGroup.AutoSize = true;
            this.rbGroup.Font = new System.Drawing.Font("Calibri", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGroup.Location = new System.Drawing.Point(250, 31);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(117, 41);
            this.rbGroup.TabIndex = 3;
            this.rbGroup.TabStop = true;
            this.rbGroup.Text = "Nhóm";
            this.rbGroup.UseVisualStyleBackColor = true;
            // 
            // tbNameApp
            // 
            this.tbNameApp.Location = new System.Drawing.Point(352, 106);
            this.tbNameApp.Name = "tbNameApp";
            this.tbNameApp.Size = new System.Drawing.Size(624, 47);
            this.tbNameApp.TabIndex = 4;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(352, 179);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(624, 47);
            this.tbLocation.TabIndex = 4;
            // 
            // cbbStartHour
            // 
            this.cbbStartHour.FormattingEnabled = true;
            this.cbbStartHour.Location = new System.Drawing.Point(352, 261);
            this.cbbStartHour.Name = "cbbStartHour";
            this.cbbStartHour.Size = new System.Drawing.Size(125, 47);
            this.cbbStartHour.TabIndex = 5;
            // 
            // cbbEndHour
            // 
            this.cbbEndHour.FormattingEnabled = true;
            this.cbbEndHour.Location = new System.Drawing.Point(794, 261);
            this.cbbEndHour.Name = "cbbEndHour";
            this.cbbEndHour.Size = new System.Drawing.Size(114, 47);
            this.cbbEndHour.TabIndex = 5;
            this.cbbEndHour.SelectedIndexChanged += new System.EventHandler(this.cbbEndHour_SelectedIndexChanged);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.rbGroup);
            this.groupBoxType.Controls.Add(this.rbSingle);
            this.groupBoxType.Location = new System.Drawing.Point(352, 314);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(414, 81);
            this.groupBoxType.TabIndex = 6;
            this.groupBoxType.TabStop = false;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1077, 503);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.cbbEndHour);
            this.Controls.Add(this.cbbStartHour);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAppointmentForm";
            this.Text = "AppointmentDetail";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbGroup;
        private System.Windows.Forms.TextBox tbNameApp;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.ComboBox cbbStartHour;
        private System.Windows.Forms.ComboBox cbbEndHour;
        private System.Windows.Forms.GroupBox groupBoxType;
    }
}