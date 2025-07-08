namespace TebeeLite.WinForms.Patients
{
    partial class AddAndUpdatePatient
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
            label7 = new Label();
            label8 = new Label();
            lblTitle = new Label();
            btnCancel = new Button();
            label2 = new Label();
            btnSave = new Button();
            txtFullName = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            cmbGender = new ComboBox();
            label11 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            dtpDob = new DateTimePicker();
            cmbBloodType = new ComboBox();
            txtNotes = new TextBox();
            label10 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 214);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 56;
            label7.Text = "فصيلة الدم";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 157);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 55;
            label8.Text = "تاريخ الميلاد:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(377, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 54);
            lblTitle.TabIndex = 50;
            lblTitle.Text = "اضافة مريض جديد";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(490, 443);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(788, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 46;
            label2.Text = "الاسم كامل";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(315, 443);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 44;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(577, 154);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 41;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(788, 201);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 65;
            label1.Text = "الهاتف:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(577, 198);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 64;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(788, 298);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 67;
            label3.Text = "الايمال";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(577, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 66;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "انثى" });
            cmbGender.Location = new Point(577, 241);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(169, 28);
            cmbGender.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(779, 241);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 70;
            label11.Text = "الجنس:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(788, 352);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 72;
            label4.Text = "العنوان";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(577, 349);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 71;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(106, 152);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(250, 27);
            dtpDob.TabIndex = 73;
            // 
            // cmbBloodType
            // 
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+ ", "O-" });
            cmbBloodType.Location = new Point(144, 211);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(212, 28);
            cmbBloodType.TabIndex = 74;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(106, 282);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 86);
            txtNotes.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(384, 282);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 62;
            label10.Text = "ملاحظات :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddAndUpdatePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 575);
            Controls.Add(cmbBloodType);
            Controls.Add(dtpDob);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label11);
            Controls.Add(cmbGender);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(txtNotes);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtFullName);
            Name = "AddAndUpdatePatient";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AddAnaUpdatePatient";
            Load += AddAnaUpdatePatient_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label8;
        private Label lblTitle;
        private Button btnCancel;
        private Label label2;
        private Button btnSave;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtEmail;
        private ComboBox cmbGender;
        private Label label11;
        private Label label4;
        private TextBox txtAddress;
        private DateTimePicker dtpDob;
        private ComboBox cmbBloodType;
        private TextBox txtNotes;
        private Label label10;
        private ErrorProvider errorProvider1;
    }
}