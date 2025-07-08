using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.WinForms.User;
using static Hotel.Global_Classes.clsGlobal;

namespace TebeeLite.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

  

        private void MainForm_Load(object sender, EventArgs e)
        {
            string role = CurrentUser.RoleName;


            // الكل يشوف Dashboard، نبدأ نحدد صلاحيات كل دور

            if (role == "Admin")
            {
                // المدير يشوف كل شيء، لا تخفي أي شيء
            }
            else if (role == "Receptionist")
            {
                btnUsers.Visible = false;
                btnDoctors.Visible = false;
                btnPrescriptions.Visible = false;
                btnPayments.Visible = false;
                btnReports.Visible = false;
                btnSettings.Visible = false;
            }
            else if (role == "Doctor")
            {
                btnUsers.Visible = false;
                btnDoctors.Visible = false;
                btnPatients.Visible = false;
                btnPayments.Visible = false;
                btnReports.Visible = false;
                btnSettings.Visible = false;
            }
            else if (role == "Accountant")
            {
                btnUsers.Visible = false;
                btnDoctors.Visible = false;
                btnPatients.Visible = false;
                btnAppointments.Visible = false;
                btnPrescriptions.Visible = false;
                btnSettings.Visible = false;
            }
            else
            {
                MessageBox.Show("الصلاحيات غير معروفة. سيتم إغلاق النظام.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<ManageUsersForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // أعد تحميل المستخدمين
               // Form1_Load(null, null);
            }
        }
    }
}
