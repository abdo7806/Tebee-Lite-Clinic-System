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
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application.Services;
using TebeeLite.Infrastructure.Models;
using TebeeLite.WinForms.User;

namespace TebeeLite.WinForms.Doctor
{
    public partial class DoctorsForm : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IServiceProvider _serviceProvider;
        private static List<DoctorReadDto> _dtAllDoctors;
        public DoctorsForm(IDoctorService doctorService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _serviceProvider = serviceProvider;
        }


        private async void DoctorsForm_Load(object sender, EventArgs e)
        {
            _dtAllDoctors = await _doctorService.GetAllDoctors();
            // مثلا عرض الأطباء في DataGridView
            dgvDoctors.DataSource = _dtAllDoctors;



            lblCountRows.Text = _dtAllDoctors.Count.ToString();

            cbFilterBy.SelectedIndex = 0;
            if (dgvDoctors.Rows.Count > 0)
            {
                dgvDoctors.Columns[0].HeaderText = "رقم الطبب";
                dgvDoctors.Columns[0].Width = 80;

                dgvDoctors.Columns[1].HeaderText = "رقم المستخدم";
                dgvDoctors.Columns[1].Width = 80;

                dgvDoctors.Columns[2].HeaderText = "(username) اسم المستخدم";
                dgvDoctors.Columns[2].Width = 150;

                dgvDoctors.Columns[3].HeaderText = "الاسم كامل";
                dgvDoctors.Columns[3].Width = 250;

                dgvDoctors.Columns[4].HeaderText = "التخصص";
                dgvDoctors.Columns[4].Width = 150;

                dgvDoctors.Columns[5].HeaderText = "رقم الترخيص";
                dgvDoctors.Columns[5].Width = 150;

                dgvDoctors.Columns[6].HeaderText = "سنوات الخبرة";
                dgvDoctors.Columns[6].Width = 100;

                dgvDoctors.Columns[7].HeaderText = "سعات العمل";
                dgvDoctors.Columns[7].Width = 160;

                dgvDoctors.Columns[8].HeaderText = "المؤهلات العلمية";
                dgvDoctors.Columns[8].Width = 120;

                dgvDoctors.Columns[9].HeaderText = "ملاحظة";
                dgvDoctors.Columns[9].Width = 150;

                dgvDoctors.Columns[10].HeaderText = "تاريخ الانشاء";
                dgvDoctors.Columns[10].Width = 120;


                dgvDoctors.Columns[11].HeaderText = "تاريخ اخر تحديث للطبيب";
                dgvDoctors.Columns[11].Width = 150;


                dgvDoctors.Columns[12].HeaderText = "هل هوا ناشط";
                dgvDoctors.Columns[12].Width = 120;


            }

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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "هل هوا ناشط")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;

                dtFilter.Visible = false;

            }
            else if (cbFilterBy.Text == "تاريخ الانشاء" || cbFilterBy.Text == "تاريخ اخر تحديث للطبيب")
            {

                txtFilterValue.Visible = false;
                cbIsActive.Visible = false;

                dtFilter.Visible = true;
                dtFilter.Focus();
            }
            else
            {

                txtFilterValue.Visible = (cbFilterBy.Text != "اختار العمود");
                cbIsActive.Visible = false;
                dtFilter.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "رقم الطبيب":
                    FilterColumn = "DoctorId";
                    break;
                case "رقم المستخدم":
                    FilterColumn = "UserID";
                    break;

                case "(username) اسم المستخدم":
                    FilterColumn = "Username";
                    break;
                case "الاسم كامل":
                    FilterColumn = "FullName";
                    break;
                case "التخصص":
                    FilterColumn = "Specialization";
                    break;
                case "رقم الترخيص":
                    FilterColumn = "LicenseNumber";
                    break;
                case "سنوات الخبرة":
                    FilterColumn = "YearsOfExperience";
                    break;
                case "سعات العمل":
                    FilterColumn = "WorkingHours";
                    break;
                case "المؤهلات العلمية":
                    FilterColumn = "Education";
                    break;
                default:
                    FilterColumn = "اختار العمود";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "اختار العمود")
            {

                dgvDoctors.DataSource = _dtAllDoctors;
                lblCountRows.Text = dgvDoctors.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "UserID" || FilterColumn == "DoctorId")
            {
                // تطبيق الفلترة باستخدام LINQ و Reflection

                if (FilterColumn == "UserID")
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u => u.UserId == Convert.ToInt32(txtFilterValue.Text.Trim())).ToList();
                else
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u => u.DoctorId == Convert.ToInt32(txtFilterValue.Text.Trim())).ToList();


                lblCountRows.Text = dgvDoctors.Rows.Count.ToString();

                return;
            }

            // تطبيق الفلترة باستخدام LINQ و Reflection
            List<DoctorReadDto> filteredList = _dtAllDoctors.Where(u =>
                (typeof(Patient).GetProperty(FilterColumn)?.GetValue(u, null) ?? "").ToString().ToLower().Contains(txtFilterValue.Text.Trim().ToLower())).ToList();

            dgvDoctors.DataSource = filteredList;

            lblCountRows.Text = dgvDoctors.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    dgvDoctors.DataSource = _dtAllDoctors;
                    break;
                case "Yes":
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u => u.IsActive == true).ToList(); ;

                    break;
                case "No":
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u => u.IsActive == false).ToList(); ;
                    break;
            }
            lblCountRows.Text = dgvDoctors.Rows.Count.ToString();


        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "رقم المستخدم" || cbFilterBy.Text == "رقم الطبيب")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtFilter_ValueChanged(object sender, EventArgs e)
        {
            string FilterValue = cbFilterBy.Text;

            switch (FilterValue)
            {

                case "تاريخ الانشاء":
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u =>
                    {
                        return (u.CreatedAt ?? DateTime.Now).ToString("yyyy-mm-dd")
                        == dtFilter.Value.ToString("yyyy-mm-dd");
                    }).ToList();

                    break;
                case "تاريخ اخر تحديث للطبيب":
                    dgvDoctors.DataSource = _dtAllDoctors.Where(u =>
                    {
                        return (u.UpdatedAt ?? DateTime.Now).ToString("yyyy-mm-dd")
                        == dtFilter.Value.ToString("yyyy-mm-dd");
                    }).ToList(); break;
            }
            lblCountRows.Text = dgvDoctors.Rows.Count.ToString();
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedDoctorId = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            var form = ActivatorUtilities.CreateInstance<ShowDoctor>(_serviceProvider, selectedDoctorId);
            form.ShowDialog();
            DoctorsForm_Load(null, null);
        }
    }
}
