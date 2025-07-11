namespace TebeeLite.WinForms.Appointment
{
    partial class AddAndUpdateAppointment
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
            label7 = new Label();
            lblTitle = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            dtpAppointmentTime = new DateTimePicker();
            dtpAppointmentDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cmbAppointmentStatus = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            cmbPatientName = new ComboBox();
            cmbDoctorName = new ComboBox();
            txtNotes = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 219);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 51;
            label7.Text = "حالة الحجز:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(54, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 54);
            lblTitle.TabIndex = 46;
            lblTitle.Text = "اضافة موعد جديد";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 442);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 44;
            btnSave.Text = "اضافة";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 123);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 60;
            label1.Text = "المريض:";
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new Point(111, 318);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.ShowUpDown = true;
            dtpAppointmentTime.Size = new Size(250, 27);
            dtpAppointmentTime.TabIndex = 62;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(111, 267);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 27);
            dtpAppointmentDate.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 267);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 64;
            label2.Text = "التاريخ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 315);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 65;
            label3.Text = "الوقت:";
            // 
            // cmbAppointmentStatus
            // 
            cmbAppointmentStatus.FormattingEnabled = true;
            cmbAppointmentStatus.Location = new Point(144, 219);
            cmbAppointmentStatus.Name = "cmbAppointmentStatus";
            cmbAppointmentStatus.Size = new Size(172, 28);
            cmbAppointmentStatus.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 363);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 67;
            label4.Text = "ملاحوضة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 171);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 68;
            label8.Text = "الطبيب:";
            // 
            // cmbPatientName
            // 
            cmbPatientName.FormattingEnabled = true;
            cmbPatientName.Location = new Point(144, 115);
            cmbPatientName.Name = "cmbPatientName";
            cmbPatientName.Size = new Size(172, 28);
            cmbPatientName.TabIndex = 69;
            // 
            // cmbDoctorName
            // 
            cmbDoctorName.FormattingEnabled = true;
            cmbDoctorName.Location = new Point(144, 163);
            cmbDoctorName.Name = "cmbDoctorName";
            cmbDoctorName.Size = new Size(172, 28);
            cmbDoctorName.TabIndex = 70;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(111, 363);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 73);
            txtNotes.TabIndex = 71;
            // 
            // AddAndUpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 488);
            Controls.Add(txtNotes);
            Controls.Add(cmbDoctorName);
            Controls.Add(cmbPatientName);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(cmbAppointmentStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(dtpAppointmentTime);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "AddAndUpdateAppointment";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAndUpdateAppointment";
            Load += AddAndUpdateAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsActive;
        private TextBox txtNotes;
        private NumericUpDown nudYearsOfExperience;
        private Label label7;
        private TextBox txtWorkingHours;
        private TextBox txtEducation;
        private TextBox txtLicenseNumber;
        private TextBox txtSpecialization;
        private Label lblTitle;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbDoctorName;
        private Label label1;
        private ComboBox comboBox2;
        private DateTimePicker dtpAppointmentTime;
        private DateTimePicker dtpAppointmentDate;
        private Label label2;
        private Label label3;
        private ComboBox cmbAppointmentStatus;
        private Label label4;
        private Label label8;
        private ComboBox cmbPatientName;
    }
}