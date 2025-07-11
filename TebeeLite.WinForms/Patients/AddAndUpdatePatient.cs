using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application.Services;
using TebeeLite.Infrastructure.Models;
using Wasfaty.Application.DTOs.Patients;
using static Azure.Core.HttpHeader;

namespace TebeeLite.WinForms.Patients
{
    public partial class AddAndUpdatePatient : Form
    {
        private readonly IPatientService _patientService;

        private readonly IServiceProvider _serviceProvider;
        private int _id = -1;

        private Patient _patient;



        public AddAndUpdatePatient(IPatientService patientService,
            IServiceProvider serviceProvider, int id = -1)
        {
            InitializeComponent();
            _patientService = patientService;
            _serviceProvider = serviceProvider;
            _id = id;
        }

        public AddAndUpdatePatient()
        {
            InitializeComponent();
        }


        private async Task LoadUserData()
        {
            if (_id > -1) // وضع التعديل  
            {
                lblTitle.Text = "تحديث الطبيب";
                this.Text = "تحديث الطبيب";

                _patient = await _patientService.GetPatientById(_id);
                if (_patient != null)
                {
                    txtFullName.Text = _patient.FullName;
                    txtAddress.Text = _patient.Address;
                    txtEmail.Text = _patient.Email;
                    cmbGender.Text = _patient.Gender;
                    txtPhone.Text = _patient.Phone;
                    cmbBloodType.Text = _patient.BloodType;
                    txtNotes.Text = _patient.Notes;

                    // Fix for CS0030: Convert DateOnly? to DateTime  
                    if (_patient.Dob.HasValue)
                    {
                        dtpDob.Value = _patient.Dob.Value.ToDateTime(TimeOnly.MinValue);
                    }

                    btnSave.Text = "تحديث";
                }
                else
                {
                    MessageBox.Show("الطبيب غير موجود", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else // وضع الإضافة  
            {
                lblTitle.Text = "إضافة طبيب جديد";
                this.Text = "إضافة طبيب جديد";
                btnSave.Text = "إضافة";

                cmbGender.SelectedIndex = 0;
                cmbBloodType.SelectedIndex = 0;
            }
        }



        private void AddAnaUpdatePatient_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "لا يمكن أن يكون اسم فارغًا");
                return;
            }
            else if (txtFullName.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "يجب أن يكون الاسم على الأقل 3 أحرف");
            }
            else if (txtFullName.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "لا يمكن أن يحتوي الاسم على أرقام");
            }
            else
            {
                errorProvider1.SetError(txtFullName, null);
            };
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "لا يمكن أن يكون الهاتف فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_id == -1)
                {
                    var newPatientDto = new Patient
                    {
                        PatientId = _id,
                        FullName = txtFullName.Text,
                        Dob = DateOnly.FromDateTime(dtpDob.Value), // Fixed CS0029 by converting DateTime to DateOnly  
                        Gender = cmbGender.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        BloodType = cmbBloodType.Text,
                        Notes = txtNotes.Text,
                        CreatedAt = DateTime.Now,
                    };

                    // Assuming _patientService is the correct service to use for creating a patient  
                    var response = await _patientService.AddPatient(newPatientDto); // Fixed CS0103 by using _patientService  

                    if (response != null)
                    {
                        MessageBox.Show("تم إنشاء المريض بنجاح");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في الإضافة", "خطأ في الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var updatedPatientDto = new Patient
                    {
                        PatientId = _id,

                        FullName = txtFullName.Text,
                        Dob = DateOnly.FromDateTime(dtpDob.Value), // Fixed CS0029 by converting DateTime to DateOnly  
                        Gender = cmbGender.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,

                        Address = txtAddress.Text,
                        BloodType = cmbBloodType.Text,
                        Notes = txtNotes.Text,
                        UpdatedAt = DateTime.Now,
                    };

                    var response = await _patientService.UpdatePatient(_id, updatedPatientDto); // Fixed CS0103 by using _patientService  

                    if (response != null)
                    {
                        MessageBox.Show("تم تحديث المريض بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في التحديث", "خطأ في التحديث", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ في العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
