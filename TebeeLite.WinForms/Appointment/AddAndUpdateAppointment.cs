using Hotel.Global_Classes;
using System.ComponentModel;
using TebeeLite.Application.DTOs.Appointment;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application;



namespace TebeeLite.WinForms.Appointment
{
    public partial class AddAndUpdateAppointment : Form
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IDoctorService _doctorService;
        private readonly IPatientService _patientService;
        private readonly IAppointmentStateService _appointmentStateService;
        private readonly IServiceProvider _serviceProvider;
        private int _id = -1;
        private AppointmentDto _appointment;


        // داخل فورم AddAndUpdateAppointment
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]


        // داخل فورم AddAndUpdateAppointment
        public AppointmentDto NewAppointment { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AppointmentDto UpdatedAppointment { get; private set; }

        public AddAndUpdateAppointment(IAppointmentService appointmentService,
            IServiceProvider serviceProvider,
            IAppointmentStateService appointmentStateService,
            IDoctorService doctorService,
            IPatientService patientService,
            int id = -1
            )
        {
            InitializeComponent();
            _appointmentService = appointmentService;
            _serviceProvider = serviceProvider;
            _appointmentStateService = appointmentStateService;
            _doctorService = doctorService;
            _patientService = patientService;
            _id = id;
        }

        private async Task LoadAppointmentData()
        {
            if (_id > -1) // وضع التعديل  
            {
                lblTitle.Text = "تحديث الطبيب";
                this.Text = "تحديث الطبيب";

                _appointment = await _appointmentService.GetAppointmentById(_id);
                if (_appointment != null)
                {
                    cmbPatientName.Text = _appointment.PatientName;
                    cmbDoctorName.Text = _appointment.DoctorName;
                    dtpAppointmentDate.Text = _appointment.AppointmentDate;
                    dtpAppointmentTime.Text = _appointment.AppointmentTime;
                    txtNotes.Text = _appointment.Notes;
                    cmbAppointmentStatus.Text = _appointment.StatusName;


                    btnSave.Text = "تحديث";
                }
                else
                {
                    MessageBox.Show("الموعد غير موجود", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else // وضع الإضافة  
            {
                lblTitle.Text = "إضافة موعد جديد";
                this.Text = "إضافة حوعد جديد";
                btnSave.Text = "إضافة";


            }
        }

        private async void AddAndUpdateAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPatients();
                await LoadDoctors();
                await LoadAppointmentState();


                await LoadAppointmentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
        private async Task LoadPatients()
        {

            var patient = await _patientService.GetAllPatients();

            cmbPatientName.DataSource = patient;
            cmbPatientName.DisplayMember = "FullName";
            cmbPatientName.ValueMember = "PatientId";

            cmbPatientName.SelectedIndex = 0; // تعيين القيمة الافتراضية

        }

        private async Task LoadDoctors()
        {

            var doctors = await _doctorService.GetAllDoctors();

            cmbDoctorName.DataSource = doctors;
            cmbDoctorName.DisplayMember = "FullName";
            cmbDoctorName.ValueMember = "DoctorId";

            cmbDoctorName.SelectedIndex = 0; // تعيين القيمة الافتراضية
        }

        private async Task LoadAppointmentState()
        {

            var state = await _appointmentStateService.GetAllIAppointmentStatus();

            cmbAppointmentStatus.DataSource = state;
            cmbAppointmentStatus.DisplayMember = "StatusName";
            cmbAppointmentStatus.ValueMember = "StatusId";

            cmbAppointmentStatus.SelectedIndex = 0; // تعيين القيمة الافتراضية


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // الحصول على التاريخ من DateTimePicker
                DateTime selectedDate = dtpAppointmentDate.Value;

                // الحصول على الوقت من DateTimePicker
                DateTime selectedTime = dtpAppointmentTime.Value;

                // دمج التاريخ والوقت في كائن DateTime واحد
                DateTime combinedDateTime = new DateTime(
                    selectedDate.Year,
                    selectedDate.Month,
                    selectedDate.Day,
                    selectedTime.Hour,
                    selectedTime.Minute,
                    selectedTime.Second
                );
                if (_id == -1)
                {

                    var newAppointmentDto = new CreateAppointment
                    {
                        PatientId = (int)cmbPatientName.SelectedValue,
                        DoctorId = (int)cmbDoctorName.SelectedValue,
                        BookedByUserId = clsGlobal.CurrentUser.UserId,
                        AppointmentDate = combinedDateTime,
                        Notes = txtNotes.Text, // Fixed CS0029 by converting DateTime to DateOnly  
                        StatusId = (int)cmbAppointmentStatus.SelectedValue,
                        CreatedAt = DateTime.Now,
                    };

                    // Assuming _patientService is the correct service to use for creating a patient  
                    var response = await _appointmentService.AddAppointment(newAppointmentDto); // Fixed CS0103 by using _patientService  

                    if (response != null)
                    {
                        NewAppointment = new AppointmentDto
                        {
                            AppointmentId = response.AppointmentId,
                            PatientName = response.PatientName,
                            DoctorName = response.DoctorName,
                            BookedByUserName = response.BookedByUserName,
                            AppointmentDate = response.AppointmentDate,
                            AppointmentTime = response.AppointmentTime,
                            StatusName = response.StatusName,
                            Diagnosis = response.Diagnosis,
                            Treatment = response.Treatment,
                            Notes = response.Notes,
                            CreatedAt = response.CreatedAt,
                            UpdatedAt = response.UpdatedAt,
                        };
                        MessageBox.Show("تم إنشاء الموعد بنجاح");
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
                    var newAppointmentDto = new CreateAppointment
                    {
                        PatientId = (int)cmbPatientName.SelectedValue,
                        DoctorId = (int)cmbDoctorName.SelectedValue,
                        BookedByUserId = clsGlobal.CurrentUser.UserId,
                        AppointmentDate = combinedDateTime,
                        Notes = txtNotes.Text, // Fixed CS0029 by converting DateTime to DateOnly  
                        StatusId = (int)cmbAppointmentStatus.SelectedValue,
                        CreatedAt = DateTime.Now,
                    };

                    // Assuming _patientService is the correct service to use for creating a patient  
                    var response = await _appointmentService.UpdateAppointment(_id, newAppointmentDto); // Fixed CS0103 by using _patientService  

                    if (response != null)
                    {

                        UpdatedAppointment = new AppointmentDto
                        {
                            AppointmentId = response.AppointmentId,
                            PatientName = response.PatientName,
                            DoctorName = response.DoctorName,
                            BookedByUserName = response.BookedByUserName,
                            AppointmentDate = response.AppointmentDate,
                            AppointmentTime = response.AppointmentTime,
                            StatusName = response.StatusName,
                            Diagnosis = response.Diagnosis,
                            Treatment = response.Treatment,
                            Notes = response.Notes,
                            CreatedAt = response.CreatedAt,
                            UpdatedAt = response.UpdatedAt,
                        };
                        MessageBox.Show("تم تعديل الموعد بنجاح");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في التعديل", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
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