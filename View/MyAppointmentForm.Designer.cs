namespace Calendar.View
{
    partial class MyAppointmentForm
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
            this.labelListAppointment = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListAppointment
            // 
            this.labelListAppointment.AutoSize = true;
            this.labelListAppointment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListAppointment.Location = new System.Drawing.Point(398, 18);
            this.labelListAppointment.Name = "labelListAppointment";
            this.labelListAppointment.Size = new System.Drawing.Size(429, 51);
            this.labelListAppointment.TabIndex = 0;
            this.labelListAppointment.Text = "Danh sách các cuộc hẹn";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(51, 89);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersWidth = 72;
            this.dgvAppointment.RowTemplate.Height = 31;
            this.dgvAppointment.Size = new System.Drawing.Size(1095, 373);
            this.dgvAppointment.TabIndex = 1;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(94, 511);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(221, 56);
            this.btnSaveChange.TabIndex = 2;
            this.btnSaveChange.Text = "Lưu thay đổi";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(369, 511);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(216, 56);
            this.btnViewDetail.TabIndex = 2;
            this.btnViewDetail.Text = "Xem chi tiết";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(671, 511);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(173, 56);
            this.butDel.TabIndex = 2;
            this.butDel.Text = "Xoá";
            this.butDel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(934, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1212, 607);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.labelListAppointment);
            this.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MyAppointmentForm";
            this.Text = "MyAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListAppointment;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button btnExit;
    }
}