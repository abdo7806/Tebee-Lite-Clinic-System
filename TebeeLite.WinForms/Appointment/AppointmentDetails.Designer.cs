namespace TebeeLite.WinForms.Appointment
{
    partial class AppointmentDetails
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
            ctrlAppointmentDetails1 = new ctrlAppointmentDetails();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlAppointmentDetails1
            // 
            ctrlAppointmentDetails1.BackColor = Color.White;
            ctrlAppointmentDetails1.Location = new Point(12, 60);
            ctrlAppointmentDetails1.Name = "ctrlAppointmentDetails1";
            ctrlAppointmentDetails1.RightToLeft = RightToLeft.Yes;
            ctrlAppointmentDetails1.Size = new Size(737, 840);
            ctrlAppointmentDetails1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(197, -3);
            label1.Name = "label1";
            label1.Size = new Size(449, 60);
            label1.TabIndex = 5;
            label1.Text = "عرض معلومات المرضى";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(3, 906);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 6;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 966);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlAppointmentDetails1);
            Name = "AppointmentDetails";
            Text = "AppointmentDetails";
            Load += AppointmentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlAppointmentDetails ctrlAppointmentDetails1;
        private Label label1;
        private Button btnClose;
    }
}