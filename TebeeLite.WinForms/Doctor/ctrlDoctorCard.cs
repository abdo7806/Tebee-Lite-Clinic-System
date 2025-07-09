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

namespace TebeeLite.WinForms.Doctor
{
    public partial class ctrlDoctorCard : UserControl
    {
        public ctrlDoctorCard()
        {
            InitializeComponent();
        }

        private int _DoctorID = -1; // معرف المستخدم الذي سيتم تعديله


        public int DoctorID
        {
            get { return _DoctorID; }
        }
        private DoctorReadDto _Doctor;

        public DoctorReadDto SelectedDoctorInfo
        {
            get { return _Doctor; }
        }



        //تحميل معلومات الشخص

        public void LoadDoctorInfo(DoctorReadDto doctor)// نعرض بيانات الشخص على حسب رقمة الوطني
        {

            _Doctor = doctor;
            if (_Doctor == null)
            {
                ResetPersonInfo();
                MessageBox.Show("لا يوجد مستخدم بهاذا الرقم = " + DoctorID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserReadDto user = new UserReadDto 
            {
                UserId = _Doctor.UserId,
                Username = _Doctor.Username,
                FullName = _Doctor.FullName,
                RoleName = "طبيب",
                IsActive = _Doctor.IsActive,
            };

            ctrlUserCard1.LoadUserInfo(user);

            _FillPersonInfo();
        }




        //   عرض البيانات
        private void _FillPersonInfo()
        {
            _DoctorID = _Doctor.DoctorId;
            lblDoctorID.Text = _Doctor.DoctorId.ToString();
            lblSpecialization.Text = _Doctor.Specialization;
            lblLicenseNumber.Text = _Doctor.LicenseNumber;
            lblYearsOfExperience.Text = _Doctor.YearsOfExperience.ToString();
            lblWorkingHours.Text = _Doctor.WorkingHours;
            lblEducation.Text = _Doctor.Education;
            txtNotes.Text = _Doctor.Notes;


        }


        // لو البيانات مش موجوده يعمل اعاده تحميل
        public void ResetPersonInfo()
        {
            _DoctorID = -1;
            lblDoctorID.Text = "[????]";
            lblSpecialization.Text = "[????]";
            lblLicenseNumber.Text = "[????]";
            lblYearsOfExperience.Text = "[????]";
            lblWorkingHours.Text = "[????]";
            lblEducation.Text = "[????]";
            txtNotes.Text = "";

        }

    }
}
