using Application.Pages.Dashboard;
using Application.Services;
using Application.Services.Storage;
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
    public partial class LoginPage : UserControl
    {
        StorageService storageService = new StorageService();

        public LoginPage()
        {
            InitializeComponent();
            Form? MainForm = NavigationService.MainForm;

            MainForm?.ClientSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = storageService.Where(user => user.UserName == username.Text);

            if(users.Count < 1 || password.Text != users[0].Password)
            {
                Alert.Show(
                    "یافت نشد.",
                    "کاربر مورد نظر پیدا نشد.",
                    "کاربری که قصد ورود با ان را داشتید در سیستم موجود نمیباشد."
                );
                return;
            }

            NavigationService.Navigate(new DashboardPage());
        }
    }
}
