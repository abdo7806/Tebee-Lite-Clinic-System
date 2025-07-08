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
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application.Services;
using TebeeLite.WinForms.User;

namespace TebeeLite.WinForms.Doctor
{
    public partial class DoctorsForm : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IServiceProvider _serviceProvider;

        public DoctorsForm(IDoctorService doctorService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _serviceProvider = serviceProvider;
        }


        private async void DoctorsForm_Load(object sender, EventArgs e)
        {
            var doctors = await _doctorService.GetAllDoctors();
            // مثلا عرض الأطباء في DataGridView
            dgvDoctors.DataSource = doctors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddAndUpdateDactor>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // أعد تحميل الطبيبين
                DoctorsForm_Load(null, null);
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedDoctorId = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            var form = ActivatorUtilities.CreateInstance<AddAndUpdateDactor>(_serviceProvider, selectedDoctorId);
            form.ShowDialog();
            DoctorsForm_Load(null, null);
        }

        private async void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("هل أنت متأكد أنك تريد حذف معرف الطبيب = [" + DoctorID + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (await _doctorService.DeleteDoctor(DoctorID))
                {
                    MessageBox.Show("تم حذف الطبيب بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DoctorsForm_Load(null, null);
                }

                else
                    MessageBox.Show("لا يتم حذف الطبيب بسبب البيانات المرتبطة به.", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }
    }
}
