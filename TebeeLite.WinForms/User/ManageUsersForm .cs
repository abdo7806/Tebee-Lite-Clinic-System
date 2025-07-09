using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;
using TebeeLite.WinForms.User;

namespace TebeeLite.WinForms;

public partial class ManageUsersForm : Form
{
    private readonly IUserService _userService;
    private readonly IServiceProvider _serviceProvider;

    private static List<UserReadDto> _dtAllUsers;

    public ManageUsersForm(IUserService userService, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _userService = userService;
        _serviceProvider = serviceProvider;
    }


    private async void Form1_Load(object sender, EventArgs e)
    {

        _dtAllUsers = await _userService.GetAllAsync();

        // „À·« ⁄—÷ «·√ÿ»«¡ ›Ì DataGridView
        dgvUsers.DataSource = _dtAllUsers;


        lblCountUsers.Text = _dtAllUsers.Count.ToString();

        cbFilterBy.SelectedIndex = 0;
        if (dgvUsers.Rows.Count > 0)
        {
            dgvUsers.Columns[0].HeaderText = "—ﬁ„ «·„” Œœ„";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "(username) «”„ «·„” Œœ„";
            dgvUsers.Columns[1].Width = 150;

            dgvUsers.Columns[2].HeaderText = "«·«”„ ﬂ«„·";
            dgvUsers.Columns[2].Width = 250;

            dgvUsers.Columns[3].HeaderText = "«·’·«ÕÌ« ";
            dgvUsers.Columns[3].Width = 120;



            dgvUsers.Columns[4].HeaderText = "Â· ÂÊ« ‰«‘ÿ";
            dgvUsers.Columns[4].Width = 120;

        }

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        /* AddUserForm addUserForm = new AddUserForm();
         addUserForm.ShowDialog();*/

        var form = _serviceProvider.GetRequiredService<AddUserForm>();
        if (form.ShowDialog() == DialogResult.OK)
        {
            // √⁄œ  Õ„Ì· «·„” Œœ„Ì‰
            Form1_Load(null, null);
        }
        /*    using (var form = serviceProvider.GetRequiredService<AddUserForm>();)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                 //   LoadUsers(); // ≈⁄«œ…  Õ„Ì· «·»Ì«‰«  »⁄œ «·≈÷«›…
                }
            }*/
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void  ⁄œÌ·ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
        var form = ActivatorUtilities.CreateInstance<EditUserForm>(_serviceProvider, selectedUserId);
        form.ShowDialog();
        Form1_Load(null, null);

    }

    private async void Õ–›ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
        if (MessageBox.Show("Â· √‰  „ √ﬂœ √‰ﬂ  —Ìœ Õ–› „⁄—› «·„” Œœ„ = [" + UserID + "]", " √ﬂÌœ «·Õ–›", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            if (await _userService.DeleteAsync(UserID))
            {
                MessageBox.Show(" „ Õ–› «·„” Œœ„ »‰Ã«Õ", " „ «·Õ–›", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(null, null);
            }

            else
                MessageBox.Show("·« Ì „ Õ–› «·„” Œœ„ »”»» «·»Ì«‰«  «·„— »ÿ… »Â.", "›‘·", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbFilterBy.Text == "Â· ÂÊ« ‰«‘ÿ")
        {
            txtFilterValue.Visible = false;
            cbIsActive.Visible = true;
            cbIsActive.Focus();
            cbIsActive.SelectedIndex = 0;
        }

        else

        {

            txtFilterValue.Visible = (cbFilterBy.Text != "«Œ «— «·⁄„Êœ");
            cbIsActive.Visible = false;



            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {
        string FilterColumn = "";

        //Map Selected Filter to real Column name 
        switch (cbFilterBy.Text)
        {
            case "—ﬁ„ «·„” Œœ„":
                FilterColumn = "UserID";
                break;
            case "(username) «”„ «·„” Œœ„":
                FilterColumn = "Username";
                break;
            case "«·«”„ ﬂ«„·":
                FilterColumn = "FullName";
                break;
            case "«·œÊ—":
                FilterColumn = "RoleName";
                break;
            default:
                FilterColumn = "«Œ «— «·⁄„Êœ";
                break;

        }

        //Reset the filters in case nothing selected or filter value conains nothing.
        if (txtFilterValue.Text.Trim() == "" || FilterColumn == "«Œ «— «·⁄„Êœ")
        {

            dgvUsers.DataSource = _dtAllUsers;
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
            return;
        }

        if (FilterColumn == "UserID")
        {
            //  ÿ»Ìﬁ «·›· —… »«” Œœ«„ LINQ Ê Reflection


            dgvUsers.DataSource = _dtAllUsers.Where(u => u.UserId == Convert.ToInt32(txtFilterValue.Text.Trim())).ToList();
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();

            return;
        }

        //  ÿ»Ìﬁ «·›· —… »«” Œœ«„ LINQ Ê Reflection
        List<UserReadDto> filteredList = _dtAllUsers.Where(u =>
           (typeof(Patient).GetProperty(FilterColumn)?.GetValue(u, null) ?? "").ToString().ToLower().Contains(txtFilterValue.Text.Trim().ToLower())).ToList();

        dgvUsers.DataSource = filteredList;

        lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
    }

    private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
    {
        string FilterColumn = "IsActive";
        string FilterValue = cbIsActive.Text;

        switch (FilterValue)
        {
            case "All":
                dgvUsers.DataSource = _dtAllUsers;
                break;
            case "Yes":
                dgvUsers.DataSource = _dtAllUsers.Where(u => u.IsActive == true).ToList(); ;

                break;
            case "No":
                dgvUsers.DataSource = _dtAllUsers.Where(u => u.IsActive == false).ToList(); ;
                break;
        }
        lblCountUsers.Text = dgvUsers.Rows.Count.ToString();



    }

    private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (cbFilterBy.Text == "—ﬁ„ «·„” Œœ„")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void ⁄—÷ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
        var form = ActivatorUtilities.CreateInstance<ShowUser>(_serviceProvider, selectedUserId);
        form.ShowDialog();
        Form1_Load(null, null);
    }
}
