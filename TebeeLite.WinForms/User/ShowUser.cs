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
    public partial class ShowUser : Form
    {
        private readonly IUserService _userService;

        private readonly IServiceProvider _serviceProvider;

        private int _UserID = -1;

        public ShowUser(IUserService userService, IServiceProvider serviceProvider, int userId)
        {
            InitializeComponent();
            _userService = userService;
            _UserID = userId;
            _serviceProvider = serviceProvider;
        }
        private async void ShowUser_Load(object sender, EventArgs e)
        {
            UserReadDto user = await _userService.GetByIdAsync(_UserID);
            ctrlUserCard1.LoadUserInfo(user);// اعرض بيانات الكنترول

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
