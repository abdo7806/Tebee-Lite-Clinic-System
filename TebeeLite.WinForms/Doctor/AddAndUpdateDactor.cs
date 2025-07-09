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

namespace TebeeLite.WinForms.Doctor
{
    public partial class AddAndUpdateDactor : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IUserService _userService;

        private readonly IServiceProvider _serviceProvider;
        private int _id = -1;

        private DoctorReadDto _doctor;



        public AddAndUpdateDactor(IDoctorService doctorService,
            IUserService userService,
            IServiceProvider serviceProvider, int id = -1)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _serviceProvider = serviceProvider;
            _userService = userService;
            _id = id;
        }







        private async Task LoadUserData()
        {
            if (_id > -1) // وضع التعديل
            {
                lblTitle.Text = "تحديث الطبيب";
                this.Text = "تحديث الطبيب";

                _doctor = await _doctorService.GetDoctorById(_id);
                if (_doctor != null)
                {
                    txtFullName.Text = _doctor.FullName;
                    txtUsername.Text = _doctor.Username;
                    txtSpecialization.Text = _doctor.Specialization;
                    txtWorkingHours.Text = _doctor.WorkingHours;
                    txtLicenseNumber.Text = _doctor.LicenseNumber;
                    nudYearsOfExperience.Value = _doctor.YearsOfExperience ?? 0;
                    txtEducation.Text = _doctor.Education;
                    txtNotes.Text = _doctor.Notes;
                    txtPassword.Text = "*********";
                    txtConfirmPassword.Text = "*********";
                    txtPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;


                    chkIsActive.Checked = _doctor?.IsActive ?? false;
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
            }
        }


        private async void AddAndUpdateDactor_Load(object sender, EventArgs e)
        {
            await LoadUserData();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

    

            try
            {
                if (_id == -1)
                {
                    var newUserDto = new UserCreateDto
                    {
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text, // يتم التشفير داخل الخدمة
                        FullName = txtFullName.Text.Trim(),
                        Role = UserRoleEnum.Doctor,
                        CreatedDate = DateTime.Now,
                        //IsActive = chkIsActive.Checked
                    };

                    var responseCreateUser = await _userService.CreateAsync(newUserDto);
                    if (responseCreateUser != null)
                    {

                        var newDactor = new DoctorCreateDto
                        {
                            UserId = responseCreateUser.UserId,
                            Specialization = txtSpecialization.Text,
                            LicenseNumber = txtLicenseNumber.Text,
                            Education = txtEducation.Text,
                            YearsOfExperience = Convert.ToInt32(nudYearsOfExperience.Value),
                            WorkingHours = txtWorkingHours.Text,
                            Notes = txtNotes.Text,
                            CreatedAt = DateTime.Now,
                        };


                        var responseCreateDactor = await _doctorService.AddDoctor(newDactor);

                        if (responseCreateDactor != null)
                        {

                            MessageBox.Show("تم إنشاء الطبيب بنجاح");
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("خطأ في الاضافة: ", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("خطأ في الاضافة: ", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    var user = new UserUpdateDto
                    {
                        FullName = txtFullName.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        Role = UserRoleEnum.Doctor,
                        IsActive = chkIsActive.Checked,
                        UpdatedAt = DateTime.Now

                    };


                    user.UserId = _doctor.UserId;
                    var responseUpdateUser = await _userService.UpdateAsync(_doctor.UserId, user);
                    if (responseUpdateUser != null)
                    {
                        var newDactor = new DoctorUpdateDto
                        {
                            Specialization = txtSpecialization.Text,
                            LicenseNumber = txtLicenseNumber.Text,
                            Education = txtEducation.Text,
                            YearsOfExperience = Convert.ToInt32(nudYearsOfExperience.Value),
                            WorkingHours = txtWorkingHours.Text,
                            Notes = txtNotes.Text,
                            UpdatedAt = DateTime.Now,
                        };


                        var responseUpdateDactor = await _doctorService.UpdateDoctor(_id, newDactor);

                        if (responseUpdateDactor != null)
                        {

                            MessageBox.Show("تم تحديث الطبيب بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("خطأ في الاضافة: ", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

 

                    }
                    else
                    {
                        MessageBox.Show($"حدث خطأ في التعديل:", "خطأ",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private async void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "لا يمكن أن يكون اسم المستخدم فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            };


            if (_id < 0)
            {
                // لو كان المستخدم موجود بالفعل
                UserReadDto user = await _userService.GetByUsernameAsync(txtUsername.Text.Trim());
                if (user != null)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "اسم المستخدم يستخدمه مستخدم آخر");
                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                };
            }
            else
            {
                if (_doctor.Username != txtUsername.Text.Trim())
                {
                    // لو كان المستخدم موجود بالفعل
                    UserReadDto user = await _userService.GetByUsernameAsync(txtUsername.Text.Trim());
                    if (user != null)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUsername, "اسم المستخدم يستخدمه مستخدم آخر");
                    }
                    else
                    {
                        errorProvider1.SetError(txtUsername, null);
                    };
                }
            }
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
            else if (txtUsername.Text.Any(char.IsSymbol) || txtFullName.Text.Any(char.IsPunctuation))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "لا يمكن أن يحتوي الاسم على رموز أو علامات ترقيم");
            }
            else
            {
                errorProvider1.SetError(txtFullName, null);
            };
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "لا يمكن أن تكون كلمة المرور فارغة");
            }
            else if (txtPassword.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "يجب أن تكون كلمة المرور على الأقل 6 أحرف");
            }
            /*   else if (!txtPassword.Text.Any(char.IsDigit))
               {
                   e.Cancel = true;
                   errorProvider1.SetError(txtPassword, "يجب أن تحتوي كلمة المرور على رقم واحد على الأقل");
               }
               else if (!txtPassword.Text.Any(char.IsUpper))
               {
                   e.Cancel = true;
                   errorProvider1.SetError(txtPassword, "يجب أن تحتوي كلمة المرور على حرف كبير واحد على الأقل");
               }
            else if (!txtPassword.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "يجب أن تحتوي كلمة المرور على حرف واحد على الأقل");
            }
            else if (!txtPassword.Text.Any(char.IsSymbol) && !txtPassword.Text.Any(char.IsPunctuation))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "يجب أن تحتوي كلمة المرور على رمز واحد على الأقل");
            }*/
            else if (txtPassword.Text.Contains(" "))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "لا يمكن أن تحتوي كلمة المرور على مسافات");
            }

            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtEducation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEducation.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEducation, "لا يمكن أن يكون المؤهلات التعليمية فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEducation, null);
            };
        }

        private void txtSpecialization_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpecialization.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSpecialization, "لا يمكن أن يكون التخصص فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSpecialization, null);
            };

        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseNumber, "لا يمكن أن يكون رقم الترخيص فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLicenseNumber, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة المرور لا يتطابق مع كلمة المرور!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }
    }
}
