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
using TebeeLite.Application;
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application.Services;
using TebeeLite.Infrastructure.Models;
using TebeeLite.WinForms.Doctor;
using TebeeLite.WinForms.User;
using System.Globalization;

namespace TebeeLite.WinForms.Appointment
{
    public partial class AppointmentsForm : Form
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IServiceProvider _serviceProvider;
        private BindingList<AppointmentDto> _appointmentsList;
        private readonly List<int> _hiddenColumns = new List<int> { 6, 7, 8, 9, 10 };

        private readonly IDoctorService _doctorService;
        private readonly IAppointmentStateService _appointmentStateService;

        public AppointmentsForm(IAppointmentService appointmentService, IDoctorService doctorService, IAppointmentStateService appointmentStateService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _appointmentService = appointmentService;
            _serviceProvider = serviceProvider;
            _doctorService = doctorService;
            _appointmentStateService = appointmentStateService;


        }
        private void ConfigureDataGridView()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            var columns = new[]
            {
                new { Index = 0, Header = "رقم الموعد", Width = 110, DataPropertyName = "AppointmentId" },
                new { Index = 1, Header = "المريض", Width = 250, DataPropertyName = "PatientName" },
                new { Index = 2, Header = "الطبيب", Width = 250, DataPropertyName = "DoctorName" },
                new { Index = 3, Header = "الموظف المسجل", Width = 250, DataPropertyName = "BookedByUserName" },
                new { Index = 4, Header = "التاريخ", Width = 160, DataPropertyName = "AppointmentDate" },
                new { Index = 5, Header = "الوقت", Width = 100, DataPropertyName = "AppointmentTime" },
                new { Index = 11, Header = "الحالة", Width = 150, DataPropertyName = "StatusName" }
            };

            foreach (var col in columns)
            {
                if (dgvAppointments.Columns.Count > col.Index)
                {
                    dgvAppointments.Columns[col.Index].HeaderText = col.Header;
                    dgvAppointments.Columns[col.Index].Width = col.Width;
                    dgvAppointments.Columns[col.Index].DataPropertyName = col.DataPropertyName;
                }
            }

