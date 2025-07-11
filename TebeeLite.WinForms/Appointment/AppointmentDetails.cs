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

namespace TebeeLite.WinForms.Appointment
{
    public partial class AppointmentDetails : Form
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;


        private int _appointmentId = -1;

        public AppointmentDetails(IAppointmentService appointmentService, IPatientService patientService, IDoctorService doctorService,  int appointmentId)
        {
            InitializeComponent();
            _patientService = patientService;
            _appointmentService = appointmentService;
            _doctorService = doctorService;
            _appointmentId = appointmentId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AppointmentDetails_Load(object sender, EventArgs e)
        {
            AppointmentDto appointment = await _appointmentService.GetAppointmentById(_appointmentId);

            if(appointment == null)
            {
                MessageBox.Show("لم يتم العثور اعلى بيانات الموعد!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DoctorReadDto doctorReadDto = await _doctorService.GetDoctorById(appointment.DoctorId);
            Patient patient = await _patientService.GetPatientById(appointment.PatientId);

            ctrlAppointmentDetails1.LoadAppointmentInfo(appointment, doctorReadDto, patient);

        }
    }
}
