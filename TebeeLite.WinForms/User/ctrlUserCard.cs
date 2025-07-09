using Microsoft.Extensions.DependencyInjection;
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

namespace TebeeLite.WinForms.User
{
    public partial class ctrlUserCard : UserControl
    {

        private int _UserID = -1; // معرف المستخدم الذي سيتم تعديله


        public int UserID
        {
            get { return _UserID; }
        }
        private UserReadDto _User;

        public UserReadDto SelectedUserInfo
        {
            get { return _User; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
  
        }

        //تحميل معلومات الشخص

        public void LoadUserInfo(UserReadDto user)// نعرض بيانات الشخص على حسب رقمة الوطني
        {

            _User = user;
            if (_User == null)
            {
                ResetPersonInfo();
                MessageBox.Show("لا يوجد مستخدم بهاذا الرقم = " + UserID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }




        //   عرض البيانات
        private void _FillPersonInfo()
        {
            _UserID = _User.UserId;
            lblUserID.Text = _User.UserId.ToString();
            lblUserName.Text = _User.Username;
            lblFullName.Text = _User.FullName;
            lblRoleName.Text = _User.RoleName;
            lblIsActive.Text = (_User.IsActive) ? "نعم" : "لا";


        }


        // لو البيانات مش موجوده يعمل اعاده تحميل
        public void ResetPersonInfo()
        {
            _UserID = -1;
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblUserID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblRoleName.Text = "[????]";
            lblIsActive.Text = "[????]";

        }



        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

 

        private void frmAddUpdateUser_DataBack(object sender, int UserID)
        {
            LoadUserInfo(_User);
        }
    }
}
