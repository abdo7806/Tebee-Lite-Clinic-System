namespace TebeeLite.WinForms.User
{
    partial class EditUserForm
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
            label5 = new Label();
            label1 = new Label();
            btnSave = new Button();
            chkIsActive = new CheckBox();
            cmbRoles = new ComboBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(365, 54);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "تعديل المستخدم رقم:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 205);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 25;
            label5.Text = "دورة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 90);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 21;
            label1.Text = "اسم المستخدم";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 20;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(35, 259);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(116, 24);
            chkIsActive.TabIndex = 19;
            chkIsActive.Text = "هل هوا ناشظ";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(35, 205);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(151, 28);
            cmbRoles.TabIndex = 18;
            cmbRoles.SelectedIndexChanged += cmbRoles_SelectedIndexChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(35, 87);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 27);
            txtUsername.TabIndex = 14;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(35, 144);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 15;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 147);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 22;
            label2.Text = "الاسم كامل";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 404);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(cmbRoles);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Name = "EditUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCancel;
        private Label label5;
        private Label label1;
        private Button btnSave;
        private CheckBox chkIsActive;
        private ComboBox cmbRoles;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}