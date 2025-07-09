namespace TebeeLite.WinForms.Doctor
{
    partial class ShowDoctor
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
            btnClose = new Button();
            label1 = new Label();
            ctrlDoctorCard1 = new ctrlDoctorCard();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(770, 686);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 5;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(258, -1);
            label1.Name = "label1";
            label1.Size = new Size(492, 60);
            label1.TabIndex = 4;
            label1.Text = "عرض معلومات المستخدم";
            // 
            // ctrlDoctorCard1
            // 
            ctrlDoctorCard1.BackColor = Color.White;
            ctrlDoctorCard1.Location = new Point(130, 72);
            ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            ctrlDoctorCard1.RightToLeft = RightToLeft.Yes;
            ctrlDoctorCard1.Size = new Size(752, 608);
            ctrlDoctorCard1.TabIndex = 6;
            // 
            // ShowDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 756);
            Controls.Add(ctrlDoctorCard1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "ShowDoctor";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ShowDoctor";
            Load += ShowDoctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClose;
        private Label label1;
        private ctrlDoctorCard ctrlDoctorCard1;
    }
}