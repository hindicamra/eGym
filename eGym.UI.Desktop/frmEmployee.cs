﻿using eGym.BLL.Models;
using eGym.BLL.Models.Enums;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");
        private EmployeeDTO selectedEmployee = new EmployeeDTO();

        public frmEmployee()
        {
            InitializeComponent();
        }

        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null)
                {
                    MessageBox.Show("Morate odabrati korisnika");
                    return;
                }
                await _service.Delete(new { id = selectedEmployee.EmployeeId });

                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");

                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.SelectedIndex = -1;

                selectedEmployee = null;

                MessageBox.Show("Uspjesno obirsan uposlenik");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("Morate unijete sva obavezna polja");
                    return;
                }

                if (!rbZensko.Checked && !rbMale.Checked)
                {
                    MessageBox.Show("Morate odabrati pol");
                    return;
                }

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate odabrati rolu");
                    return;
                }

                if (selectedEmployee == null)
                {
                    MessageBox.Show("Morate odabrati korisnika");
                    return;
                }

                var request = new UpdateAccountRequest()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dateTimePicker1.Value,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                await _service.Put<EmployeeDTO>(selectedEmployee.EmployeeId, request);

                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");

                MessageBox.Show("Uspjesno updatevon uposlenik");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frm = new frmCreateEmployee();

            frm.Show();

            this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedEmployee = dgvEmployee.Rows[index].DataBoundItem as EmployeeDTO;

            txtId.Text = selectedEmployee.EmployeeId.ToString();
            txtName.Text = selectedEmployee.FirstName;
            txtLastName.Text = selectedEmployee.LastName;
            txtPassword.Text = selectedEmployee.Password;
            txtUsername.Text = selectedEmployee.Username;
            dateTimePicker1.Value = selectedEmployee.BirthDate;
            comboBox1.SelectedIndex = (int)selectedEmployee.Role;

            if(selectedEmployee.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProviderApp.SetError(txtName, "Morate unijeti ime");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtName, "");
            }
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Morate unijeti prezime");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLastName, "");
            }
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderApp.SetError(txtUsername, "Morate unijeti username");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderApp.SetError(txtPassword, "Morate unijeti password");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }
    }
}
