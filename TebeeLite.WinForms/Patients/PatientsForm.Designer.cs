namespace TebeeLite.WinForms.Patients
{
    partial class PatientsForm
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
            btnAdd = new Button();
            dgvPatients = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            حذفToolStripMenuItem = new ToolStripMenuItem();
            عرضToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblCountUsers = new Label();
            btnClose = new Button();
            label3 = new Label();
            cbBloodType = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            dtFilter = new DateTimePicker();
            cbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1114, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 54);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "اضافة مريض";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.ContextMenuStrip = contextMenuStrip1;
            dgvPatients.Location = new Point(27, 119);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1341, 377);
            dgvPatients.TabIndex = 4;
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
            حذفToolStripMenuItem.Click += حذفToolStripMenuItem_Click;
            // 
            // عرضToolStripMenuItem
            // 
            عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            عرضToolStripMenuItem.Size = new Size(115, 24);
            عرضToolStripMenuItem.Text = "عرض";
            عرضToolStripMenuItem.Click += عرضToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 536);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 11;
            label2.Text = "عدد المرضى:";
            // 
            // lblCountUsers
            // 
            lblCountUsers.AutoSize = true;
            lblCountUsers.Location = new Point(151, 536);
            lblCountUsers.Name = "lblCountUsers";
            lblCountUsers.Size = new Size(18, 20);
            lblCountUsers.TabIndex = 10;
            lblCountUsers.Text = "#";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1231, 519);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 9;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(589, 9);
            label3.Name = "label3";
            label3.Size = new Size(232, 54);
            label3.TabIndex = 16;
            label3.Text = "ادارة المرضى";
            // 
            // cbBloodType
            // 
            cbBloodType.FormattingEnabled = true;
            cbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+ ", "O-" });
            cbBloodType.Location = new Point(297, 85);
            cbBloodType.Name = "cbBloodType";
            cbBloodType.Size = new Size(166, 28);
            cbBloodType.TabIndex = 15;
            cbBloodType.Visible = false;
            cbBloodType.SelectedIndexChanged += cbBloodType_SelectedIndexChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "اختار العمود", "رقم المريض", "الاسم كامل", "تاريخ الميلاد", "الجنس", "الهاتف", "الايمالي", "العنوان", "فصيلة الدم", "تاريخ الانشاء", "تاريخ اخر تحديث للمريض" });
            cbFilterBy.Location = new Point(140, 84);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(151, 28);
            cbFilterBy.TabIndex = 14;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(297, 85);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(248, 27);
            txtFilterValue.TabIndex = 13;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged_1;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 84);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 12;
            label1.Text = "ابحث حسب:";
            // 
            // dtFilter
            // 
            dtFilter.Location = new Point(297, 86);
            dtFilter.Name = "dtFilter";
            dtFilter.Size = new Size(250, 27);
            dtFilter.TabIndex = 17;
            dtFilter.Visible = false;
            dtFilter.ValueChanged += dtFilter_ValueChanged;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "الكل", "ذكر", "انثى" });
            cbGender.Location = new Point(297, 85);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(128, 28);
            cbGender.TabIndex = 18;
            cbGender.Visible = false;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 593);
            Controls.Add(cbGender);
            Controls.Add(dtFilter);
            Controls.Add(label3);
            Controls.Add(cbBloodType);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblCountUsers);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(dgvPatients);
            Name = "PatientsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientsForm";
            Load += PatientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPatients;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private Label label2;
        private Label lblCountUsers;
        private Button btnClose;
        private Label label3;
        private ComboBox cbBloodType;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label label1;
        private DateTimePicker dtFilter;
        private ComboBox cbGender;
        private ToolStripMenuItem عرضToolStripMenuItem;
    }
}