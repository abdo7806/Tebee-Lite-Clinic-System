namespace TebeeLite.WinForms.User
{
    partial class AddUserForm
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
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cmbRoles = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancel = new Button();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(27, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(27, 137);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 1;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(27, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(27, 256);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(195, 27);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(27, 300);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(151, 28);
            cmbRoles.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(46, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 83);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 140);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "الاسم كامل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 195);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 259);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "تاكيد كلمة المرور";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 300);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 11;
            label5.Text = "دورة";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(201, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 54);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "اضافة مستخدم جديد";
            lblTitle.Click += lblTitle_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(cmbRoles);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Name = "AddUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "اضافة مستخدم جديد";
            Load += AddUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbRoles;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancel;
        private Label lblTitle;
        private ErrorProvider errorProvider1;
    }
}