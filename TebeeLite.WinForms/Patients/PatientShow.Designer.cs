namespace TebeeLite.WinForms.Patients
{
    partial class PatientShow
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
            ctrlPatientCard1 = new ctrlPatientCard();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(627, 529);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 5;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(156, -1);
            label1.Name = "label1";
            label1.Size = new Size(449, 60);
            label1.TabIndex = 4;
            label1.Text = "عرض معلومات المرضى";
            // 
            // ctrlPatientCard1
            // 
            ctrlPatientCard1.BackColor = Color.White;
            ctrlPatientCard1.Location = new Point(30, 81);
            ctrlPatientCard1.Name = "ctrlPatientCard1";
            ctrlPatientCard1.RightToLeft = RightToLeft.Yes;
            ctrlPatientCard1.Size = new Size(734, 432);
            ctrlPatientCard1.TabIndex = 6;
            // 
            // PatientShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 613);
            Controls.Add(ctrlPatientCard1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "PatientShow";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "PatientShow";
            Load += PatientShow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private ctrlPatientCard ctrlPatientCard1;
    }
}