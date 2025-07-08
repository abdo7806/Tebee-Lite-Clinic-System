using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.WinForms.User;

namespace TebeeLite.WinForms;

public partial class ManageUsersForm : Form
{
    private readonly IUserService _userService;
    private readonly IServiceProvider _serviceProvider;

    public ManageUsersForm(IUserService userService, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _userService = userService;
        _serviceProvider = serviceProvider;
    }


    private async void Form1_Load(object sender, EventArgs e)
    {
        var users = await _userService.GetAllAsync();
        // ���� ��� ������� �� DataGridView
        dataGridView1.DataSource = users;
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
            // ��� ����� ����������
            Form1_Load(null, null);
        }
        /*    using (var form = serviceProvider.GetRequiredService<AddUserForm>();)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                 //   LoadUsers(); // ����� ����� �������� ��� �������
                }
            }*/
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int selectedUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value);
        var form = ActivatorUtilities.CreateInstance<EditUserForm>(_serviceProvider, selectedUserId);
        form.ShowDialog();
        Form1_Load(null, null);

    }

    private async void ���ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int UserID = (int)dataGridView1.CurrentRow.Cells[0].Value;
        if (MessageBox.Show("�� ��� ����� ��� ���� ��� ���� �������� = [" + UserID + "]", "����� �����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            if (await _userService.DeleteAsync(UserID))
            {
                MessageBox.Show("�� ��� �������� �����", "�� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(null, null);
            }

            else
                MessageBox.Show("�� ��� ��� �������� ���� �������� �������� ��.", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
