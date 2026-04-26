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
            this.labelReminder.Location = new System.Drawing.Point(178, 24);
            this.labelReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(115, 37);
            this.labelReminder.TabIndex = 0;
            this.labelReminder.Text = "Bộ nhắc";
            // 
            // cbbReminder
            // 
            this.cbbReminder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReminder.FormattingEnabled = true;
            this.cbbReminder.Location = new System.Drawing.Point(54, 75);
            this.cbbReminder.Margin = new System.Windows.Forms.Padding(2);
            this.cbbReminder.Name = "cbbReminder";
            this.cbbReminder.Size = new System.Drawing.Size(263, 36);
            this.cbbReminder.TabIndex = 1;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(329, 71);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(92, 40);
            this.btnAddReminder.TabIndex = 2;
            this.btnAddReminder.Text = "Thêm ";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // listViewReminder
            // 
            this.listViewReminder.HideSelection = false;
            this.listViewReminder.Location = new System.Drawing.Point(54, 131);
            this.listViewReminder.Margin = new System.Windows.Forms.Padding(2);
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(367, 130);
            this.listViewReminder.TabIndex = 3;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            this.listViewReminder.View = System.Windows.Forms.View.Details;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(77, 281);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(139, 40);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 281);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 347);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.cbbReminder);
            this.Controls.Add(this.labelReminder);
            this.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReminderForm";
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