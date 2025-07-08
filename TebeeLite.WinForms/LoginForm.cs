using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
using TebeeLite.Application.DTOs.Auth;
using TebeeLite.Application.Interfaces.Services;
using static Hotel.Global_Classes.clsGlobal;

namespace TebeeLite.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;


        public LoginForm(IAuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginRequestDto
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            if (string.IsNullOrEmpty(loginDto.Username) || string.IsNullOrEmpty(loginDto.Password))
            {
                lblError.Text = "يرجى إدخال اسم المستخدم وكلمة المرور.";
                txtUsername.Focus();
                return;
            }
            var response = await _authService.LoginAsync(loginDto);
            if (response == null)
            {
                txtUsername.Focus();
                lblError.Text = "خطأ في تسجيل الدخول. يرجى التحقق من اسم المستخدم وكلمة المرور.";
                return;
            }

            if (!response.IsActive)
            {
                txtUsername.Focus();
                 lblError.Text = "المستخدم غير نشط. يرجى الاتصال بالمسؤول.";
                return;
            }

            if (!response.IsAuthenticated)
            {
                txtUsername.Focus();
               lblError.Text = response.ErrorMessage;
                return;
            }

            

            // تسجيل بيانات المستخدم الحالي في مكان مركزي (مثلاً CurrentUser static class)
            // تسجيل بيانات المستخدم في CurrentUser
            CurrentUser.UserId = response.UserId;
            CurrentUser.Username = response.Username;
            CurrentUser.FullName = response.FullName;
            CurrentUser.RoleName = response.RoleName;

            // افتح الفورم الرئيسي واغلق تسجيل الدخول
            //  var mainForm = new MainForm();
            var form = _serviceProvider.GetRequiredService<MainForm>();
            form.ShowDialog();
           
          
            this.Hide();
        }


    }
}
