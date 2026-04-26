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
            this.labelListAppointment.Location = new System.Drawing.Point(284, 13);
            this.labelListAppointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListAppointment.Name = "labelListAppointment";
            this.labelListAppointment.Size = new System.Drawing.Size(309, 37);
            this.labelListAppointment.TabIndex = 0;
            this.labelListAppointment.Text = "Danh sách các cuộc hẹn";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(36, 64);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.RowHeadersWidth = 72;
            this.dgvAppointment.RowTemplate.Height = 31;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(782, 266);
            this.dgvAppointment.TabIndex = 1;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(117, 365);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(154, 40);
            this.btnViewDetail.TabIndex = 2;
            this.btnViewDetail.Text = "Xem chi tiết";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(372, 365);
            this.butDel.Margin = new System.Windows.Forms.Padding(2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(124, 40);
            this.butDel.TabIndex = 2;
            this.butDel.Text = "Xoá";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(608, 365);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(866, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.labelListAppointment);
            this.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyAppointmentForm";
            this.Text = "MyAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListAppointment;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button btnExit;
    }
}