            foreach (var colIndex in _hiddenColumns)
            {
                if (dgvAppointments.Columns.Count > colIndex)
                {
                    dgvAppointments.Columns[colIndex].Visible = false;
                }
            }
        }
        private void ApplyDataGridViewStyling()
        {
            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.DataBoundItem is AppointmentDto appointment)
                {
                    if (appointment.StatusName == "ملغي")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else if (appointment.StatusName == "مكتمل")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    }
                }
            }

            if (dgvAppointments.Columns["AppointmentDate"] != null)
            {
                dgvAppointments.Columns["AppointmentDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            }

            if (dgvAppointments.Columns["AppointmentTime"] != null)
            {
                dgvAppointments.Columns["AppointmentTime"].DefaultCellStyle.Format = "hh:mm tt";
            }
        }
        private void UpdateAppointmentsCount()
        {
            lblCountUsers.Text = _appointmentsList?.Count.ToString() ?? "0";
        }

        private void ShowErrorMessage(string title, Exception ex)
        {
            MessageBox.Show($"{title}: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void AppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private async Task LoadDoctors()
        {

            cmbDoctor2.SelectedIndexChanged -= cmbDoctor2_SelectedIndexChanged;


            var doctors = await _doctorService.GetAllDoctors();

            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";

            cmbDoctor.Text = "الكل";


            cmbDoctor2.DataSource = doctors;
            cmbDoctor2.DisplayMember = "FullName";
            cmbDoctor2.ValueMember = "DoctorId";

            cmbDoctor2.Text = "الكل";

            cmbDoctor2.SelectedIndexChanged += cmbDoctor2_SelectedIndexChanged;

        }

        private async Task LoadAppointmentState()
        {
            cmbStatus2.SelectedIndexChanged -= cmbStatus2_SelectedIndexChanged;

            var state = await _appointmentStateService.GetAllIAppointmentStatus();

            cmbStatus.DataSource = state;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";
            cmbStatus.Text = "الكل";

            cmbStatus2.DataSource = state;
            cmbStatus2.DisplayMember = "StatusName";
            cmbStatus2.ValueMember = "StatusId";
            cmbStatus2.Text = "الكل";


            cmbStatus2.SelectedIndexChanged += cmbStatus2_SelectedIndexChanged;
        }

        private async Task LoadAppointments()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // btnRefresh.Enabled = false;

                var appointments = await _appointmentService.GetAllAppointments();
                _appointmentsList = new BindingList<AppointmentDto>(appointments.ToList());
                dgvAppointments.DataSource = _appointmentsList;
                ConfigureDataGridView();

                UpdateAppointmentsCount();
                ApplyDataGridViewStyling();

                await LoadDoctors();
                await LoadAppointmentState();


                cbFilterBy.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ShowErrorMessage("حدث خطأ أثناء تحميل المواعيد", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
                //  btnRefresh.Enabled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _serviceProvider.GetRequiredService<AddAndUpdateAppointment>();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // إضافة الموعد الجديد يدوياً بدلاً من إعادة التحميل الكامل
                    var newAppointment = form.NewAppointment;
                    if (newAppointment != null)
                    {
                        _appointmentsList.Add(newAppointment);
                        UpdateAppointmentsCount();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("حدث خطأ أثناء إضافة موعد جديد", ex);
            }


        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            try
            {
                int selectedAppointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
                if (selectedAppointmentId == 0) return;
                var form = ActivatorUtilities.CreateInstance<AddAndUpdateAppointment>(_serviceProvider, selectedAppointmentId);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // تحديث السجل المعدل مباشرة
                    var updatedAppointment = form.UpdatedAppointment;
                    if (updatedAppointment != null)
                    {
                        var index = _appointmentsList.IndexOf(_appointmentsList.First(a => a.AppointmentId == updatedAppointment.AppointmentId));
                        if (index >= 0)
                        {
                            _appointmentsList[index] = updatedAppointment;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("حدث خطأ أثناء تعديل الموعد", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedAppointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            var form = ActivatorUtilities.CreateInstance<AppointmentDetails>(_serviceProvider, selectedAppointmentId);
            form.ShowDialog();
            AppointmentsForm_Load(null, null);
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var appointments =  await _appointmentService.GetAllAppointments();

                List<AppointmentDto> filtered = appointments.ToList();

                // Filter by patient name  
                if (!string.IsNullOrWhiteSpace(txtPatientName.Text))
                {
                    filtered = filtered.Where(a => a.PatientName != null &&
                        a.PatientName.Contains(txtPatientName.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (cmbDoctor.Text != "الكل")
                {
                    // Filter by doctor  
                    if (cmbDoctor.SelectedItem is DoctorReadDto selectedDoctor)
                    {

                        filtered = filtered.Where(a => a.DoctorId == selectedDoctor.DoctorId).ToList();
                    }
                }

                if (cmbStatus.Text != "الكل")
                {

                    // Filter by status  
                    if (cmbStatus.SelectedItem is AppointmentStatus selectedStatus)
                    {
                        filtered = filtered.Where(a => a.StatusName == selectedStatus.StatusName).ToList();
                    }

                }

                // Filter by date (if enabled)  
                if (chkByDate.Checked)
                {
                    DateTime from = dtpFrom.Value.Date;
                    DateTime to = dtpTo.Value.Date;

                    filtered = filtered.Where(a =>
                        a.AppointmentDateTime.Date >= from &&
                        a.AppointmentDateTime.Date <= to
                    ).ToList();
                }


                // Update the grid  
                _appointmentsList = new BindingList<AppointmentDto>(filtered.ToList());
                dgvAppointments.DataSource = _appointmentsList;


                ApplyDataGridViewStyling();
                UpdateAppointmentsCount();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("حدث خطأ أثناء البحث", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadAppointments();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "الطبيب")
            {
                txtFilterValue.Visible = false;
                cmbDoctor2.Visible = true;
                cmbDoctor2.Focus();
                //  cmbDoctor2.SelectedIndex = 0;

                txtFilterValue.Visible = false;
                cmbStatus2.Visible = false;

                dtFilter.Visible = false;

            }
            else if (cbFilterBy.Text == "التاريخ")
            {

                txtFilterValue.Visible = false;
                cmbDoctor2.Visible = false;
                cmbStatus2.Visible = false;
                dtFilter.Visible = true;
                dtFilter.Focus();
            }
            else if (cbFilterBy.Text == "الحالة")
            {

                txtFilterValue.Visible = false;
                cmbStatus2.Visible = true;
                cmbDoctor2.Visible = false;

                dtFilter.Visible = false;
                cmbStatus2.Focus();
            }
            else
            {

                txtFilterValue.Visible = (cbFilterBy.Text != "اختار العمود");
                dtFilter.Visible = false;
                cmbDoctor2.Visible = false;
                cmbStatus2.Visible = false;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();

                dgvAppointments.DataSource = _appointmentsList;
                ApplyDataGridViewStyling();
                UpdateAppointmentsCount();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "رقم الموعد":
                    FilterColumn = "AppointmentId";
                    break;
                case "المريض":
                    FilterColumn = "PatientName";
                    break;
                case "الموظف المسجل":
                    FilterColumn = "BookedByUserName";
                    break;
                default:
                    FilterColumn = "اختار العمود";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "اختار العمود")
            {

                dgvAppointments.DataSource = _appointmentsList;
                ApplyDataGridViewStyling();
                UpdateAppointmentsCount(); return;
            }

            if (FilterColumn == "AppointmentId")
            {
                // تطبيق الفلترة باستخدام LINQ و Reflection


                dgvAppointments.DataSource = _appointmentsList.Where(u => u.AppointmentId == Convert.ToInt32(txtFilterValue.Text.Trim())).ToList();
                ApplyDataGridViewStyling();
                UpdateAppointmentsCount();
                return;
            }

     
            // Update the grid  
            //  _appointmentsList = new BindingList<AppointmentDto>(filteredList.ToList());
            dgvAppointments.DataSource = _appointmentsList.Where(u =>
            (typeof(AppointmentDto).GetProperty(FilterColumn)?.GetValue(u, null) ?? "").ToString().ToLower().Contains(txtFilterValue.Text.Trim().ToLower())).ToList();
            ;


            ApplyDataGridViewStyling();
            UpdateAppointmentsCount();


            //  dgvAppointments.DataSource = filteredList;

            // lblCountUsers.Text = dgvAppointments.Rows.Count.ToString();
        }

        private void chkByDate_CheckedChanged(object sender, EventArgs e)
        {
            gbFilterByDate.Enabled = chkByDate.Checked;
        }

        private void cmbDoctor2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.Text != "اختار العمود")
            {
                if (cmbDoctor2.Text != "الكل")
                {
                    // Filter by doctor  
                    if (cmbDoctor2.SelectedItem is DoctorReadDto selectedDoctor)
                    {

                        dgvAppointments.DataSource = _appointmentsList.Where(a => a.DoctorId == selectedDoctor.DoctorId).ToList();
                    }
                }

            }

            ApplyDataGridViewStyling();
            UpdateAppointmentsCount();
        }

        private void cmbStatus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text != "اختار العمود")
            {
                if (cmbStatus2.Text != "الكل")
                {

                    // Filter by status  
                    if (cmbStatus2.SelectedItem is AppointmentStatus selectedStatus)
                    {
                        dgvAppointments.DataSource = _appointmentsList.Where(a => a.StatusName == selectedStatus.StatusName).ToList();
                    }

                }
            }
            ApplyDataGridViewStyling();
            UpdateAppointmentsCount();
        }

        private void dtFilter_ValueChanged(object sender, EventArgs e)
        {
            List<AppointmentDto> filtered = _appointmentsList.ToList();

            filtered = filtered.Where(a =>
                a.AppointmentDateTime.Date == dtFilter.Value.Date
            ).ToList();



            // Update the grid  
            _appointmentsList = new BindingList<AppointmentDto>(filtered.ToList());

            dgvAppointments.DataSource = _appointmentsList;

            ApplyDataGridViewStyling();
            UpdateAppointmentsCount();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "رقم الموعد")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
