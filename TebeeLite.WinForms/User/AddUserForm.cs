using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.WinForms.User
{
    public partial class AddUserForm : Form
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public AddUserForm(IUserService userService, IRoleService roleService)
        {
            InitializeComponent();
            _roleService = roleService;
            _userService = userService;

        }
        public AddUserForm(IUserService userService, IRoleService roleService, int id)
        {
            MessageBox.Show("id: " + id);
            InitializeComponent();
            _roleService = roleService;
            _userService = userService;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // var roles = _roleService.GetAllRoles();
            var roles = new List<Role>
            {
                new Role{RoleId= 1, RoleName= "Admin" },
                //new Role{RoleId=2, RoleName = "Doctor" },
                new Role{RoleId=3, RoleName = "Receptionist"}, // موظف استقبال
                new Role{RoleId=4, RoleName = "Accountant"} // محاسب
            };
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleId";

            cmbRoles.SelectedIndex = 0; // تعيين القيمة الافتراضية
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var newUserDto = new UserCreateDto
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text, // يتم التشفير داخل الخدمة
                FullName = txtFullName.Text.Trim(),
                Role = (UserRoleEnum)cmbRoles.SelectedValue,
                //IsActive = chkIsActive.Checked
            };

            try
            {
               var response = await _userService.CreateAsync(newUserDto);
                if (response != null)
                {
                    MessageBox.Show("تم إنشاء المستخدم بنجاح");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطأ في الاضافة: ", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
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
