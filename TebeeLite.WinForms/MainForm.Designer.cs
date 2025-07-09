namespace TebeeLite.WinForms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            btnPatients = new ToolStripMenuItem();
            btnDoctors = new ToolStripMenuItem();
            btnUsers = new ToolStripMenuItem();
            btnAppointments = new ToolStripMenuItem();
            btnPayments = new ToolStripMenuItem();
            btnPrescriptions = new ToolStripMenuItem();
            btnReports = new ToolStripMenuItem();
            btnSettings = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnPatients, btnDoctors, btnUsers, btnAppointments, btnPayments, btnPrescriptions, btnReports, btnSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1362, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnPatients
            // 
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(70, 24);
            btnPatients.Text = "المرضى";
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(64, 24);
            btnDoctors.Text = "الأطباء";
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnUsers
            // 
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(104, 24);
            btnUsers.Text = "المستخدمين ";
            btnUsers.Click += btnUsers_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(75, 24);
            btnAppointments.Text = "المواعيد";
            // 
            // btnPayments
            // 
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(68, 24);
            btnPayments.Text = "الفواتير";
            // 
            // btnPrescriptions
            // 
            btnPrescriptions.Name = "btnPrescriptions";
            btnPrescriptions.Size = new Size(81, 24);
            btnPrescriptions.Text = "الوصفات";
            // 
            // btnReports
            // 
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(58, 24);
            btnReports.Text = "تقارير";
            // 
            // btnSettings
            // 
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(83, 24);
            btnSettings.Text = "الاعدادات";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 572);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "لوحة التحكم";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnPatients;
        private ToolStripMenuItem btnDoctors;
        private ToolStripMenuItem btnAppointments;
        private ToolStripMenuItem btnPayments;
        private ToolStripMenuItem btnPrescriptions;
        private ToolStripMenuItem btnUsers;
        private ToolStripMenuItem btnReports;
        private ToolStripMenuItem btnSettings;
    }
}