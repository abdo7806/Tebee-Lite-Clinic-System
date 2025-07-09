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
using TebeeLite.Application.Interfaces.Services;

namespace TebeeLite.WinForms.Doctor
{
    public partial class ShowDoctor : Form
    {
        private readonly IDoctorService _doctorService;

        private readonly IServiceProvider _serviceProvider;

        private int _doctorId = -1;

        public ShowDoctor(IDoctorService doctorService, IServiceProvider serviceProvider, int doctorId)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _doctorId = doctorId;
            _serviceProvider = serviceProvider;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ShowDoctor_Load(object sender, EventArgs e)
        {
            DoctorReadDto doctor = await _doctorService.GetDoctorById(_doctorId);

            ctrlDoctorCard1.LoadDoctorInfo(doctor);
        }
    }
}
