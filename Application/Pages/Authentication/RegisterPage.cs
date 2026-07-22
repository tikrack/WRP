using Application.Entities;
using Application.Pages.Dashboard;
using Application.Services;
using Application.Services.Storage;
using Application.Services.Validation;
using Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application.Pages.Authentication
{
    public partial class RegisterPage : UserControl
    {
        StorageService storageService = new StorageService();

        public RegisterPage()
        {
            InitializeComponent();
            Form? MainForm = NavigationService.MainForm;

            MainForm?.ClientSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();

            user.FirstName = firstname_txtbox.Text.Trim();
            user.LastName = lastname_txtbox.Text.Trim();
            user.UserName = username_txtbox.Text.Trim();
            user.Password = password_txtbox.Text.Trim();

            string[] errors = ValidationService.Validation(user).ToArray();

            if (errors.Length > 0)
            {
                Alert.Show(
                    "اطلاعات نادرست",
                    errors[0],
                    "اطلاعات ورودی شما اشتباه است لطفا انرا ویرایش کنید."
                );

                return;
            }

            storageService.Insert(user);

            NavigationService.Navigate(new LoginPage());
        }
    }
}
