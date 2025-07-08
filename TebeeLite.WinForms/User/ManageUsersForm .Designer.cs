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
        dataGridView1 = new DataGridView();
        contextMenuStrip1 = new ContextMenuStrip(components);
        تعديلToolStripMenuItem = new ToolStripMenuItem();
        حذفToolStripMenuItem = new ToolStripMenuItem();
        btnAdd = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.ContextMenuStrip = contextMenuStrip1;
        dataGridView1.Location = new Point(42, 136);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1045, 377);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem, حذفToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.RightToLeft = RightToLeft.Yes;
        contextMenuStrip1.Size = new Size(120, 52);
        // 
        // تعديلToolStripMenuItem
        // 
        تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
        تعديلToolStripMenuItem.Size = new Size(119, 24);
        تعديلToolStripMenuItem.Text = "تعديل ";
        تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click;
        // 
        // حذفToolStripMenuItem
        // 
        حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
        حذفToolStripMenuItem.Size = new Size(119, 24);
        حذفToolStripMenuItem.Text = "حذف";
        حذفToolStripMenuItem.Click += حذفToolStripMenuItem_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(950, 76);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(137, 54);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "اضافة مستخدم";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // ManageUsersForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1132, 525);
        Controls.Add(btnAdd);
        Controls.Add(dataGridView1);
        Name = "ManageUsersForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        Text = "إدارة المستخدمين";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button btnAdd;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem تعديلToolStripMenuItem;
    private ToolStripMenuItem حذفToolStripMenuItem;
}
