using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.WinForms.Patients
{
    public partial class ctrlPatientCard : UserControl
    {
        public ctrlPatientCard()
        {
            InitializeComponent();
        }

        private int _PatientID = -1; // معرف المستخدم الذي سيتم تعديله


        public int PatientID
        {
            get { return _PatientID; }
        }
        private Patient _Patient;

        public Patient SelectedPatientInfo
        {
            get { return _Patient; }
        }


        

        //تحميل معلومات الشخص

        public void LoadPatientInfo(Patient patient)// نعرض بيانات الشخص على حسب رقمة الوطني
        {

            _Patient = patient;
            if (_Patient == null)
            {
                ResetPersonInfo();
                MessageBox.Show("لا يوجد مستخدم بهاذا الرقم = " + PatientID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }




        //   عرض البيانات
        private void _FillPersonInfo()
        {
            _PatientID = _Patient.PatientId;
            lblPatientId.Text = _Patient.PatientId.ToString();
            lblFullName.Text = _Patient.FullName;
            lblDob.Text = _Patient.Dob.ToString();
            lblEmail.Text = _Patient.Email;
            lblPhone.Text = _Patient.Phone;
            lblGender.Text = _Patient.Gender;
            lblAddress.Text = _Patient.Address;
            lblBloodType.Text = _Patient.BloodType;
            txtNotes.Text = _Patient.Notes;
        }


        // لو البيانات مش موجوده يعمل اعاده تحميل
        public void ResetPersonInfo()
        {
            _PatientID = -1;
            lblPatientId.Text = "[????]";
            lblFullName.Text = "[????]";
            lblDob.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblGender.Text = "[????]";
            lblAddress.Text = "[????]";
            lblBloodType.Text = "[????]";
            txtNotes.Text = "[????]";
        }



        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }




    }
}
