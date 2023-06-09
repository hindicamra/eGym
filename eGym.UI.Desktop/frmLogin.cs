﻿using eGym.BLL.Models.Requests;
using System.ComponentModel;
using System.Windows.Forms;

namespace eGym.UI.Desktop
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Employee");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Morate unijete username i password");
                return;
            }

            APIService.Username = txbUsername.Text;
            APIService.Password = txbPassword.Text;

            try
            {
                var request = new LoginRequest() 
                {
                    Username = txbUsername.Text,
                    Password = txbPassword.Text
                };
                var result = await _apiService.Login<dynamic>(request, "/login");

                frmMain frm = new frmMain();
                frm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogresan username ili password");
            }
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                e.Cancel = true;
                txbUsername.Focus();
                errorProviderApp.SetError(txbUsername, "Morate unijeti username");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txbUsername, "");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                e.Cancel = true;
                txbUsername.Focus();
                errorProviderApp.SetError(txbPassword, "Morate unijeti password");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txbUsername, "");
            }
        }
    }
}
