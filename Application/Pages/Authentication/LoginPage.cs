using Application.Services;
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
        public LoginPage()
        {
            InitializeComponent();
            Form? MainForm = NavigationService.MainForm;

            MainForm?.ClientSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }
    }
}
