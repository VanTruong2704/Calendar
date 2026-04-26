namespace Calendar.View
{
    partial class ReminderForm
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
            this.labelReminder = new System.Windows.Forms.Label();
            this.cbbReminder = new System.Windows.Forms.ComboBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReminder
            // 
            this.labelReminder.AutoSize = true;
            this.labelReminder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReminder.Location = new System.Drawing.Point(249, 33);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(159, 51);
            this.labelReminder.TabIndex = 0;
            this.labelReminder.Text = "Bộ nhắc";
            // 
            // cbbReminder
            // 
            this.cbbReminder.FormattingEnabled = true;
            this.cbbReminder.Location = new System.Drawing.Point(75, 105);
            this.cbbReminder.Name = "cbbReminder";
            this.cbbReminder.Size = new System.Drawing.Size(367, 47);
            this.cbbReminder.TabIndex = 1;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(460, 99);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(129, 56);
            this.btnAddReminder.TabIndex = 2;
            this.btnAddReminder.Text = "Thêm ";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            // 
            // listViewReminder
            // 
            this.listViewReminder.HideSelection = false;
            this.listViewReminder.Location = new System.Drawing.Point(108, 183);
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(430, 180);
            this.listViewReminder.TabIndex = 3;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(108, 394);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(195, 56);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 56);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(677, 486);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.cbbReminder);
            this.Controls.Add(this.labelReminder);
            this.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReminder;
        private System.Windows.Forms.ComboBox cbbReminder;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}