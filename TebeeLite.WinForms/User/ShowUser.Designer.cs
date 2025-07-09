namespace TebeeLite.WinForms.User
{
    partial class ShowUser
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
            ctrlUserCard1 = new ctrlUserCard();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.BackColor = Color.White;
            ctrlUserCard1.Location = new Point(31, 127);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.RightToLeft = RightToLeft.Yes;
            ctrlUserCard1.Size = new Size(739, 256);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(159, 31);
            label1.Name = "label1";
            label1.Size = new Size(492, 60);
            label1.TabIndex = 1;
            label1.Text = "عرض معلومات المستخدم";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(633, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 54);
            btnClose.TabIndex = 3;
            btnClose.Text = "اغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ShowUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 455);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlUserCard1);
            Name = "ShowUser";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ShowUser";
            Load += ShowUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private Label label1;
        private Button btnClose;
    }
}