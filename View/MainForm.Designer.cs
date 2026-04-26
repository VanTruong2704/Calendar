namespace Calendar.View
{
    partial class MainForm
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
            this.lableCalendar = new System.Windows.Forms.Label();
            this.btnMyAppointment = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableCalendar
            // 
            this.lableCalendar.AutoSize = true;
            this.lableCalendar.Location = new System.Drawing.Point(39, 29);
            this.lableCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableCalendar.Name = "lableCalendar";
            this.lableCalendar.Size = new System.Drawing.Size(52, 29);
            this.lableCalendar.TabIndex = 0;
            this.lableCalendar.Text = "Lịch";
            // 
            // btnMyAppointment
            // 
            this.btnMyAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.btnMyAppointment.Location = new System.Drawing.Point(154, 23);
            this.btnMyAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyAppointment.Name = "btnMyAppointment";
            this.btnMyAppointment.Size = new System.Drawing.Size(191, 41);
            this.btnMyAppointment.TabIndex = 2;
            this.btnMyAppointment.Text = "Cuộc hẹn của tôi";
            this.btnMyAppointment.UseVisualStyleBackColor = false;
            this.btnMyAppointment.Click += new System.EventHandler(this.btnMyAppointment_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(55, 71);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAppointment.Location = new System.Drawing.Point(44, 286);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(167, 36);
            this.btnAddAppointment.TabIndex = 2;
            this.btnAddAppointment.Text = "Thêm cuộc hẹn";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(263, 286);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(393, 341);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnMyAppointment);
            this.Controls.Add(this.lableCalendar);
            this.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Lịch của tôi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableCalendar;
        private System.Windows.Forms.Button btnMyAppointment;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnExit;
    }
}