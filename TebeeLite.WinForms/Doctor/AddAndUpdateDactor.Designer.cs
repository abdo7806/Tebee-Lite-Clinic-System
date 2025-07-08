namespace TebeeLite.WinForms.Doctor
{
    partial class AddAndUpdateDactor
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            btnCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtWorkingHours = new TextBox();
            txtEducation = new TextBox();
            txtLicenseNumber = new TextBox();
            txtSpecialization = new TextBox();
            nudYearsOfExperience = new NumericUpDown();
            label9 = new Label();
            txtNotes = new TextBox();
            label10 = new Label();
            chkIsActive = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudYearsOfExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(228, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 54);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "اضافة طبيب جديد";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(327, 456);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(624, 296);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 23;
            label4.Text = "تاكيد كلمة المرور";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 232);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 22;
            label3.Text = "كلمة المرور";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 177);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 21;
            label2.Text = "الاسم كامل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(624, 120);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 20;
            label1.Text = "اسم المستخدم";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(156, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 19;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(413, 293);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(195, 27);
            txtConfirmPassword.TabIndex = 17;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(413, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 16;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(413, 174);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 15;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(413, 117);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 27);
            txtUsername.TabIndex = 14;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 296);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 34;
            label5.Text = "عدد سنوات الخبرة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 232);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 33;
            label6.Text = "المؤهلات التعليمية";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 177);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 32;
            label7.Text = "رقم الترخيص:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 120);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 31;
            label8.Text = "التخصص ";
            // 
            // txtWorkingHours
            // 
            txtWorkingHours.Location = new Point(12, 345);
            txtWorkingHours.Name = "txtWorkingHours";
            txtWorkingHours.Size = new Size(195, 27);
            txtWorkingHours.TabIndex = 30;
            // 
            // txtEducation
            // 
            txtEducation.Location = new Point(12, 229);
            txtEducation.Name = "txtEducation";
            txtEducation.Size = new Size(195, 27);
            txtEducation.TabIndex = 29;
            txtEducation.Validating += txtEducation_Validating;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(12, 174);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(195, 27);
            txtLicenseNumber.TabIndex = 28;
            txtLicenseNumber.Validating += txtLicenseNumber_Validating;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(12, 117);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(195, 27);
            txtSpecialization.TabIndex = 27;
            txtSpecialization.Validating += txtSpecialization_Validating;
            // 
            // nudYearsOfExperience
            // 
            nudYearsOfExperience.Location = new Point(12, 289);
            nudYearsOfExperience.Name = "nudYearsOfExperience";
            nudYearsOfExperience.Size = new Size(150, 27);
            nudYearsOfExperience.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(228, 348);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 36;
            label9.Text = "ساعات العمل:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(12, 400);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(195, 27);
            txtNotes.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(251, 403);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 38;
            label10.Text = "ملاحظات :";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(413, 407);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(116, 24);
            chkIsActive.TabIndex = 39;
            chkIsActive.Text = "هل هوا ناشظ";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddAndUpdateDactor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 503);
            Controls.Add(chkIsActive);
            Controls.Add(label10);
            Controls.Add(txtNotes);
            Controls.Add(label9);
            Controls.Add(nudYearsOfExperience);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtWorkingHours);
            Controls.Add(txtEducation);
            Controls.Add(txtLicenseNumber);
            Controls.Add(txtSpecialization);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Name = "AddAndUpdateDactor";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AddAndUpdateDactor";
            Load += AddAndUpdateDactor_Load;
            ((System.ComponentModel.ISupportInitialize)nudYearsOfExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCancel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtWorkingHours;
        private TextBox txtEducation;
        private TextBox txtLicenseNumber;
        private TextBox txtSpecialization;
        private NumericUpDown nudYearsOfExperience;
        private Label label9;
        private TextBox txtNotes;
        private Label label10;
        private CheckBox chkIsActive;
        private ErrorProvider errorProvider1;
    }
}