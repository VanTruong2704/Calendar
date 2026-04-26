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
            this.lableCalendar.Location = new System.Drawing.Point(54, 41);
            this.lableCalendar.Name = "lableCalendar";
            this.lableCalendar.Size = new System.Drawing.Size(70, 40);
            this.lableCalendar.TabIndex = 0;
            this.lableCalendar.Text = "Lịch";
            // 
            // btnMyAppointment
            // 
            this.btnMyAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.btnMyAppointment.Location = new System.Drawing.Point(215, 32);
            this.btnMyAppointment.Name = "btnMyAppointment";
            this.btnMyAppointment.Size = new System.Drawing.Size(268, 57);
            this.btnMyAppointment.TabIndex = 2;
            this.btnMyAppointment.Text = "Cuộc hẹn của tôi";
            this.btnMyAppointment.UseVisualStyleBackColor = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(77, 100);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAppointment.Location = new System.Drawing.Point(61, 401);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(234, 51);
            this.btnAddAppointment.TabIndex = 2;
            this.btnAddAppointment.Text = "Thêm cuộc hẹn";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(368, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(550, 478);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnMyAppointment);
            this.Controls.Add(this.lableCalendar);
            this.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
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