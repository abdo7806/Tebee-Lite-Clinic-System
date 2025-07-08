using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.WinForms.User
{
    public partial class EditUserForm : Form
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        private int _userId = -1; // معرف المستخدم الذي سيتم تعديله

        private UserReadDto _userReadDto;
        public EditUserForm(IUserService userService, IRoleService roleService, int userId)
        {
            InitializeComponent();
            _roleService = roleService;
            _userService = userService;
            _userId = userId;
        }
        private async void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadRoles();
                await LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async Task LoadRoles()
        {
            // جلب الأدوار من الخدمة بدلاً من القائمة الثابتة
            // var roles = await _roleService.GetAllAsync();

            // يمكنك إضافة الأدوار الافتراضية إذا كانت الخدمة ترجع قائمة فارغة
            /* if (roles == null || !roles.Any())
             {
                 roles = new List<Role>
                 {
                     new Role { RoleId = 1, RoleName = "Admin" },
                     new Role { RoleId = 3, RoleName = "Receptionist" },
                     new Role { RoleId = 4, RoleName = "Accountant" }
                 };
             */

            var roles = new List<Role>
                {
                    new Role { RoleId = 1, RoleName = "Admin" },
                    new Role { RoleId = 3, RoleName = "Receptionist" },
                    new Role { RoleId = 4, RoleName = "Accountant" }
                };

            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleId";
        }

        private async Task LoadUserData()
        {
            if (_userId > 0) // وضع التعديل
            {
                _userReadDto = await _userService.GetByIdAsync(_userId);
                if (_userReadDto != null)
                {
                    txtFullName.Text = _userReadDto.FullName;
                    txtUsername.Text = _userReadDto.Username;
                    cmbRoles.Text = _userReadDto.RoleName;
                    chkIsActive.Checked = _userReadDto.IsActive;
                    btnSave.Text = "تحديث";
                }
                else
                {
                    MessageBox.Show("المستخدم غير موجود", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else // وضع الإضافة
            {
                btnSave.Text = "إضافة";
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateChildren())
                {
                    //Here we dont continue becuase the form is not valid
                    MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                var user = new UserUpdateDto
                {
                    FullName = txtFullName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Role = (UserRoleEnum)cmbRoles.SelectedValue,
                    IsActive = chkIsActive.Checked
                };


                user.UserId = _userId;
              var response = await _userService.UpdateAsync(_userId, user);
                if (response != null)
                {
                    MessageBox.Show("تم تحديث المستخدم بنجاح", "نجاح",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show($"حدث خطأ في التعديل:", "خطأ",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

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


            if (_userReadDto.Username != txtUsername.Text.Trim())
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
