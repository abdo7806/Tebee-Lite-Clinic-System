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
using TebeeLite.Application.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.WinForms.Patients
{
    public partial class PatientsForm : Form
    {
        private readonly IPatientService _patientService;
        private readonly IServiceProvider _serviceProvider;
        private static List<Patient> _dtAllPatients;

        public PatientsForm(IPatientService patientService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _patientService = patientService;
            _serviceProvider = serviceProvider;
        }

        private async void PatientsForm_Load(object sender, EventArgs e)
        {
            _dtAllPatients = await _patientService.GetAllPatients();
            dgvPatients.DataSource = _dtAllPatients;


            lblCountUsers.Text = _dtAllPatients.Count.ToString();

            cbFilterBy.SelectedIndex = 0;
            if (dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "رقم المريض";
                dgvPatients.Columns[0].Width = 110;


                dgvPatients.Columns[1].HeaderText = "الاسم كامل";
                dgvPatients.Columns[1].Width = 250;

                dgvPatients.Columns[2].HeaderText = "تريخ الميلاد";
                dgvPatients.Columns[2].Width = 160;

                dgvPatients.Columns[3].HeaderText = "الجنس";
                dgvPatients.Columns[3].Width = 100;

                dgvPatients.Columns[4].HeaderText = "الهاتف";
                dgvPatients.Columns[4].Width = 150;

                dgvPatients.Columns[5].HeaderText = "الايمالي";
                dgvPatients.Columns[5].Width = 160;

                dgvPatients.Columns[6].HeaderText = "العنوان";
                dgvPatients.Columns[6].Width = 150;

                dgvPatients.Columns[7].HeaderText = "فصيلة الدم";
                dgvPatients.Columns[7].Width = 80;

                dgvPatients.Columns[9].HeaderText = "تاريخ الانشاء";
                dgvPatients.Columns[9].Width = 160;


                dgvPatients.Columns[10].HeaderText = "تاريخ اخر تحديث للمريض";
                dgvPatients.Columns[10].Width = 190;



            }

            // العثور على العمود المراد إخفاؤه
            var column = dgvPatients.Columns[8];
            var column2 = dgvPatients.Columns[11];
            var column3 = dgvPatients.Columns[12];
            if (column != null)
            {
                column.Visible = false; // إخفاء العمود
                column2.Visible = false; // إخفاء العمود
                column3.Visible = false; // إخفاء العمود
            }
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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "فصيلة الدم")
            {
                txtFilterValue.Visible = false;
                cbBloodType.Visible = true;
                cbBloodType.Focus();
                cbBloodType.SelectedIndex = 0;

                txtFilterValue.Visible = false;
                cbGender.Visible = false;

                dtFilter.Visible = false;

            }
            else if (cbFilterBy.Text == "تاريخ الانشاء" || cbFilterBy.Text == "تاريخ اخر تحديث للطبيب" || cbFilterBy.Text == "تاريخ الميلاد")
            {

                txtFilterValue.Visible = false;
                cbBloodType.Visible = false;
                cbGender.Visible = false;
                dtFilter.Visible = true;
                dtFilter.Focus();
            }
            else if (cbFilterBy.Text == "الجنس")
            {

                txtFilterValue.Visible = false;
                cbBloodType.Visible = false;
                cbGender.Visible = true;

                dtFilter.Visible = false;
                dtFilter.Focus();
            }
            else
            {

                txtFilterValue.Visible = (cbFilterBy.Text != "اختار العمود");
                cbBloodType.Visible = false;
                dtFilter.Visible = false;
                cbGender.Visible = false;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "رقم المريض":
                    FilterColumn = "PatientId";
                    break;
                case "الهاتف":
                    FilterColumn = "Phone";
                    break;
                case "الاسم كامل":
                    FilterColumn = "FullName";
                    break;
                case "الايمالي":
                    FilterColumn = "Email";
                    break;
                case "العنوان":
                    FilterColumn = "Address";
                    break;
                default:
                    FilterColumn = "اختار العمود";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "اختار العمود")
            {

                dgvPatients.DataSource = _dtAllPatients;
                lblCountUsers.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PatientId")
            {
                // تطبيق الفلترة باستخدام LINQ و Reflection


                dgvPatients.DataSource = _dtAllPatients.Where(u => u.PatientId == Convert.ToInt32(txtFilterValue.Text.Trim())).ToList();
                lblCountUsers.Text = dgvPatients.Rows.Count.ToString();

                return;
            }

            // تطبيق الفلترة باستخدام LINQ و Reflection
            List<Patient> filteredList = _dtAllPatients.Where(u =>
            (typeof(Patient).GetProperty(FilterColumn)?.GetValue(u, null) ?? "").ToString().ToLower().Contains(txtFilterValue.Text.Trim().ToLower())).ToList();

            dgvPatients.DataSource = filteredList;

            lblCountUsers.Text = dgvPatients.Rows.Count.ToString();
        }

        private void cbBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _dtAllPatients.Where(u => u.BloodType == cbBloodType.Text).ToList();
            lblCountUsers.Text = dgvPatients.Rows.Count.ToString();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text == "الكل")
            {
                dgvPatients.DataSource = _dtAllPatients;

            }
            else
            {
                dgvPatients.DataSource = _dtAllPatients.Where(u => u.Gender == cbGender.Text).ToList();

            }

            lblCountUsers.Text = dgvPatients.Rows.Count.ToString();

        }

        private void dtFilter_ValueChanged(object sender, EventArgs e)
        {
            string FilterValue = cbFilterBy.Text;

            switch (FilterValue)
            {

                case "تاريخ الميلاد":
                    dgvPatients.DataSource = _dtAllPatients.Where(u =>
                    {
                        return (u.Dob ?? DateOnly.MaxValue).ToString("yyyy-mm-dd")
                        == dtFilter.Value.ToString("yyyy-mm-dd");
                    }).ToList();

                    break;

                case "تاريخ الانشاء":
                    dgvPatients.DataSource = _dtAllPatients.Where(u =>
                    {
                        return (u.CreatedAt ?? DateTime.Now).ToString("yyyy-mm-dd")
                        == dtFilter.Value.ToString("yyyy-mm-dd");
                    }).ToList();

                    break;
                case "تاريخ اخر تحديث للمريض":
                    dgvPatients.DataSource = _dtAllPatients.Where(u =>
                    {
                        return (u.UpdatedAt ?? DateTime.Now).ToString("yyyy-mm-dd")
                        == dtFilter.Value.ToString("yyyy-mm-dd");
                    }).ToList(); break;
            }
            lblCountUsers.Text = dgvPatients.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "رقم المريض")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedPatientId = (int)dgvPatients.CurrentRow.Cells[0].Value;
            var form = ActivatorUtilities.CreateInstance<PatientShow>(_serviceProvider, selectedPatientId);
            form.ShowDialog();
            PatientsForm_Load(null, null);
        }
    }
}
