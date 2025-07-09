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
using TebeeLite.Infrastructure.Models;


namespace TebeeLite.WinForms.Patients
{
    public partial class PatientShow : Form
    {

        private readonly IPatientService _patientService;

        private readonly IServiceProvider _serviceProvider;

        private int _PatientID = -1;

        public PatientShow(IPatientService patientService, IServiceProvider serviceProvider, int patientId)
        {
            InitializeComponent();
            _patientService = patientService;
            _PatientID = patientId;
            _serviceProvider = serviceProvider;
        }
  
        private async void PatientShow_Load(object sender, EventArgs e)
        {
            Patient patient = await _patientService.GetPatientById(_PatientID);
            ctrlPatientCard1.LoadPatientInfo(patient);// اعرض بيانات الكنترول

        }
    }
}
