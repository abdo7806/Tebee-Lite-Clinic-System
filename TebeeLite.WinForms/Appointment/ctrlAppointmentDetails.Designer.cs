namespace TebeeLite.WinForms.Appointment
{
    partial class ctrlAppointmentDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookedByUser = new Label();
            lblStatusName = new Label();
            lblAppointmentTime = new Label();
            lblAppointmentDate = new Label();
            lblAppointmentId = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ctrlPatientCard1 = new Patients.ctrlPatientCard();
            groupBox2 = new GroupBox();
            lblFullName = new Label();
            label8 = new Label();
            lblLicenseNumber = new Label();
            lblSpecialization = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            lblNotes = new Label();
            lblTreatment = new Label();
            label11 = new Label();
            label12 = new Label();
            lblDiagnosis = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookedByUser
            // 
            lblBookedByUser.AutoSize = true;
            lblBookedByUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookedByUser.Location = new Point(75, 74);
            lblBookedByUser.Name = "lblBookedByUser";
            lblBookedByUser.Size = new Size(62, 28);
            lblBookedByUser.TabIndex = 36;
            lblBookedByUser.Text = "[????]";
            // 
            // lblStatusName
            // 
            lblStatusName.AutoSize = true;
            lblStatusName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusName.Location = new Point(75, 27);
            lblStatusName.Name = "lblStatusName";
            lblStatusName.Size = new Size(62, 28);
            lblStatusName.TabIndex = 35;
            lblStatusName.Text = "[????]";
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentTime.Location = new Point(485, 113);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(62, 28);
            lblAppointmentTime.TabIndex = 34;
            lblAppointmentTime.Text = "[????]";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentDate.Location = new Point(485, 74);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(62, 28);
            lblAppointmentDate.TabIndex = 33;
            lblAppointmentDate.Text = "[????]";
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentId.ForeColor = Color.Red;
            lblAppointmentId.Location = new Point(485, 27);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(62, 28);
            lblAppointmentId.TabIndex = 32;
            lblAppointmentId.Text = "[????]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(181, 74);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 31;
            label5.Text = "أنشئ بواسطة:\t";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(197, 27);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 30;
            label4.Text = "الحالة:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 113);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 29;
            label3.Text = "الوقت:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(591, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 28;
            label2.Text = "التاريخ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 27;
            label1.Text = "رقم الموعد:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBookedByUser);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblAppointmentTime);
            groupBox1.Controls.Add(lblStatusName);
            groupBox1.Controls.Add(lblAppointmentDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblAppointmentId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 154);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الموعد الأساسية";
            // 
            // ctrlPatientCard1
            // 
            ctrlPatientCard1.BackColor = Color.White;
            ctrlPatientCard1.Location = new Point(0, 313);
            ctrlPatientCard1.Name = "ctrlPatientCard1";
            ctrlPatientCard1.RightToLeft = RightToLeft.Yes;
            ctrlPatientCard1.Size = new Size(731, 430);
            ctrlPatientCard1.TabIndex = 38;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLicenseNumber);
            groupBox2.Controls.Add(lblSpecialization);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblFullName);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 740);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(728, 90);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "بيانات الطبيب";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(530, 37);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(62, 28);
            lblFullName.TabIndex = 38;
            lblFullName.Text = "[????]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(598, 37);
            label8.Name = "label8";
            label8.Size = new Size(109, 28);
            label8.TabIndex = 37;
            label8.Text = "الاسم كامل:";
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseNumber.Location = new Point(28, 37);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(62, 28);
            lblLicenseNumber.TabIndex = 42;
            lblLicenseNumber.Text = "[????]";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialization.Location = new Point(303, 37);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(62, 28);
            lblSpecialization.TabIndex = 41;
            lblSpecialization.Text = "[????]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(142, 37);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 40;
            label6.Text = "رقم الترخيص:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(383, 37);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 39;
            label7.Text = "التخصص:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblNotes);
            groupBox3.Controls.Add(lblTreatment);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lblDiagnosis);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 160);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(719, 157);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "التشخيص والعلاج والملاحظات";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(439, 113);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(62, 28);
            lblNotes.TabIndex = 42;
            lblNotes.Text = "[????]";
            // 
            // lblTreatment
            // 
            lblTreatment.AutoSize = true;
            lblTreatment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTreatment.Location = new Point(439, 76);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new Size(62, 28);
            lblTreatment.TabIndex = 41;
            lblTreatment.Text = "[????]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(573, 113);
            label11.Name = "label11";
            label11.Size = new Size(105, 28);
            label11.TabIndex = 40;
            label11.Text = "الملاحظات:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(598, 76);
            label12.Name = "label12";
            label12.Size = new Size(65, 28);
            label12.TabIndex = 39;
            label12.Text = "العلاج:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosis.Location = new Point(439, 37);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(62, 28);
            lblDiagnosis.TabIndex = 38;
            lblDiagnosis.Text = "[????]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(598, 37);
            label14.Name = "label14";
            label14.Size = new Size(99, 28);
            label14.TabIndex = 37;
            label14.Text = "التشخيص:";
            // 
            // ctrlAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(ctrlPatientCard1);
            Controls.Add(groupBox1);
            Name = "ctrlAppointmentDetails";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(734, 842);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblBookedByUser;
        private Label lblStatusName;
        private Label lblAppointmentTime;
        private Label lblAppointmentDate;
        private Label lblAppointmentId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Patients.ctrlPatientCard ctrlPatientCard1;
        private GroupBox groupBox2;
        private Label lblFullName;
        private Label label8;
        private Label lblLicenseNumber;
        private Label lblSpecialization;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Label lblNotes;
        private Label lblTreatment;
        private Label label11;
        private Label label12;
        private Label lblDiagnosis;
        private Label label14;
    }
}
