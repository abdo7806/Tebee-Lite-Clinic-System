namespace TebeeLite.WinForms;

partial class ManageUsersForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        dgvUsers = new DataGridView();
        contextMenuStrip1 = new ContextMenuStrip(components);
        تعديلToolStripMenuItem = new ToolStripMenuItem();
        حذفToolStripMenuItem = new ToolStripMenuItem();
        btnAdd = new Button();
        btnClose = new Button();
        lblCountUsers = new Label();
        label1 = new Label();
        txtFilterValue = new TextBox();
        cbIsActive = new ComboBox();
        label2 = new Label();
        label3 = new Label();
        cbFilterBy = new ComboBox();
        عرضToolStripMenuItem = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // dgvUsers
        // 
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.AllowUserToDeleteRows = false;
        dgvUsers.AllowUserToOrderColumns = true;
        dgvUsers.BackgroundColor = Color.White;
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvUsers.ContextMenuStrip = contextMenuStrip1;
        dgvUsers.Location = new Point(12, 136);
        dgvUsers.Name = "dgvUsers";
        dgvUsers.ReadOnly = true;
        dgvUsers.RowHeadersWidth = 51;
        dgvUsers.Size = new Size(878, 378);
        dgvUsers.TabIndex = 0;
        dgvUsers.CellContentClick += dataGridView1_CellContentClick;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem, حذفToolStripMenuItem, عرضToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.RightToLeft = RightToLeft.Yes;
        contextMenuStrip1.Size = new Size(211, 104);
        // 
        // تعديلToolStripMenuItem
        // 
        تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
        تعديلToolStripMenuItem.Size = new Size(210, 24);
        تعديلToolStripMenuItem.Text = "تعديل ";
        تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click;
        // 
        // حذفToolStripMenuItem
        // 
        حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
        حذفToolStripMenuItem.Size = new Size(210, 24);
        حذفToolStripMenuItem.Text = "حذف";
        حذفToolStripMenuItem.Click += حذفToolStripMenuItem_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(753, 76);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(137, 54);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "اضافة مستخدم";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(753, 531);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(137, 54);
        btnClose.TabIndex = 2;
        btnClose.Text = "اغلاق";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // lblCountUsers
        // 
        lblCountUsers.AutoSize = true;
        lblCountUsers.Location = new Point(136, 548);
        lblCountUsers.Name = "lblCountUsers";
        lblCountUsers.Size = new Size(18, 20);
        lblCountUsers.TabIndex = 3;
        lblCountUsers.Text = "#";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 93);
        label1.Name = "label1";
        label1.Size = new Size(84, 20);
        label1.TabIndex = 4;
        label1.Text = "ابحث حسب:";
        // 
        // txtFilterValue
        // 
        txtFilterValue.Location = new Point(274, 94);
        txtFilterValue.Name = "txtFilterValue";
        txtFilterValue.Size = new Size(189, 27);
        txtFilterValue.TabIndex = 5;
        txtFilterValue.Visible = false;
        txtFilterValue.TextChanged += txtFilterValue_TextChanged;
        txtFilterValue.KeyPress += txtFilterValue_KeyPress;
        // 
        // cbIsActive
        // 
        cbIsActive.FormattingEnabled = true;
        cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
        cbIsActive.Location = new Point(274, 94);
        cbIsActive.Name = "cbIsActive";
        cbIsActive.Size = new Size(128, 28);
        cbIsActive.TabIndex = 7;
        cbIsActive.Visible = false;
        cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 548);
        label2.Name = "label2";
        label2.Size = new Size(118, 20);
        label2.TabIndex = 8;
        label2.Text = "عدد المستخدمين:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(288, 9);
        label3.Name = "label3";
        label3.Size = new Size(306, 54);
        label3.TabIndex = 9;
        label3.Text = "ادارة المستخدمين";
        // 
        // cbFilterBy
        // 
        cbFilterBy.FormattingEnabled = true;
        cbFilterBy.Items.AddRange(new object[] { "اختار العمود", "رقم المستخدم", "(username) اسم المستخدم", "الاسم كامل", "الدور", "هل هوا ناشط" });
        cbFilterBy.Location = new Point(117, 93);
        cbFilterBy.Name = "cbFilterBy";
        cbFilterBy.Size = new Size(151, 28);
        cbFilterBy.TabIndex = 6;
        cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
        // 
        // عرضToolStripMenuItem
        // 
        عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
        عرضToolStripMenuItem.Size = new Size(210, 24);
        عرضToolStripMenuItem.Text = "عرض";
        عرضToolStripMenuItem.Click += عرضToolStripMenuItem_Click;
        // 
        // ManageUsersForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(908, 614);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(cbIsActive);
        Controls.Add(cbFilterBy);
        Controls.Add(txtFilterValue);
        Controls.Add(label1);
        Controls.Add(lblCountUsers);
        Controls.Add(btnClose);
        Controls.Add(btnAdd);
        Controls.Add(dgvUsers);
        Name = "ManageUsersForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        Text = "إدارة المستخدمين";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvUsers;
    private Button btnAdd;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem تعديلToolStripMenuItem;
    private ToolStripMenuItem حذفToolStripMenuItem;
    private Button btnClose;
    private Label lblCountUsers;
    private Label label1;
    private TextBox txtFilterValue;
    private ComboBox cbIsActive;
    private Label label2;
    private Label label3;
    private ComboBox cbFilterBy;
    private ToolStripMenuItem عرضToolStripMenuItem;
}
