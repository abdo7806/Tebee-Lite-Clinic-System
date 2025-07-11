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
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.WinForms.Appointment
{
    public partial class ctrlAppointmentDetails : UserControl
    {
        public ctrlAppointmentDetails()
        {
            InitializeComponent();
        }

        private int _AppointmentID = -1; // معرف المستخدم الذي سيتم تعديله

        private int _DoctorID = -1; // معرف المستخدم الذي سيتم تعديله


        public int AppointmentID
        {
            get { return _AppointmentID; }
        }
        private AppointmentDto _Appointment;

        DoctorReadDto _doctorReadDto;


        public AppointmentDto SelectedAppointmentInfo
        {
            get { return _Appointment; }
        }


        public DoctorReadDto SelectedDoctorInfo
        {
            get { return _doctorReadDto; }
        }

        //تحميل معلومات الشخص

        public void LoadAppointmentInfo(AppointmentDto appointment, DoctorReadDto doctorReadDto, Patient patient)// نعرض بيانات الشخص على حسب رقمة الوطني
        {


            _Appointment = appointment;
            _doctorReadDto = doctorReadDto;
            if (_Appointment == null)
            {
                ResetAppointmentInfo();
                MessageBox.Show("لا يوجد موعد بهاذا الرقم = " + AppointmentID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_doctorReadDto == null)
            {
                ResetAppointmentInfo();
                MessageBox.Show("لا يوجد طبيب لاهاذا الموعد بهاذا الرقم = " + AppointmentID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (patient == null)
            {
                ResetAppointmentInfo();
                MessageBox.Show("لا يوجد موعد لاهاذا المريض بهاذا الرقم = " + AppointmentID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillAppointmentInfo();
            _FillDoctorInfo();
            ctrlPatientCard1.LoadPatientInfo(patient);// اعرض بيانات الكنترول

        }




        //   عرض البيانات
        private void _FillAppointmentInfo()
        {
            _AppointmentID = _Appointment.AppointmentId;
            lblAppointmentId.Text = _Appointment.AppointmentId.ToString();
            lblAppointmentDate.Text = _Appointment.AppointmentDate;
            lblAppointmentTime.Text = _Appointment.AppointmentTime;
            lblStatusName.Text = _Appointment.StatusName;
            lblBookedByUser.Text = _Appointment.BookedByUserName.ToString();

            if(_Appointment.Diagnosis == null)
            {
                lblDiagnosis.Text = "لا يوجد تشخيص طبي";
            }
            else
            {
                lblDiagnosis.Text = _Appointment.Diagnosis;
            }
            if (_Appointment.Treatment == null)
            {
                lblTreatment.Text = "لا يوجد علاج طبي";
            }
            else
            {
                lblTreatment.Text = _Appointment.Treatment;
            }
            if (_Appointment.Diagnosis == null)
            {
                lblNotes.Text = "لا يوجد ملاحوظة طبي";
            }
            else
            {
                lblNotes.Text = _Appointment.Notes;
            }

        }


        //   عرض البيانات
        private void _FillDoctorInfo()
        {
            _DoctorID = _doctorReadDto.DoctorId;
            lblFullName.Text = _doctorReadDto.FullName;
            lblSpecialization.Text = _doctorReadDto.Specialization;
            lblLicenseNumber.Text = _doctorReadDto.LicenseNumber;
        }


        // لو البيانات مش موجوده يعمل اعاده تحميل
        public void ResetAppointmentInfo()
        {
            _AppointmentID = -1;
            lblAppointmentId.Text = "[????]";
            lblAppointmentDate.Text = "[????]";
            lblAppointmentTime.Text = "[????]";
            lblFullName.Text = "[????]";
            lblStatusName.Text = "[????]";
            lblBookedByUser.Text = "[????]";
            lblDiagnosis.Text = "[????]";
            lblTreatment.Text = "[????]";
            lblNotes.Text = "[????]";
            lblSpecialization.Text = "[????]";
            lblLicenseNumber.Text = "[????]";


            ctrlPatientCard1.ResetPersonInfo();

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
