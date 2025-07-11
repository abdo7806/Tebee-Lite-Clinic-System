namespace TebeeLite.WinForms.Doctor
{
    partial class DoctorsForm
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
            dgvDoctors = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            حذفToolStripMenuItem = new ToolStripMenuItem();
            عرضToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            cbIsActive = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            lblCountRows = new Label();
            btnClose = new Button();
            dtFilter = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1505, 86);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 54);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "اضافة طبيب";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AllowUserToOrderColumns = true;
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.ContextMenuStrip = contextMenuStrip1;
            dgvDoctors.Location = new Point(12, 149);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(1784, 412);
            dgvDoctors.TabIndex = 2;
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
            label2.Location = new Point(17, 618);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 15;
            label2.Text = "عدد الاطباء:";
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(298, 104);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(128, 28);
            cbIsActive.TabIndex = 14;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "اختار العمود", "رقم الطبيب", "رقم المستخدم", "(username) اسم المستخدم", "الاسم كامل", "التخصص", "رقم الترخيص", "سنوات الخبرة", "سعات العمل", "المؤهلات العلمية", "تاريخ الانشاء", "تاريخ اخر تحديث للطبيب", "هل هوا ناشط" });
            cbFilterBy.Location = new Point(141, 103);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(151, 28);
            cbFilterBy.TabIndex = 13;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(298, 104);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(189, 27);
            txtFilterValue.TabIndex = 12;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 103);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 11;
            label1.Text = "ابحث حسب:";
            // 
            // lblCountRows
            // 
            lblCountRows.AutoSize = true;
            lblCountRows.Location = new Point(105, 618);
            lblCountRows.Name = "lblCountRows";
            lblCountRows.Size = new Size(18, 20);
            lblCountRows.TabIndex = 10;
            lblCountRows.Text = "#";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1648, 584);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 9;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtFilter
            // 
            dtFilter.Location = new Point(298, 104);
            dtFilter.Name = "dtFilter";
            dtFilter.Size = new Size(250, 27);
            dtFilter.TabIndex = 16;
            dtFilter.Visible = false;
            dtFilter.ValueChanged += dtFilter_ValueChanged;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1808, 688);
            Controls.Add(dtFilter);
            Controls.Add(label2);
            Controls.Add(cbIsActive);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(lblCountRows);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(dgvDoctors);
            Name = "DoctorsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorsForm";
            Load += DoctorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvDoctors;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private Label label2;
        private ComboBox cbIsActive;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label label1;
        private Label lblCountRows;
        private Button btnClose;
        private DateTimePicker dtFilter;
        private ToolStripMenuItem عرضToolStripMenuItem;
    }
}