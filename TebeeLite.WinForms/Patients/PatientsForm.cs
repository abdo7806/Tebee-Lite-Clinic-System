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

namespace TebeeLite.WinForms.Patients
{
    public partial class PatientsForm : Form
    {
        private readonly IPatientService _patientService;
        private readonly IServiceProvider _serviceProvider;

        public PatientsForm(IPatientService patientService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _patientService = patientService;
            _serviceProvider = serviceProvider;
        }

        private async void PatientsForm_Load(object sender, EventArgs e)
        {
            var patien = await _patientService.GetAllPatients();
            // مثلا عرض الأطباء في DataGridView
            dgvPatients.DataSource = patien;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddAndUpdatePatient>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // أعد تحميل المريضين
                PatientsForm_Load(null, null);
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedPatientId = (int)dgvPatients.CurrentRow.Cells[0].Value;
            var form = ActivatorUtilities.CreateInstance<AddAndUpdatePatient>(_serviceProvider, selectedPatientId);
            form.ShowDialog();
            PatientsForm_Load(null, null);
        }

        private async void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("هل أنت متأكد أنك تريد حذف معرف المريض = [" + PatientID + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (await _patientService.DeletePatient(PatientID))
                {
                    MessageBox.Show("تم حذف المريض بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PatientsForm_Load(null, null);
                }

                else
                    MessageBox.Show("لا يتم حذف المريض بسبب البيانات المرتبطة به.", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
