namespace TebeeLite.WinForms.Appointment
{
    partial class AppointmentsForm
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
            label3 = new Label();
            label2 = new Label();
            lblCountUsers = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            dgvAppointments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            حذفToolStripMenuItem = new ToolStripMenuItem();
            عرضToolStripMenuItem = new ToolStripMenuItem();
            cmbStatus = new ComboBox();
            txtPatientName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbDoctor = new ComboBox();
            label8 = new Label();
            dtpFrom = new DateTimePicker();
            label9 = new Label();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            chkByDate = new CheckBox();
            gbFilterByDate = new GroupBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            cmbDoctor2 = new ComboBox();
            cmbStatus2 = new ComboBox();
            dtFilter = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            gbFilterByDate.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(776, 24);
            label3.Name = "label3";
            label3.Size = new Size(240, 54);
            label3.TabIndex = 22;
            label3.Text = "ادارة المواعيد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 570);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 21;
            label2.Text = "عدد المواعيد";
            // 
            // lblCountUsers
            // 
            lblCountUsers.AutoSize = true;
            lblCountUsers.Location = new Point(152, 570);
            lblCountUsers.Name = "lblCountUsers";
            lblCountUsers.Size = new Size(18, 20);
            lblCountUsers.TabIndex = 20;
            lblCountUsers.Text = "#";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1248, 553);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 19;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1207, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 54);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "اضافة موعد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.ContextMenuStrip = contextMenuStrip1;
            dgvAppointments.Location = new Point(44, 275);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(1341, 272);
            dgvAppointments.TabIndex = 17;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem, حذفToolStripMenuItem, عرضToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(116, 76);
            // 
            // تعديلToolStripMenuItem
            // 
            تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            تعديلToolStripMenuItem.Size = new Size(115, 24);
            تعديلToolStripMenuItem.Text = "تعديل";
            تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click;
            // 
            // حذفToolStripMenuItem
            // 
            حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            حذفToolStripMenuItem.Size = new Size(115, 24);
            حذفToolStripMenuItem.Text = "حذف";
            // 
            // عرضToolStripMenuItem
            // 
            عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            عرضToolStripMenuItem.Size = new Size(115, 24);
            عرضToolStripMenuItem.Text = "عرض";
            عرضToolStripMenuItem.Click += عرضToolStripMenuItem_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbStatus.Location = new Point(443, 136);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(189, 28);
            cmbStatus.TabIndex = 26;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(443, 26);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(189, 27);
            txtPatientName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(799, 197);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 23;
            label1.Text = "ابحث حسب:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 29);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 28;
            label4.Text = "اسم المريض:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 86);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 29;
            label5.Text = "اسم الطبيب:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 136);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 31;
            label6.Text = "الحالة:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbDoctor.Location = new Point(443, 83);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(189, 28);
            cmbDoctor.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 31);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 35;
            label8.Text = "من:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(6, 26);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 89);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 37;
            label9.Text = "إلى:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(6, 84);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 36;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(29, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 35);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1361, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 54);
            btnRefresh.TabIndex = 39;
            btnRefresh.Text = "اعادة تحميل";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkByDate);
            groupBox1.Controls.Add(gbFilterByDate);
            groupBox1.Controls.Add(txtPatientName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbDoctor);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 227);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "بحث متقدم";
            // 
            // chkByDate
            // 
            chkByDate.AutoSize = true;
            chkByDate.Location = new Point(29, 12);
            chkByDate.Name = "chkByDate";
            chkByDate.Size = new Size(165, 24);
            chkByDate.TabIndex = 39;
            chkByDate.Text = "بحث حسب فترة زمنية";
            chkByDate.UseVisualStyleBackColor = true;
            chkByDate.CheckedChanged += chkByDate_CheckedChanged;
            // 
            // gbFilterByDate
            // 
            gbFilterByDate.Controls.Add(dtpFrom);
            gbFilterByDate.Controls.Add(label8);
            gbFilterByDate.Controls.Add(label9);
            gbFilterByDate.Controls.Add(dtpTo);
            gbFilterByDate.Enabled = false;
            gbFilterByDate.Location = new Point(31, 39);
            gbFilterByDate.Name = "gbFilterByDate";
            gbFilterByDate.Size = new Size(347, 141);
            gbFilterByDate.TabIndex = 33;
            gbFilterByDate.TabStop = false;
            gbFilterByDate.Text = "حسب فترة زمنية";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "اختار العمود", "رقم الموعد", "المريض", "الطبيب", "الموظف المسجل", "التاريخ", "الحالة" });
            cbFilterBy.Location = new Point(889, 197);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(151, 28);
            cbFilterBy.TabIndex = 42;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(1046, 198);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(189, 27);
            txtFilterValue.TabIndex = 41;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cmbDoctor2
            // 
            cmbDoctor2.FormattingEnabled = true;
            cmbDoctor2.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbDoctor2.Location = new Point(960, 119);
            cmbDoctor2.Name = "cmbDoctor2";
            cmbDoctor2.Size = new Size(189, 28);
            cmbDoctor2.TabIndex = 39;
            cmbDoctor2.Visible = false;
            // 
            // cmbStatus2
            // 
            cmbStatus2.FormattingEnabled = true;
            cmbStatus2.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbStatus2.Location = new Point(960, 163);
            cmbStatus2.Name = "cmbStatus2";
            cmbStatus2.Size = new Size(189, 28);
            cmbStatus2.TabIndex = 39;
            cmbStatus2.Visible = false;
            // 
            // dtFilter
            // 
            dtFilter.Location = new Point(1036, 231);
            dtFilter.Name = "dtFilter";
            dtFilter.Size = new Size(250, 27);
            dtFilter.TabIndex = 38;
            dtFilter.Visible = false;
            dtFilter.ValueChanged += dtFilter_ValueChanged;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 634);
            Controls.Add(dtFilter);
            Controls.Add(cmbStatus2);
            Controls.Add(cmbDoctor2);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(groupBox1);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCountUsers);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(dgvAppointments);
            Name = "AppointmentsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AppointmentsForm";
            Load += AppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFilterByDate.ResumeLayout(false);
            gbFilterByDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label lblCountUsers;
        private Button btnClose;
        private Button btnAdd;
        private DataGridView dgvAppointments;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private ToolStripMenuItem عرضToolStripMenuItem;
        private ComboBox cmbStatus;
        private TextBox txtPatientName;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbDoctor;
        private Label label8;
        private DateTimePicker dtpFrom;
        private Label label9;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private GroupBox gbFilterByDate;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private ComboBox cmbDoctor2;
        private ComboBox cmbStatus2;
        private DateTimePicker dtFilter;
        private CheckBox chkByDate;
    }
}